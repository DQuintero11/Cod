import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { MatDialogModule } from '@angular/material/dialog';
import { MatButtonModule } from '@angular/material/button';
import { MatTableModule } from '@angular/material/table';
import { MatSortModule } from '@angular/material/sort';
import { MatPaginatorModule } from '@angular/material/paginator';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { SalesPredictionViewComponent } from './salespredictionview/salespredictionview.component';
import { OrdersViewModalComponent } from './ordersviewmodal/ordersviewmodal.component';
import { OrdersNewModalComponent } from './ordersnewmodal/ordersnewmodal.component';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatSelectModule } from '@angular/material/select';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { MatNativeDateModule } from '@angular/material/core';



import { OrdersPredictionService } from './services/ordersprediction.service';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    SalesPredictionViewComponent,
    OrdersViewModalComponent,
    OrdersNewModalComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    BrowserAnimationsModule,
    MatFormFieldModule,
    MatInputModule,
    MatSelectModule,
    MatDatepickerModule,
    MatNativeDateModule,
    MatDialogModule,  
    MatButtonModule,
    MatSortModule,
    MatPaginatorModule,
    HttpClientModule,
    MatTableModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'salespredictionview', component: SalesPredictionViewComponent },
      { path: 'ordernewmodal', component: OrdersNewModalComponent },
      { path: 'orderviewmodal', component: OrdersViewModalComponent }
    ])
  ],
  providers: [OrdersPredictionService],
  bootstrap: [AppComponent],
  entryComponents: [OrdersViewModalComponent, OrdersNewModalComponent]
})
export class AppModule { }
