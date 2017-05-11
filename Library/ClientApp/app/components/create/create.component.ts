import { Component } from '@angular/core';
import { Http } from '@angular/http';
import {RequestOptions, Request, RequestMethod} from '@angular/http';

@Component({
    selector: 'create',
    template: require('./create.component.html')
})


export class CreateComponent {

    constructor(private http: Http) {}

    submitCreateForm(title: string, author: string) {
        this.http.request(new Request({
            method: RequestMethod.Post,
            url: 'api/SampleData/Create',
            search: 'newAuthor='+ author +'&newTitle=' + title
        })).subscribe(console.log);
    }
}
