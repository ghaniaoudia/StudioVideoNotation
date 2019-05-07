import { Component } from '@angular/core';
import { EditService } from './services/edit.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
  providers: [EditService],
})
export class AppComponent {
  title = 'SVN';
}
