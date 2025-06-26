import { Component } from '@angular/core';
import { Navbar } from './layouts/navbar/navbar';
import { Footer } from './layouts/footer/footer';
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, Navbar, Footer],
  templateUrl: './app.html',
  styleUrl: './app.css',
})
export class App {
  protected title = 'Products_Management';
}
