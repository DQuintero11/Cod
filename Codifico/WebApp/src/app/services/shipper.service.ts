import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

export interface ShipperDropDown {
  shipperid: number;
  companyname: string;
}

@Injectable({
  providedIn: 'root'
})
export class ShipperService {

  private apiUrl = 'https://localhost:7145/Shipper';

  constructor(private http: HttpClient) { }

  getShippers(): Observable<ShipperDropDown[]> {
    return this.http.get<ShipperDropDown[]>(this.apiUrl);
  }
}
