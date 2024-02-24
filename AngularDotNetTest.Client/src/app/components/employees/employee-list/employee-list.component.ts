import { Component } from '@angular/core';
import { Employee } from '../../../models/employee';
import { EmployeeService } from '../../../services/employee.service';

@Component({
  selector: 'app-employee-list',
  templateUrl: './employee-list.component.html',
  styleUrl: './employee-list.component.css'
})
export class EmployeeListComponent {
  employees: Employee[] = []; 

  constructor(private employeeService: EmployeeService){
  }

  ngOnInit() : void{
    this.employeeService.getEmployees().subscribe((result: Employee[]) => (this.employees = result));

  }
}
