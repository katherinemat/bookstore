import { Component } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'create',
    template: require('./create.component.html')
})


export class CreateComponent {

    constructor(private http: Http) {}

    submitCreateForm(title: string, author: string) {
        var params = {
            newTitle: title,
            newAuthor: author
        }
        this.http.post('/api/SampleData/Create', "params").subscribe(result => {
        
            console.log(result);
        });
    }
}
