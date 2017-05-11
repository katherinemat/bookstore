import { Component, Input, OnInit } from '@angular/core';
import { Http } from '@angular/http';
import {RequestOptions, Request, RequestMethod} from '@angular/http';


@Component({
    selector: 'app-details',
    template: require('./details.component.html')
})
export class DetailsComponent implements OnInit {
    @Input() selectedBook: Book;

    public clickedBook: Book;

    ngOnInit() {
    }

    constructor(private http: Http) {
        console.log(this.selectedBook);
    }

    
}

interface Book {
    BookId: number;
    Title: string;
    Author: string;
}
