
import { Component, Inject, OnInit } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatSelectModule } from '@angular/material/select';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { MatNativeDateModule } from '@angular/material/core';



import { OrderNewModalService, Orders, OrderDetails, RequestOrdersCreate } from '../services/ordersnewmodal.service';
import { EmployeeService, EmployeeDropDown } from '../services/employee.service';
import { ProductService, ProductDropDown } from '../services/product.service';
import { ShipperService, ShipperDropDown } from '../services/shipper.service';

import { MatDialogRef } from '@angular/material/dialog';



@Component({
  selector: 'ordersnew-modal',
  templateUrl: './ordersnewmodal.component.html',
  styleUrls: ['./ordersnewmodal.styles.css']
})

export class OrdersNewModalComponent {

  selectedEmpleado: number;
  selectedProducto: number;
  selectedShipper: number;

  _orderRequest: RequestOrdersCreate = {
      orderid: 0,
      custid: 0,
      empid: 0,
      orderdate: '',
      requireddate: '',
      shippeddate: 0,
      freight: 0,
      shipname: '',
      shipaddress: '',
      shipcity: '',
      shipregion: '',
      shippostalcode: '',
      shipcountry: '',
      productid: 0,
      unitprice: 0,
      qty: 0,
      discount: 0,
      shipperid: 0
  };



  emplo: EmployeeDropDown[] = [];
  product: ProductDropDown[] = [];
  shipper: ShipperDropDown[] = [];

  constructor(public dialogRef: MatDialogRef<OrdersNewModalComponent>,
    private emploService: EmployeeService,
    private prodService: ProductService,
    private shipperService: ShipperService,
    private ordernewModalService: OrderNewModalService
  )
  {
    this.selectedEmpleado = this.emplo[0]?.empid;
    this.selectedProducto = this.product[0]?.productid;
    this.selectedShipper = this.shipper[0]?.shipperid; 
  }


  onSave() {


    this._orderRequest.empid = this.selectedEmpleado;
    this._orderRequest.productid = this.selectedProducto;
    this._orderRequest.shipperid = this.selectedShipper;
    this._orderRequest.custid = 78;

    this.ordernewModalService.saveData(this._orderRequest).subscribe(
      response => {
        console.log('Datos guardados exitosamente:', response);
      },
      error => {
        console.error('Error al guardar datos:', error);
      }
    );

    window.alert("Info guardada correctamente");

    this.closeForm();
  }


  ngOnInit(): void {
    this.emploService.getEmployeers().subscribe(dataemplo => {
      this.emplo = dataemplo;
    });

    this.prodService.getProducts().subscribe(datapr => {
      this.product = datapr;
    });

    this.shipperService.getShippers().subscribe(datashp => {
      this.shipper = datashp;
    });




  }

  closeForm(): void {
    this.dialogRef.close();
  }


}
