import { Product } from './../../model/product';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { forkJoin } from 'rxjs';
import { BrandService } from './../../services/brand.service';
import { ProductsService } from './../../services/products.service';

@Component({
  selector: 'app-product-form',
  templateUrl: './product-form.component.html',
  styleUrls: ['./product-form.component.css']
})
export class ProductFormComponent implements OnInit {
  product: any = {
    brandId: 0,
    modelId: 0,
    frameColorId: 0,
    templeColorId: 0,
    lensColorId: 0,
    frameMaterialId: 0,
    templeMaterialId: 0,
    lensMaterialId: 0,
    categoriesId: 0,
    styleId: 0,
    frameTypeId: 0,
    idealForId: 0,
    sku: '',
    colorChildId: '',
    sizeChildId: '',
    brandColorName: '',
    brandSizeName: '',
    sizeId: 0,
  };
  brands: any[];
  models: any[];
  colors: any[];
  frameMaterials: any[];
  lensColors: any[];
  lensMaterials: any[];
  frameTypes: any[];
  styles: any[];
  categories: any[];
  idealFor: any[];
  sizes: any[];
  brandColorSelectName: any[];
  br: string;
  md: string;
  colorChild: any;
  createdOn: string;
  lastUpdate: string;


  constructor(private brandService: BrandService, private productService: ProductsService,
    private route: ActivatedRoute, private router: Router) {
    route.params.subscribe(p => {
      this.product.id = p['id'];
    })
  }

  ngOnInit() {


    var sources = [
      this.brandService.getBrands(),
      this.productService.getColors(),
      this.productService.getFrameMaterials(),
      this.productService.getLensColors(),
      this.productService.getLensMaterials(),
      this.productService.getCategories(),
      this.productService.getIdealFor(),
      this.productService.getStyles(),
      this.productService.getFrameTypes(),
      this.productService.getSizes(),
    ]

    if (this.product.id)
      sources.push(this.productService.getProduct(this.product.id))

    forkJoin(sources).subscribe((data: any) => {
      this.brands = data[0];
      this.colors = data[1];
      this.frameMaterials = data[2];
      this.lensColors = data[3];
      this.lensMaterials = data[4];
      this.categories = data[5];
      this.idealFor = data[6];
      this.styles = data[7];
      this.frameTypes = data[8];
      this.sizes = data[9];

      if (this.product.id) {
        this.setProduct(data[10]);
        // this.product = data[10];
        this.populateModels();
      }
    }
      , err => {
        if (err.status == 404)
          this.router.navigate(['/home']);
      });
  }
  onBrandChange() {
    this.populateModels()
    delete this.product.modelId

  }

  setProduct(v) {
    this.product.id = v.id
    this.product.brandId = v.brand.id;
    this.product.modelId = v.model.id;
    this.product.frameColorId = v.frameColor.id;
    this.product.frameMaterialId = v.frameMaterial.id;
    this.product.templeColorId = v.templeColor.id;
    this.product.templeMaterialId = v.frameMaterial.id;
    this.product.lensColorId = v.lensColor.id;
    this.product.lensMaterialId = v.lensMaterial.id;
    this.product.categoryId = v.category.id;
    this.product.idealForId = v.idealFor.id;
    this.product.styleId = v.style.id;
    this.product.frameTypeId = v.frameType.id;
    this.product.sizeId = v.size.id;
    this.product.sku = v.sku;
    this.product.brandColorName = v.brandColorName;
    this.product.brandSizeName = v.brandSizeName;
    this.product.lensWidth = v.lensWidth;
    this.product.lensHeight = v.lensHeight;
    this.product.bridgeSize = v.bridgeSize;
    this.product.templeLength = v.templeLength;
    this.product.colorChildId = v.colorChildId;
    this.product.sizeChildId = v.sizeChildId;
    this.createdOn = v.createdOn;
    this.lastUpdate = v.lastUpdate;
  }

  // private getBrand() {
  //   return this.brands.find(m => m.id == this.product.brandId);

  // }
  private populateModels() {
    var selectedBrands = this.brands.find(m => m.id == this.product.brandId);
    this.br = selectedBrands ? selectedBrands.brandId : "";
    this.models = selectedBrands ? selectedBrands.models : [];
  }

  delete() {
    if (confirm("Are you sure you want to delete this product?"))
      this.productService.deleteProduct(this.product.id).subscribe(p => {
        this.router.navigate(['/home']);
      })
  }

  onModelChange() {
    var selectedModel = this.models.find(m => m.id == this.product.modelId);
    // var selectedBrandColor = this.product.find(col => col.id == this.product.id);
    // this.brandColorSelectName = selectedModel.id
    var a = selectedModel.id
    console.log(a)
    this.md = selectedModel.modelId;
    // this.product.sku = this.br + this.md + this.colorChild;
  }



  submit() {
    this.productService.create(this.product).subscribe(
      x => console.log(x)
      // err => {
      //   this.toasty.error({
      //     title: 'Error',
      //     msg: 'An unexpected Error Occured',
      //     theme: 'bootstrap',
      //     showClose: true,
      //     timeout: 5000
      //   })
    );
  }

  onColorChildChange(colorChild) {
    this.colorChild = colorChild

  }

  onSizeChildChange(sizeChild) {
    this.product.sku = this.br + this.md + this.colorChild + sizeChild;
  }

  update() {
    this.productService.updateProduct(this.product.id, this.product).subscribe(p => {
      this.router.navigate(['/home'])
    });
  }


}
