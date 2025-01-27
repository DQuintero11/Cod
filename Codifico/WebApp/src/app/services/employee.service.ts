import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

export interface EmployeeDropDown {
  empid: number;
  name: string;
}

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {

  private apiUrl = 'https://localhost:7145/Employee';

  constructor(private http: HttpClient) { }

  getEmployeers(): Observable<EmployeeDropDown[]> {
    return this.http.get<EmployeeDropDown[]>(this.apiUrl);
  }
}
