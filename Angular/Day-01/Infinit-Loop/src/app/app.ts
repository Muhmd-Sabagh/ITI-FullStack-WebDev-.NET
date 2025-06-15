import { Component } from '@angular/core';
import { Header } from './components/header/header';
import { Footer } from './components/footer/footer';
import { Content } from './components/content/content';

@Component({
  selector: 'app-root',
  imports: [Header, Footer, Content],
  templateUrl: './app.html',
  styleUrl: './app.css',
})
export class App {
  protected title = 'Infinit-Loop';
}
