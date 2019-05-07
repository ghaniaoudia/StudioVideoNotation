import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { NotationService } from 'src/app/services/notation.service';
import { Router, ActivatedRoute } from '@angular/router';
import { PrestationService } from 'src/app/services/prestation.service';
import { Notation } from 'src/app/models/notation.model';

@Component({
  selector: 'app-notation-form',
  templateUrl: './notation-form.component.html',
  styleUrls: ['./notation-form.component.scss']
})
export class NotationFormComponent implements OnInit {
  notationForm : FormGroup;
  title:string;
  prestation: any;

  constructor(private formBuilder: FormBuilder, 
              private notationService: NotationService,
              private router:Router,
              private prestationService: PrestationService,
              private route: ActivatedRoute ) { }

  ngOnInit() {
    const id = this.route.snapshot.params['id'];
    this.getTitle(id);
    this.initForm();
  }

  initForm(){
    this.notationForm = this.formBuilder.group({
      nom:['', Validators.required],
      prenom:['', Validators.required],
      email:['', [Validators.required,Validators.email]],
      note: [1, Validators.required],
      commentaire: ''
    });
  }

  //Get the title of the video and insert it on the top of the form
  getTitle(id){
    this.prestationService.getPrestation(id).subscribe((data:{}) => {
      this.prestation = data;
      this.title = String(Object.values(data)[1]);
    })
  }


  onSendNote(){
    const newNote : Notation = {
      idClient : 2,
      idPrestation : 1,
      note: parseInt(this.notationForm.get('note').value)
    };
    this.notationService.addNote(newNote).subscribe();
    this.router.navigate(['/not-found']);
  }

}
