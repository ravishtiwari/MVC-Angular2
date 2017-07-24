import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { TestAppComponent }  from './app.testcomponent';
import { CreateOrder } from './app.createordercomponent';


@NgModule({
  imports:      [ BrowserModule ],
  declarations: [AppComponent, TestAppComponent, CreateOrder],
  bootstrap: [CreateOrder, TestAppComponent ]
})
export class AppModule { }
