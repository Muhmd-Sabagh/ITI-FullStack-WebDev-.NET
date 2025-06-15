import { Component } from '@angular/core';
import { Header } from './header/header';
import { Content } from './content/content';

@Component({
  selector: 'app-root',
  imports: [Header, Content],
  templateUrl: './app.html',
  styleUrl: './app.css',
})
export class App {
  protected title = 'Movies-Land';
}
