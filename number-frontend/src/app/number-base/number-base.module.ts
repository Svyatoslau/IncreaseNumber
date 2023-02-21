import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { NumberListComponent } from './number-list/number-list.component';
import { NumberDetailComponent } from './number-detail/number-detail.component';

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
})
export class NumberBaseModule { }
