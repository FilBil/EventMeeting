import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FlatsForRentComponent } from './functionalities/flats-for-rent/flats-for-rent/flats-for-rent.component';

@NgModule({
  declarations: [
    AppComponent,
    FlatsForRentComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
