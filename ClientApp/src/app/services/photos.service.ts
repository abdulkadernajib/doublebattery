import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class PhotosService {

  constructor(private http: HttpClient) { }

  upload(productId, file) {
    var formData = new FormData();
    formData.append('file', file);

    return this.http.post(`/api/products/&{productId/photos}`, formData);
  }

  getPhotos(productId) {
    return this.http.get(`/api/products/&{productId/photos}`)
  }
}
