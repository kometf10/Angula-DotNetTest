import { Component } from '@angular/core';
import { Employee } from '../../models/employee';
import { EmployeeService } from '../../services/employee.service';

@Component({
  selector: 'app-data',
  templateUrl: './data.component.html',
  styleUrl: './data.component.css'
})
export class DataComponent {
  employees: Employee[] = [];

  constructor(private employeeService: EmployeeService){
  }

  ngOnInit() : void{
    this.employeeService.getEmployees().subscribe((result: Employee[]) => (this.employees = result));

  }
}
