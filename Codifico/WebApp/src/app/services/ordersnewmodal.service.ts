import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';


export interface Orders {
  orderid: number;
  custid: number;
  empid: number;
  orderdate: string;
  requireddate: string;
  shippeddate: number;
  shipperid: number;
  freight: number;
  shipname: string;
  shipaddress: string;
  shipcity: string;
  shipregion: string;
  shippostalcode: number;
  shipcountry: string;
}


export interface OrderDetails {
  orderid: number;
  productid: number;
  unitprice: number;
  qty: number;
  discount: number;
}

export interface RequestOrdersCreate {
  orderid: number;
  custid: number;
  empid: number;
  orderdate: string;
  requireddate: string;
 shippeddate: number;
  shipperid: number;
  freight: number;
  shipname: string;
  shipaddress: string;
  shipcity: string;
  shipregion: string;
  shippostalcode: string;
  shipcountry: string;
  /////
  productid: number;
  unitprice: number;
  qty: number;
  discount: number;
}


@Injectable({
  providedIn: 'root'
})
export class OrderNewModalService {

  private apiUrl = 'https://localhost:7145/Orders';

  constructor(private http: HttpClient) { }

  saveData(data: any): Observable<any> {
    return this.http.post<any>(this.apiUrl, data, {
      headers: new HttpHeaders({
        'Content-Type': 'application/json'
      })
    });  
  }
}





