import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './components/Home/home.component';
import { DataComponent } from './components/Data/data.component';
import { EventComponent } from './components/Event/event.component';

const routes: Routes = [
  {'path': '', component:HomeComponent},
  {'path': 'Data', component:DataComponent},
  {'path': 'Event', component:EventComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
