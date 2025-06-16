import { Component } from '@angular/core';
import { Content } from './components/content/content';
import { Footer } from './components/footer/footer';

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [Content, Footer],
  templateUrl: './home.html',
  styleUrls: ['./home.css'],
})
export class Home {}
