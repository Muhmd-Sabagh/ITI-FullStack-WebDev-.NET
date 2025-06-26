import { Component, OnInit } from '@angular/core';
import { RouterLink } from '@angular/router';
import { Product } from '../../models/product';
import { StaticProductService } from '../../services/static-products-service';
import { ProductCard } from '../../components/procuct-card/procuct-card';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-products-cards',
  imports: [FormsModule, RouterLink, ProductCard],
  templateUrl: './products-cards.html',
  styleUrl: './products-cards.css',
})
export class ProductsCards implements OnInit {
  products!: Product[];
  maxPrice: number = 0;
  constructor(private productService: StaticProductService) {}

  ngOnInit(): void {
    this.products = this.productService.getProducts();
  }

  applyFilter() {
    this.products = this.productService
      .getProducts()
      .filter((p) => p.price <= this.maxPrice);
  }
}
