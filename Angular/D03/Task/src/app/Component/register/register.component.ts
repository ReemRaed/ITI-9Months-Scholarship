import { Component, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent {
  name="";
  age="";
  @Output() Event = new EventEmitter();
  // NewStudent={}
  ADD()
  {
    if(this.name.length>=3 && +this.age <40 && +this.age>20)
    {
      let NewStudent={name:this.name,age:this.age};
      console.log(NewStudent);
      this.Event.emit(NewStudent);
      this.name="";
      this.age="";
    }
  }
}
