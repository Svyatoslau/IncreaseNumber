import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CounterListComponent } from './counter-base/counter-list/counter-list.component';

const routes: Routes = [
  { path: '', redirectTo: 'numbers', pathMatch: 'full'},
  { path: 'numbers', component: CounterListComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
