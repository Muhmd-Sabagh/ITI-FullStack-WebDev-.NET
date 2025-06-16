import { Component } from '@angular/core';
// Import all components that will be conditionally displayed
import { Navbar } from './components/navbar/navbar';
import { Home } from './components/home/home';
import { Movies } from './components/movies/movies';
import { CapitalizeInput } from './components/capitalize-input/capitalize-input';
import { CommonModule } from '@angular/common'; // Import CommonModule for *ngIf

@Component({
  selector: 'app-root',
  standalone: true,
  // Add all components to imports since they might be rendered
  imports: [Navbar, Home, Movies, CapitalizeInput, CommonModule],
  templateUrl: './app.html',
  styleUrl: './app.css',
})
export class App {
  title = 'angular-merged-app';
  // State variable to control which component is displayed
  selectedView: string = 'home'; // Default to 'home' view

  /**
   * Handles the navigation event emitted by the NavbarComponent.
   * Updates the selectedView to display the appropriate component.
   * @param view The name of the view to switch to (e.g., 'home', 'movies', 'capitalize').
   */
  onNavigate(view: string): void {
    this.selectedView = view;
  }
}
