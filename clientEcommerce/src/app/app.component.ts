import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { Product } from './models/products';
import { Pzagination } from './models/pagination';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'clientEcommerce';
  products: Product[] = [];

  constructor(private http: HttpClient) {}

  ngOnInit(): void {
    this.http.get<Pzagination<Product[]>>('https://localhost:7164/api/products').subscribe({
      next: (response: any) => this.products = response.data,
      error: error => console.log(error),
      complete: () => {
        console.log('request completed');
        console.log('extra statement');
      }
    })
  }
}
