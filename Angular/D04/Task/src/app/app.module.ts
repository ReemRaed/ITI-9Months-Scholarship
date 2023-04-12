import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { FormComponent } from './Compnents/form/form.component';
import { DetailsComponent } from './Compnents/details/details.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { HeaderComponent } from './Compnents/header/header.component';
import { StudentsComponent } from './Compnents/students/students.component';
import { ErrorComponent } from './Compnents/error/error.component';

@NgModule({
  declarations: [
    AppComponent,
    FormComponent,
    DetailsComponent,
    HeaderComponent,
    StudentsComponent,
    ErrorComponent
  ],
  imports: [
    BrowserModule,
    ReactiveFormsModule,
    FormsModule,
    RouterModule.forRoot([
      
        {path:"",component:StudentsComponent},
        { path:"Students",component:StudentsComponent},
        { path:"details",component:DetailsComponent},
        {path:"form",component:FormComponent},
        {path:"**",component:ErrorComponent}

      
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
