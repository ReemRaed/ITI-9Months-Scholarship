import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-form',
  templateUrl: './form.component.html',
  styleUrls: ['./form.component.css']
})
export class FormComponent {


  FormValidation = new FormGroup(
    {
      name: new FormControl("",[Validators.maxLength(20),Validators.minLength(2),Validators.required]),
      age:new FormControl(20,[Validators.max(40),Validators.min(20),Validators.required]),
      email:new FormControl("",[Validators.email,Validators.required]),
    }
  );
  get NameValid()
  {
    return this.FormValidation.controls['name'].valid;
  }
  get AgeValid()
  {
    return this.FormValidation.controls['age'].valid;
  }
  get EmailValid()
  {
    return this.FormValidation.controls['email'].valid;
  }
  getValue()
  {

     if(this.FormValidation.status=="VALID")
      alert("Register Done!!");
      else
      alert("Try again");
      }
  
}
