import { Component,Input } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Task';
  arr:{}[] = []
  std:any
  // StudentFromRegister=""
  getData(data:any)
  {
    this.arr.push(data);
    this.std=this.arr

  }

}
