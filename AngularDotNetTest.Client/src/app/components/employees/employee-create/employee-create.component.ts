import { Component, OnInit } from '@angular/core';
import { Employee } from '../../../models/employee';
import { EmployeeService } from '../../../services/employee.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-employee-create',
  templateUrl: './employee-create.component.html',
  styleUrl: './employee-create.component.css'
})
export class EmployeeCreateComponent {

  createEmployeesRequest: Employee = {
    firstName: '',
    lastName: '',
    email: '',
    jobTitle: '',
    dateOfBirth: new Date()
  };
  
  constructor(private employeeService: EmployeeService, private router: Router) {
    
  }

  ngOnInit(): void {
  }

  createEmployee(){

    console.log("AERE");

    this.employeeService.createEmployee(this.createEmployeesRequest)
    .subscribe({
      next: (employee) => {
        this.router.navigate(['employees-list']);
      }
    });
  }
}
