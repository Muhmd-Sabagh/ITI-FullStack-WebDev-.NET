import { Component, OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { ActivatedRoute, RouterLink } from '@angular/router';
import { StaticProductService } from '../../services/static-products-service';
import { Product } from '../../models/product';
import { Router } from '@angular/router';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-product-form',
  imports: [FormsModule, RouterLink, CommonModule],
  templateUrl: './product-form.html',
  styleUrl: './product-form.css',
})
export class ProductForm implements OnInit {
  product: Product = new Product('', '', 0, 0);
  imgSrc = '';
  isEditMode = false;

  constructor(
    private productService: StaticProductService,
    private route: ActivatedRoute,
    private router: Router
  ) {}

  ngOnInit(): void {
    const id = this.route.snapshot.params['id'];
    if (id) {
      this.isEditMode = true;
      const existing = this.productService.getProduct(id);
      if (existing) {
        this.product = existing;
      } else {
        this.router.navigate(['not-found']);
        return;
      }
    }
  }

  onSubmit() {
    if (this.isEditMode) {
      this.product.imgSrc =
        this.imgSrc == '' ? this.product.imgSrc : this.imgSrc;
      this.productService.updateProduct(this.product);
      this.router.navigate(['products']);
    } else {
      this.product.imgSrc =
        this.imgSrc == '' ? this.product.imgSrc : this.imgSrc;
      this.productService.addProduct(this.product);
      this.router.navigate(['products']);
    }
  }
}
