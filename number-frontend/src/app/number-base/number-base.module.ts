import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { NumberListComponent } from './number-list/number-list.component';
import { NumberDetailComponent } from './number-detail/number-detail.component';
import { NumberService } from '../services/number.service';

@NgModule({
  imports: [
    CommonModule
  ],
  declarations: [
    NumberListComponent,
    NumberDetailComponent
  ],
  exports: [
    NumberListComponent,
    NumberDetailComponent
  ]
  providers: [
    NumberService
  ]
})
export class NumberBaseModule { }
