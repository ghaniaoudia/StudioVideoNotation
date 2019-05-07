import { Injectable } from '@angular/core';
import { HttpHeaders, HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { map, catchError, tap } from 'rxjs/operators';


@Injectable({
  providedIn: 'root'
})
export class PrestationService {

  private accessPointUrl: string = 'http://localhost:60000/api/prestation/';
  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type':  'application/json'
    })};

  constructor(private httpClient: HttpClient) { }

  
  private extractData(res: Response) {
    let body = res;
    return body || { };
  }

  public getPrestations() {
    // Get all prestations data
    return this.httpClient.get(this.accessPointUrl, {headers: this.httpOptions.headers});
  }

  getPrestation(id): Observable<any> {
    return this.httpClient.get(this.accessPointUrl + id)
    .pipe(map(this.extractData));
  }
}
