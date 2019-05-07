import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NotationFormComponent } from './notation/notation-form/notation-form.component';
import { PrestationsListComponent } from './prestation/prestations-list/prestations-list.component';
import { HeaderComponent } from './header/header.component';
import { NotationService } from './services/notation.service';
import { PrestationService } from './services/prestation.service';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import{  HttpClientModule } from '@angular/common/http';
import { Routes, RouterModule } from '@angular/router';
import { FourOhFourComponent } from './four-oh-four/four-oh-four.component';
import { GridModule } from '@progress/kendo-angular-grid';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { EditService } from '@progress/kendo-angular-grid/dist/es2015/editing/edit.service';
import {  MatSidenavModule, MatFormField, MatFormFieldModule, MatDatepickerModule, NativeDateModule, MatNativeDateModule, MatInputModule} from '@angular/material';



const appRoutes: Routes = [
  {path: 'notation/:id', component: NotationFormComponent},
  {path: 'prestations', component: PrestationsListComponent},
  {path: '', component: PrestationsListComponent},
  {path: 'not-found', component: FourOhFourComponent},
  {path: '**', redirectTo:'not-found'},
];

@NgModule({
  declarations: [
    AppComponent,
    NotationFormComponent,
    PrestationsListComponent,
    HeaderComponent,
    FourOhFourComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    RouterModule.forRoot(appRoutes),
    GridModule,
    BrowserAnimationsModule,
    MatSidenavModule,
    MatFormFieldModule,
    MatDatepickerModule,
    NativeDateModule,
    MatNativeDateModule,
    MatInputModule
  ],
  exports: [MatSidenavModule],
  providers: [
    NotationService,
    PrestationService,
    EditService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
