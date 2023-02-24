import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { CounterListComponent } from './counter-list/counter-list.component';
import { CounterDetailComponent } from './counter-detail/counter-detail.component';
import { CounterService } from '../services/counter.service';
import { HttpClientModule } from '@angular/common/http';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { MatInputModule } from '@angular/material/input';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { DatetimePickerComponent } from './datetime-picker/datetime-picker.component';
import { NgxMatDatetimePickerModule, NgxMatNativeDateModule } from '@angular-material-components/datetime-picker';

@NgModule({
  imports: [
    CommonModule,
    HttpClientModule,
    MatDatepickerModule,
    MatInputModule,
    FormsModule,
    MatButtonModule,
    BrowserAnimationsModule,
    NgxMatDatetimePickerModule,
    NgxMatNativeDateModule
  ],
  declarations: [
    CounterListComponent,
    CounterDetailComponent,
    DatetimePickerComponent
  ],
  exports: [
    CounterListComponent,
    CounterDetailComponent,
    DatetimePickerComponent, 
    
  ],
  providers: [
    CounterService,
    MatDatepickerModule
  ]
})
export class CounterBaseModule { }
