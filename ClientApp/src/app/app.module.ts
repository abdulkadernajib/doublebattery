import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { ExtraOptions, RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { CounterComponent } from './component/counter/counter.component';
import { FetchDataComponent } from './component/fetch-data/fetch-data.component';
import { HomeComponent } from './component/home/home.component';
import { ModelFormComponent } from './component/model-form/model-form.component';
import { ProductFormComponent } from './component/product-form/product-form.component';
import { ProductListComponent } from './component/product-list/product-list.component';
import { ViewProductComponent } from './component/view-product/view-product.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { BrandService } from './services/brand.service';
import { PaginationComponent } from './services/pagination.component';
import { PhotosService } from './services/photos.service';
import { ProductsService } from './services/products.service';
import { ProgressService } from './services/progress.service';

var routerOptions: ExtraOptions = {
  scrollPositionRestoration: 'enabled',
  anchorScrolling: 'enabled',
  useHash: false,
  scrollOffset: [0, 64]
}
@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    ProductFormComponent,
    ModelFormComponent,
    ProductListComponent,
    PaginationComponent,
    ViewProductComponent,
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent },
      { path: 'counter', component: CounterComponent },
      { path: 'products', component: ProductListComponent },
      { path: 'products/new-model', component: ModelFormComponent },
      { path: 'products/new', component: ProductFormComponent },
      { path: 'products/edit/:id', component: ProductFormComponent },
      { path: 'products/:id', component: ViewProductComponent },
      { path: 'fetch-data', component: FetchDataComponent },
    ], routerOptions)
  ],
  providers: [
    BrandService,
    ProductsService,
    PhotosService,
    // { provide: XhrFactory, useClass: BrowserXhrWithProgressService },
    ProgressService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
