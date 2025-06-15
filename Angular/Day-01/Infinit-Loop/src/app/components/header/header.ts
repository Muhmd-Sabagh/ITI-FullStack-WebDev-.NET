import { Component, HostListener } from '@angular/core';

@Component({
  selector: 'app-header',
  templateUrl: './header.html',
  styleUrl: './header.css',
})
export class Header {
  scrolled = false;

  @HostListener('window:scroll', [])
  onWindowScroll() {
    // Trigger when scrollY is more than 50px
    this.scrolled = window.pageYOffset > 50;
  }
}
