import { Injectable } from '@angular/core';
import { HttpHeaders, HttpClient } from '@angular/common/http';
import { Notation } from '../models/notation.model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class NotationService {

  private accessPointUrl: string = 'http://localhost:60000/api/notation';
  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type':  'application/json'
    })};


  constructor(private httpClient: HttpClient) { }

  public addNote(note: Notation): Observable<any> {

    console.log("I'm here");
    return this.httpClient.post(this.accessPointUrl, note, {headers: this.httpOptions.headers});
  }

}
