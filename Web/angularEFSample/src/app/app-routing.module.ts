import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PersonsListComponent } from './components/persons/persons-list/persons-list.component';

const routes: Routes = [
  {
    path:'',
    component:PersonsListComponent
  },
  {
    path:'persons',
    component:PersonsListComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
