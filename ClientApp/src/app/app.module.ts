import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { CounterComponent } from './component/counter/counter.component';
import { FetchDataComponent } from './component/fetch-data/fetch-data.component';
import { HomeComponent } from './component/home/home.component';
import { ModelFormComponent } from './component/model-form/model-form.component';
import { ProductFormComponent } from './component/product-form/product-form.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { BrandService } from './services/brand.service';
import { ProductsService } from './services/products.service';


@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    ProductFormComponent,
    ModelFormComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'products/new-model', component: ModelFormComponent },
      { path: 'products/new', component: ProductFormComponent },
      { path: 'products/:id', component: ProductFormComponent },
      { path: 'fetch-data', component: FetchDataComponent },
    ])
  ],
  providers: [
    BrandService,
    ProductsService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
