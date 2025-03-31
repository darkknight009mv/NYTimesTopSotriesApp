import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomePageComponent } from './home-page/home-page.component';
import { ApiKeyComponent } from './api-key/api-key.component';
import { DisplayGridDataComponent } from './display-grid-data/display-grid-data.component';

const routes: Routes = [
  { path: '', redirectTo: '/home', pathMatch: 'full' },
  { path: 'home', component: HomePageComponent },
  { path: 'enter-api-key', component: ApiKeyComponent },
  { path: 'view-data', component: DisplayGridDataComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
