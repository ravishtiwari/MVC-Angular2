import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { AppComponent } from './app.component';
import { CreateOrder } from './app.createordercomponent';


@NgModule({
    imports: [BrowserModule, FormsModule],
  declarations: [AppComponent, CreateOrder],
  bootstrap: [CreateOrder ]
})
export class AppModule { }
