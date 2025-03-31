import { Injectable } from "@angular/core";
import { HttpClient, HttpErrorResponse } from "@angular/common/http";
import { observable, throwError, catchError, Observable } from "rxjs";

@Injectable({
    providedIn: 'root'
})

export class TopStoriesService{
    //Base URL
    private baseUrl = 'http://localhost:32526/api/topstories';

    constructor(private http : HttpClient){}

    //Method to call the backend api with given api key
    getTopStories( apikey : string) : Observable <any>{
        const url = `${this.baseUrl}?apikey=${apikey}`
        console.log('Calling backend API with URL:', url);
        return this.http.get<any>(url).pipe(
            catchError(this.handleError)
        );
    }

    private handleError(error : HttpErrorResponse){
        console.error('Error fetching top stories:', error);
        return throwError(() => new Error('Error fetching top stories. Please try again later'));
    }
}