import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { NumberListComponent } from './number-base/number-list/number-list.component';

const routes: Routes = [
  { path: '', redirectTo: 'numbers', pathMatch: 'full'},
  { path: 'numbers', component: NumberListComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
