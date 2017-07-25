//import { Component } from '@angular/core';
import { Component, Directive, Output, EventEmitter, Input, SimpleChange } from '@angular/core';
@Component({
  selector: 'test-app',
  template: `<h1>Hello {{name}}</h1>            
`,
})
export class TestAppComponent  {
    name = 'Test';
    
}
