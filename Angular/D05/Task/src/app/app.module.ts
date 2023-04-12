import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FormsModule,ReactiveFormsModule } from '@angular/forms';
import { HeadersComponent } from 'src/Components/headers/headers.component';
import { UsersComponent } from 'src/Components/users/users.component';
import { UsersDetailsComponent } from 'src/Components/users-details/users-details.component';
import { UsersPostComponent } from 'src/Components/users-post/users-post.component';
import { UsersPutComponent } from 'src/Components/users-put/users-put.component';
import {HttpClientModule} from '@angular/common/http';
import { UserserviceService } from 'src/Services/userservice.service';



@NgModule({
  declarations: [
    AppComponent,
    HeadersComponent,
    UsersComponent,
    UsersDetailsComponent,
    UsersPostComponent,
    UsersPutComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule

  ],
  providers: [
    UserserviceService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
