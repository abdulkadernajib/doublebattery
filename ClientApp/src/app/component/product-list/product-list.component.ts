import { BrandService } from './../../services/brand.service';
import { ProductsService } from './../../services/products.service';
import { Product } from './../../model/product';
import { Component, OnInit } from '@angular/core';
import { KeyValuePair } from 'src/app/model/KeyValuePair';

@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.css']
})
export class ProductListComponent implements OnInit {
  products: Product[];
  brands: KeyValuePair[];
  filter: any = {};
  allProducts: Product[]

  constructor(private productService: ProductsService, private brandService: BrandService) { }

  ngOnInit(): void {
    this.brandService.getBrands().subscribe((b: KeyValuePair[]) => this.brands = b)
    this.productService.getProducts().subscribe((p: Product[]) => this.products = this.allProducts = p);
  }

  OnFilterChange() {
    var product = this.allProducts;
    if (this.filter.brandId)
      product = product.filter(p => p.brand.id == this.filter.brandId)
  }

}
