import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomePageComponent } from './home-page/home-page.component';
import { ApiKeyComponent } from './api-key/api-key.component';
import { DisplayGridDataComponent } from './display-grid-data/display-grid-data.component';

@NgModule({
  declarations: [
    AppComponent,
    HomePageComponent,
    ApiKeyComponent,
    DisplayGridDataComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
