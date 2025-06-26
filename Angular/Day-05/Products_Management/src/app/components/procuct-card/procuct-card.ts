import { Component, Input } from '@angular/core';
import { Product } from '../../models/product';
import { RouterLink } from '@angular/router';
import { CurrencyPipe } from '@angular/common';

@Component({
  selector: 'app-product-card',
  imports: [RouterLink, CurrencyPipe],
  templateUrl: './procuct-card.html',
  styleUrl: './procuct-card.css',
})
export class ProductCard {
  @Input() product!: Product;
  placeholderImage =
    'https://upload.wikimedia.org/wikipedia/commons/d/d1/Image_not_available.png';
}
