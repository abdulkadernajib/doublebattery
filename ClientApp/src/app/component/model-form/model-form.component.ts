import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { BrandService } from 'src/app/services/brand.service';

@Component({
  selector: 'app-model-form',
  templateUrl: './model-form.component.html',
  styleUrls: ['./model-form.component.css']
})
export class ModelFormComponent implements OnInit {

  brands: any[];
  models: any[]
  model: any = {};

  constructor(private brandService: BrandService, private router: Router) { }

  ngOnInit() {
    this.brandService.getBrands().subscribe((b: any[]) => this.brands = b)
  }

  submit() {
    this.brandService.createModel(this.model).subscribe(m => console.log(m));
    this.router.navigate(['/products/new'])

  }

}
