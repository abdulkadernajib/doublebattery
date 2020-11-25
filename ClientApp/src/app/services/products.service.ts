import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class ProductsService {

  constructor(private httpClient: HttpClient, private http: HttpClientModule) { }

  create(product) {
    return this.httpClient.post("/api/products", product, { responseType: 'json' });
  }

  getProduct(id) {
    return this.httpClient.get('/api/products/' + id);
  }

  deleteProduct(id) {
    return this.httpClient.delete('/api/products/' + id);
  }


  getSizes() {
    return this.httpClient.get("/api/sizes");
  }

  getFrameMaterials() {
    return this.httpClient.get("/api/framematerials");
  }

  getColors() {
    return this.httpClient.get("/api/colors");
  }

  getLensColors() {
    return this.httpClient.get("/api/lensColors");
  }

  getLensMaterials() {
    return this.httpClient.get("/api/lensMaterials");
  }

  getIdealFor() {
    return this.httpClient.get("/api/idealFor");
  }

  getCategories() {
    return this.httpClient.get("/api/categories");
  }

  getStyles() {
    return this.httpClient.get("/api/styles");
  }

  getFrameTypes() {
    return this.httpClient.get("/api/frameTypes");
  }

  getColorChildIds() {
    return this.httpClient.get("/api/colorChildId");
  }

  getSizeChildIds() {
    return this.httpClient.get("/api/sizeChildId");
  }

}
