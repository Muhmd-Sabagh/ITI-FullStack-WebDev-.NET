import { Component } from '@angular/core';
import { Registeration } from './components/registeration/registeration';
import { Profile } from './components/profile/profile';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-root',
  imports: [Registeration, Profile, CommonModule],
  templateUrl: './app.html',
  styleUrl: './app.css',
})
export class App {
  protected title = 'Registration-Profile';

  isRegistered = false;

  user!: {
    username: string;
    email: string;
    age: string;
    address: string;
  };

  getUser(user: any) {
    this.isRegistered = true;
    this.user = {
      username: user.username,
      email: user.email,
      age: user.age,
      address: user.address,
    };
  }
}
