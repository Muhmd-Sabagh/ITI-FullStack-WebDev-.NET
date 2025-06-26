import { Component, Input, OnInit } from '@angular/core';
import { RouterLink } from '@angular/router';
import { Product } from '../../models/product';
import { StaticProductService } from '../../services/static-products-service';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-products-manage',
  imports: [RouterLink, FormsModule],
  templateUrl: './products-manage.html',
  styleUrl: './products-manage.css',
})
export class ProductsManage implements OnInit {
  products!: Product[];
  maxPrice: number = 0;
  constructor(private productService: StaticProductService) {}

  ngOnInit(): void {
    this.products = this.productService.getProducts();
  }

  deleteProduct(id: string) {
    this.productService.removeProduct(id);
    this.products = this.products.filter((p) => p.id !== id);
  }

  applyFilter() {
    this.products = this.productService
      .getProducts()
      .filter((p) => p.price <= this.maxPrice);
  }
}
