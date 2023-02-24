import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from "@angular/common/http"
import { catchError, Observable, of } from 'rxjs';
import { ICounter } from '../counter-base/models/counter';
import { Increment } from '../counter-base/models/increment';
import { Moment } from 'moment';
import * as moment from 'moment';

@Injectable({
  providedIn: 'root'
})
export class CounterService {
  private counterUrl: string = "https://localhost:7135/api/counter";

  private httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json' 
    })
  };

  constructor(private http: HttpClient) { }
  
  public getCounters(): Observable<ICounter[]> {
    return this.http.get<ICounter[]>(this.counterUrl)
      .pipe(
        catchError(this.handleError<ICounter[]>("getNumbers"))
      );
  }

  public increaseCounter(id: number, increment: Increment): Observable<ICounter> {
    return this.http.put<ICounter>(
        `${this.counterUrl}/${id}`,
        increment,
        this.httpOptions
      )
      .pipe(
        catchError(this.handleError<ICounter>("incareaseCounter"))
      );
  }

  public updatePikedDate(id: number, date: string): Observable<ICounter> {
    let formatDate = moment(date).format("YYYY-MM-DD HH:mm:ss")

    return this.http.patch<ICounter>(
        `${this.counterUrl}/${id}`,
        formatDate,
        this.httpOptions
      )
      .pipe(
        catchError(this.handleError<ICounter>("updatePikedDate"))
      );
  }

  private handleError<T>(operation = 'operation', result?: T) {
    return (error: any): Observable<T> =>{
      console.log(error);
      return of(result as T);
    }
  }

  
}
