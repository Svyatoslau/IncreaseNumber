import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from "@angular/common/http"
import { catchError, Observable, of } from 'rxjs';
import { INumber } from '../number-base/models/number';
import { Increment } from '../number-base/models/increment';

@Injectable({
  providedIn: 'root'
})
export class NumberService {
  private numberUrl: string = "https://localhost:7135/api/number";

  private httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json' 
    })
  };

  constructor(private http: HttpClient) { }
  
  getNumbers(): Observable<INumber[]> {
    return this.http.get<INumber[]>(this.numberUrl)
      .pipe(
        catchError(this.handleError<INumber[]>("getNumbers"))
      );
  }

  increaseNumber(id: number, increment: Increment): Observable<INumber> {
    return this.http.put<INumber>(
        `${this.numberUrl}/${id}`,
        increment,
        this.httpOptions
      )
      .pipe(
        catchError(this.handleError<INumber>("incareaseNumber"))
      );
  }

  private handleError<T>(operation = 'operation', result?: T) {
    return (error: any): Observable<T> =>{
      console.log(error);
      return of(result as T);
    }
  }

  
}
