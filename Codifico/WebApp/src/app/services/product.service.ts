import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

export interface ProductDropDown {
  productid: number;
  productname: string;
}

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  private apiUrl = 'https://localhost:7145/Products';

  constructor(private http: HttpClient) { }

  getProducts(): Observable<ProductDropDown[]> {
    return this.http.get<ProductDropDown[]>(this.apiUrl);
  }
}
