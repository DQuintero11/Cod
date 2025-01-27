
import { Component, OnInit } from '@angular/core';
import { OrdersPredictionService, OrderPrediction } from '../services/ordersprediction.service'
import { MatDialog } from '@angular/material/dialog';
import { OrdersViewModalComponent } from '../ordersviewmodal/ordersviewmodal.component';
import { OrdersNewModalComponent } from '../ordersnewmodal/ordersnewmodal.component';
import { OrderViewModalService, OrderViewModal } from '../services/ordersviewmodal.service';
import { OrderNewModalService, Orders , OrderDetails} from '../services/ordersnewmodal.service';
import { ViewChild } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';

@Component({
  selector: 'salespredictionviewcomponent',
  templateUrl: './salespredictionview.component.html',
  styleUrls: ['./salespredictionview.styles.css']
})
export class SalesPredictionViewComponent implements OnInit {

  op: OrderPrediction[] = [];
  obj: OrderViewModal[] = [];




  constructor(private ordersPredictionService: OrdersPredictionService,
    private ordersViewModalService: OrderViewModalService,
    private ordersNewModalService: OrderNewModalService,
    public dialog: MatDialog) { }

  async  esperar(ms: number): Promise<void> {
  return new Promise(resolve => setTimeout(resolve, ms));
};


  async openDialog(id:any): Promise<void> {


    this.ordersViewModalService.getOrdersByCustomerId(id).subscribe(data => {
      this.obj = data;
    });


    await this.esperar(5000);

    const dialogRef = this.dialog.open(OrdersViewModalComponent, {
      width: '800px',  
      height: '800px', 
      disableClose: true,
   
      data: this.obj,
    });



    dialogRef.afterClosed().subscribe(result => {
    });
  }



  async openDialogNew(): Promise<void> {


    //this.ordersViewModalService.getOrdersByCustomer().subscribe(data => {
    //  this.obj = data;
    //});


    await this.esperar(5000);

    const dialogRef = this.dialog.open(OrdersNewModalComponent, {
      width: '1200px',
      height: '1000px',
      disableClose: true,

     // data: this.obj,
    });



    dialogRef.afterClosed().subscribe(result => {
    });
  }


  ngOnInit(): void {
    this.ordersPredictionService.getOrdersPrediction().subscribe(data => {
      this.op = data;
    });



  }

  filtro: string = '';
  paginaActual: number = 1;
  registrosPorPagina: number = 10;
  campoOrdenado: string = 'companyname';  
  direccionOrden: string = 'asc';    


  get registrosFiltrados() {
    if (!this.filtro) {
      return this.op; 
    }


    return this.op.filter(op =>
      op.companyname.toLowerCase().includes(this.filtro.toLowerCase())
    );
  }


  ordenarRegistros() {
    const registrosFiltrados = this.registrosFiltrados;


  
    return registrosFiltrados.sort((a, b) => {
      let campoA = a[this.campoOrdenado as keyof OrderPrediction];
      let campoB = b[this.campoOrdenado as keyof OrderPrediction];

      if (this.direccionOrden === 'asc') {
        return campoA < campoB ? -1 : 1;
      } else {
        return campoA > campoB ? -1 : 1;
      }
    });
  }


  get registrosPaginados() {
    const registrosOrdenados = this.ordenarRegistros();
    const startIndex = (this.paginaActual - 1) * this.registrosPorPagina;
    const endIndex = startIndex + this.registrosPorPagina;
    return registrosOrdenados.slice(startIndex, endIndex);
  }


  cambiarPagina(pagina: number) {
    this.paginaActual = pagina;
  }

  cambiarOrden(campo: string) {
    if (this.campoOrdenado === campo) {
      this.direccionOrden = this.direccionOrden === 'asc' ? 'desc' : 'asc';
    } else {
      this.campoOrdenado = campo;
      this.direccionOrden = 'asc';
    }
  }


  obtenerRegistrosPorPagina() {
    const inicio = (this.paginaActual - 1) * this.registrosPorPagina;
    const fin = inicio + this.registrosPorPagina;
    return this.registrosFiltrados.slice(inicio, fin);
  }


  irAPaginaAnterior() {
    if (this.paginaActual > 1) {
      this.paginaActual--;
    }
  }

  totalPaginas() {
    return Math.ceil(this.registrosFiltrados.length / this.registrosPorPagina);
  }


  irAPaginaSiguiente() {
    const totalPaginas = Math.ceil(this.op.length / this.registrosPorPagina);
    if (this.paginaActual < totalPaginas) {
      this.paginaActual++;
    }

  }
}
