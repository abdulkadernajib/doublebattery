import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class BrandService {

  constructor(private http: HttpClient) { }

  getBrands() {
    return this.http.get('api/brands')
  }

  createModel(model) {
    return this.http.post('api/models', model);
  }
}
