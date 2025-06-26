import { Component } from '@angular/core';
import { Navbar } from './components/navbar/navbar';
import { Home } from './components/home/home';
import { Movies } from './components/movies/movies';
import { CapitalizeInput } from './components/capitalize-input/capitalize-input';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-root',
  imports: [Navbar, Home, Movies, CapitalizeInput, CommonModule],
  templateUrl: './app.html',
  styleUrl: './app.css',
})
export class App {
  title = 'angular-merged-app';
  selectedView: string = 'home';

  onNavigate(view: string): void {
    this.selectedView = view;
  }
}
