import { ProductsService } from './../../services/products.service';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-view-product',
  templateUrl: './view-product.component.html',
  styleUrls: ['./view-product.component.css']
})
export class ViewProductComponent implements OnInit {
  product: any;
  productId: number;

  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private productService: ProductsService
  ) {
    route.params.subscribe(p => {
      this.productId = p['id'];
      if (isNaN(this.productId) || this.productId <= 0) {
        router.navigate(['/products'])
        return;
      }
    });
  }

  ngOnInit(): void {
  }

}
