import { Component } from '@angular/core';
import { Http } from '@angular/http';
import {RequestOptions, Request, RequestMethod} from '@angular/http';

@Component({
    selector: 'fetchdata',
    template: require('./fetchdata.component.html')
})
export class FetchDataComponent {
    public forecasts: Book[];
    public clickedBook: Book;
    public showDetailsPage: boolean = false;

    constructor(private http: Http) {
        http.get('/api/SampleData/WeatherForecasts').subscribe(result => {
            this.forecasts = result.json();
        });
    }

    goToDetailsPage(book: Book) {
        this.clickedBook = book;
        this.showDetailsPage = true;
        //this.http.request(new Request({
        //    method: RequestMethod.Get,
        //    url: 'api/SampleData/Details',
        //    search: 'id=' + clickedBook.BookId
        //})).subscribe(result => {
        //    this.clickedBook = result.json();
        //});
    }
}

interface Book {
    BookId: number;
    Title: string;
    Author: string;
}
