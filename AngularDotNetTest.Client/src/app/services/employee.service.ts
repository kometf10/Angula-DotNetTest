import { Injectable } from '@angular/core';
import { Employee } from '../models/employee';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment.development';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {
  controller = "Employees"
  constructor(private httpClient: HttpClient) { }

  public getEmployees() : Observable<Employee[]>{
    return this.httpClient.get<Employee[]>(`${environment.apiUrl}${this.controller}`);
  }

  public createEmployee(createEmployeeRequest: Employee): Observable<Employee>{
    return this.httpClient.post<Employee>(`${environment.apiUrl}${this.controller}`, createEmployeeRequest);
  }
}
