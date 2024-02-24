import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './components/Home/home.component';
import { EmployeeListComponent } from './components/employees/employee-list/employee-list.component';
import { EmployeeCreateComponent } from './components/employees/employee-create/employee-create.component';

const routes: Routes = [
  {'path': '', component:HomeComponent},
  {'path': 'employees-list', component:EmployeeListComponent},
  {'path': 'employee-create', component:EmployeeCreateComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
