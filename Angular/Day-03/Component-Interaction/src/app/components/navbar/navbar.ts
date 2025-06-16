import { Component, EventEmitter, Output, Input } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Scaler } from '../../custom-directives/scaler';

@Component({
  selector: 'app-navbar',
  imports: [CommonModule, Scaler],
  templateUrl: './navbar.html',
  styleUrls: ['./navbar.css'],
})
export class Navbar {
  @Output() navigate = new EventEmitter<string>();

  onNavigate(view: string): void {
    this.navigate.emit(view);
  }
}
