import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

export interface OrderViewModal {
  orderid: number;
  requireddate: string;
  shippeddate: string;
  shipname: string;
  shipadress: string;
  shipcity: string;
  custid: number;

}

@Injectable({
  providedIn: 'root'
})
export class OrderViewModalService {

  private apiUrl = 'https://localhost:7145/OrdersView?idCustomer=5';

  constructor(private http: HttpClient) { }

  getOrdersByCustomer(): Observable<OrderViewModal[]> {

    return this.http.get<OrderViewModal[]>(this.apiUrl);
  }
}
