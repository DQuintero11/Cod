
import { Component, Inject, OnInit, ViewChild } from '@angular/core';
import { MatDialogRef } from '@angular/material/dialog';
import { MAT_DIALOG_DATA } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';


@Component({
  selector: 'ordersview-modal',
  templateUrl: './ordersviewmodal.component.html',
  styleUrls: ['./ordersviewmodal.styles.css']
})

export class OrdersViewModalComponent {


  displayedColumns: string[] = ['orderid', 'requireddate', 'shippeddate', 'shipname', 'shipaddress', 'shipcity'];
  pageSize = 5;  
  dataSource: MatTableDataSource<any> = new MatTableDataSource();

  @ViewChild(MatPaginator) paginator: MatPaginator | undefined;
  @ViewChild(MatSort) sort: MatSort | undefined;

  constructor(@Inject(MAT_DIALOG_DATA) public data: any, public dialogRef: MatDialogRef<OrdersViewModalComponent>) { }

  closeForm(): void {
    this.dialogRef.close();
  }

  ngOnInit() {
    // Asignar los datos a la fuente de datos
    this.data = new MatTableDataSource(this.data);
    this.data.paginator = this.paginator;
    this.data.sort = this.sort;
  }

  pageEvent(event: any) {
    this.data.paginator = this.paginator;
  }



}
