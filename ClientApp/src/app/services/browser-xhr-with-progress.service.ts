// import { XhrFactory } from '@angular/common/http';
// import { Injectable } from '@angular/core';
// import { ProgressService } from './progress.service';

// @Injectable({
//   providedIn: 'root'
// })
// // export class BrowserXhrWithProgressService extends XhrFactory {

//   constructor(private progressService: ProgressService) { super(); }

//   build(): XMLHttpRequest {
//     var xhr: XMLHttpRequest = super.build()

//     xhr.onprogress = (event) => {
//       this.progressService.downloadProgress.next(this.calculateProgress(event));
//     };
//     xhr.upload.onprogress = (event) => {
//       this.progressService.uploadProgress.next(this.calculateProgress(event));
//     };
//     return xhr
//   }

//   private calculateProgress(e) {
//     return {
//       total: e.total,
//       percentage: Math.round(e.loaded / e.total * 100)
//     }
//   }




// }
