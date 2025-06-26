import { Routes } from '@angular/router';
import { Home } from './pages/home/home';
import { ProductsCards } from './pages/products-cards/products-cards';
import { ProductsManage } from './pages/products-manage/products-manage';
import { ProductForm } from './pages/product-form/product-form';
import { ProductDetails } from './pages/product-details/product-details';
import { NotFound } from './pages/not-found/not-found';

export const routes: Routes = [
  { path: '', redirectTo: 'home', pathMatch: 'full' },
  { path: 'home', component: Home },
  { path: 'products', component: ProductsCards },
  { path: 'products-manage', component: ProductsManage },
  { path: 'product/add', component: ProductForm },
  { path: 'product/edit/:id', component: ProductForm },
  { path: 'product-details/:id', component: ProductDetails },
  { path: 'not-found', component: NotFound },
  { path: '**', redirectTo: 'not-found' },
];
