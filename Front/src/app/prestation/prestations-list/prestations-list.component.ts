import { Component, OnInit, Input } from '@angular/core';
import { State, process } from '@progress/kendo-data-query';
import { FormBuilder, FormGroup } from '@angular/forms';
import { PrestationService } from 'src/app/services/prestation.service';
import { EditService } from 'src/app/services/edit.service';
import { GridDataResult } from '@progress/kendo-angular-grid';
import { Prestation } from 'src/app/models/prestation.model';


@Component({
  selector: 'app-prestations-list',
  templateUrl: './prestations-list.component.html',
  styleUrls: ['./prestations-list.component.scss']
})
export class PrestationsListComponent implements OnInit {@Input() prestationsData: Array<any>;
  gridView: GridDataResult;
  prestation: Prestation[];

  constructor(private editService : EditService, private formBuilder: FormBuilder, private prestationService: PrestationService) { 
    prestationService.getPrestations().subscribe((data: any) => this.prestationsData = data);
  }

  public state: State = {
    skip: 0
  }

  ngOnInit() {
  }

  updateGridView() {
    this.gridView = process(this.prestationsData, this.state);
  }

  public cellClickHandler({ sender, rowIndex, columnIndex, dataItem, isEdited }) {
    if (!isEdited) {
      sender.editCell(rowIndex, columnIndex, this.createFormGroup(dataItem));
    }
  }

  public createFormGroup(dataItem: any): FormGroup {
    return this.formBuilder.group({
        'titre': dataItem.titre,
        'referent': dataItem.referent,
        'noteMoy': dataItem.noteMoy,
        'commentaire': dataItem.commentaire
    });
  }

  public cellCloseHandler(args: any) {
    const { formGroup, dataItem } = args;

    if (!formGroup.valid) {
        // prevent closing the edited cell if there are invalid values.
        args.preventDefault();
    } else if (formGroup.dirty) {
        this.editService.assignValues(dataItem, formGroup.value);
        this.editService.update(dataItem);
    }
    console.log(this.prestationsData)
}
}
