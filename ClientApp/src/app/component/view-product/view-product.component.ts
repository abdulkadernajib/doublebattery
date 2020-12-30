import { Product } from './../../model/product';
import { ProgressService } from './../../services/progress.service';
import { PhotosService } from './../../services/photos.service';
import { ProductsService } from './../../services/products.service';
import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-view-product',
  templateUrl: './view-product.component.html',
  styleUrls: ['./view-product.component.css']
})
export class ViewProductComponent implements OnInit {
  product: any;
  productId: number;
  @ViewChild('fileInput') fileInput: ElementRef;
  progress: any;
  photos: any[];
  photosTab: boolean = false;
  attributeTab: boolean = true;

  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private productService: ProductsService,
    private photoService: PhotosService,
    private progressService: ProgressService
  ) {
    route.params.subscribe(p => {
      this.productId = p['id'];
      if (isNaN(this.productId) || this.productId <= 0) {
        router.navigate(['/products'])
        return;
      }
    });
  }

  ngOnInit() {
    // this.route.fragment.subscribe(f => {
    //   var element = document.querySelector("#" + f)
    //   if (element) element.toggleAttribute
    // });
    this.productService.getProduct(this.productId).subscribe(p => this.product = p)
    this.photoService.getPhotos(this.productId).subscribe((p: any[]) => this.photos = p)
    console.log('attribute:', this.attributeTab, 'photo:', this.photosTab);

  }

  uploadPhoto() {
    var nativeElement: HTMLInputElement = this.fileInput.nativeElement;

    this.progressService.uploadProgress.subscribe(progress => console.log(progress));

    this.photoService.upload(this.productId, nativeElement.files[0])
      .subscribe(x => this.photos.push(x));
  }
  onClickAttributeTab() {
    this.attributeTab = true;
    this.photosTab = false;
    console.log('attribute:', this.attributeTab, 'photo:', this.photosTab);

  }
  onClickPhotoTab() {
    this.photosTab = true;
    this.attributeTab = false;
    console.log('attribute:', this.attributeTab, 'photo:', this.photosTab);

  }

}
