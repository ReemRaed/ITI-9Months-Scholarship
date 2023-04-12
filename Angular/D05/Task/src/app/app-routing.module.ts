import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { UsersDetailsComponent } from 'src/Components/users-details/users-details.component';
import { UsersPostComponent } from 'src/Components/users-post/users-post.component';
import { UsersPutComponent } from 'src/Components/users-put/users-put.component';
import { UsersComponent } from 'src/Components/users/users.component';

const routes: Routes = [
  {path:"",component:UsersComponent},
  {path:"users",component:UsersComponent},
  {path:"users/:id",component:UsersDetailsComponent},
  {path:"adduser",component:UsersPostComponent},
  {path:"updateuser/:id",component:UsersPutComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
