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
  products: any[];
  brands: KeyValuePair[];
  query: any = {};
  column = [
    { title: 'SKU', key: 'sku', isSortable: true },
    { title: 'Brand', key: 'brand', isSortable: true },
    { title: 'Model', key: 'model', isSortable: true },
    { title: 'Brand Color', key: 'brandColor', isSortable: true },
    { title: 'Brand Size', key: 'brandSize', isSortable: true },
  ];
  // allProducts: Product[]

  constructor(private productService: ProductsService, private brandService: BrandService) { }

  ngOnInit(): void {
    this.brandService.getBrands().subscribe((b: KeyValuePair[]) => this.brands = b)
    this.populateProducts()
  }

  populateProducts() {
    this.productService.getProducts(this.query).subscribe((p: any[]) => this.products = p);
  }

  onFilterChange() {
    this.populateProducts()
    console.log(this.query)

    //   var product = this.allProducts;
    //   if (this.filter.brandId)
    //     product = product.filter(p => p.brand.id == this.filter.brandId)
  }

  sortBy(colomnName) {
    if (this.query.sortBy === colomnName) {
      this.query.isSortAscending = !this.query.isSortAscending;
    } else {
      this.query.sortBy = colomnName;
      this.query.isSortAscending = true;
    }

    console.log(colomnName)
    this.populateProducts();

  }

}
