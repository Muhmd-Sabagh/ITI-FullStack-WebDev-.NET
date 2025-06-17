import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-profile',
  imports: [],
  templateUrl: './profile.html',
  styleUrl: './profile.css',
})
export class Profile {
  @Input() user: {
    username: string;
    email: string;
    age: string;
    address: string;
  } | null = null;
}
