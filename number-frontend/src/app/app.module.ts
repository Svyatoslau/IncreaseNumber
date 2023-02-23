import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CounterBaseModule } from './counter-base/counter-base.module';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    CounterBaseModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
