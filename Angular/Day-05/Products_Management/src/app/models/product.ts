import { IProduct } from './iproduct';

export class Product implements IProduct {
  constructor(
    public id: string,
    public name: string,
    public price: number,
    public quantity: number,
    public imgSrc: string = 'https://upload.wikimedia.org/wikipedia/commons/d/d1/Image_not_available.png'
  ) {}
}
