import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

export interface OrderPrediction {
  custid: number;
  companyname: string;
  fechaUltimaOrden: string;
  promediodias: number;
  fechaPosibleSiguienteOrden: string;
}

@Injectable({
  providedIn: 'root'
})
export class OrdersPredictionService {

  private apiUrl = 'https://localhost:7145/OrderPrediction';

  constructor(private http: HttpClient) { }

  getOrdersPrediction(): Observable<OrderPrediction[]> {
    return this.http.get<OrderPrediction[]>(this.apiUrl);
  }
}
