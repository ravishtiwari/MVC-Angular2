import { Component } from '@angular/core';

@Component({
    selector: 'createorder-app',
    templateUrl: './orders/createorder',
})
export class CreateOrder {
    name: String = 'Angular';
    countries: Array<Object> = [
        { id: 1, name: "United States" },
        { id: 2, name: "India" },
        { id: 3, name: "Canada" },
        { id: 4, name: "Brazil" },
        { id: 5, name: "England" }
    ];
}
