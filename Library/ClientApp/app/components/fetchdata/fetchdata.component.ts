import { Component } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'fetchdata',
    template: require('./fetchdata.component.html')
})
export class FetchDataComponent {
    public forecasts: Book[];

    constructor(http: Http) {
        http.get('/api/SampleData/WeatherForecasts').subscribe(result => {
            this.forecasts = result.json();
            console.log(result.json()[0].title);
        });
    }
}

interface Book {
    Title: string;
    Author: string;
}
