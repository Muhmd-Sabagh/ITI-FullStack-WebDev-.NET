import { Injectable } from '@angular/core';
import { Product } from '../models/product';

@Injectable({
  providedIn: 'root',
})
export class StaticProductService {
  products: Product[] = [];
  constructor() {
    this.products = [
      new Product(
        '1',
        'Laptop',
        1200,
        5,
        'https://img.freepik.com/premium-photo/labtop-computer-laptop-white-background_53876-521399.jpg'
      ),
      new Product(
        '2',
        'Mouse',
        25,
        50,
        'https://www.portronics.com/cdn/shop/files/Image1_5067bdd1-4473-4933-a66d-edcb4d49409a.png?v=1720258592'
      ),
      new Product(
        '3',
        'Monitor',
        200,
        8,
        'https://images.philips.com/is/image/philipsconsumer/3195f5ef01474f9daf38b01500f0846f?wid=700&hei=700&$pnglarge$'
      ),
      new Product(
        '4',
        'Keyboard',
        60,
        10,
        'https://www.bhphotovideo.com/images/fb/jlab_kgokeybrblk4_go_wireless_keyboard_black_1795571.jpg'
      ),
      new Product(
        '5',
        'Headphones',
        80,
        20,
        'https://m.media-amazon.com/images/I/71F2ccIPPLL.jpg'
      ),
    ];
  }

  getProducts() {
    return this.products;
  }

  getProduct(id: string) {
    return this.products.find((p) => p.id === id);
  }

  addProduct(product: Product) {
    const lastProduct = this.products[this.products.length - 1];
    const newId = lastProduct ? (parseInt(lastProduct.id) + 1).toString() : '1';

    const newProduct = new Product(
      newId,
      product.name,
      product.price,
      product.quantity,
      product.imgSrc
    );
    this.products.push(newProduct);
  }

  removeProduct(id: string) {
    this.products = this.products.filter((p) => p.id !== id);
  }

  updateProduct(product: Product) {
    const index = this.products.findIndex((p) => p.id === product.id);
    if (index !== -1) {
      this.products[index] = product;
    }
  }
}
