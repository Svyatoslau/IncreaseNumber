import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { CounterListComponent } from './counter-list/counter-list.component';
import { CounterDetailComponent } from './counter-detail/counter-detail.component';
import { CounterService } from '../services/counter.service';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  imports: [
    CommonModule,
    HttpClientModule
  ],
  declarations: [
    CounterListComponent,
    CounterDetailComponent
  ],
  exports: [
    CounterListComponent,
    CounterDetailComponent
  ],
  providers: [
    CounterService
  ]
})
export class CounterBaseModule { }
