import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-capitalize-input',
  imports: [FormsModule],
  templateUrl: './capitalize-input.html',
  styleUrls: ['./capitalize-input.css'],
})
export class CapitalizeInput {
  inputValue: string = '';

  onInputChange(event: Event) {
    this.inputValue = (event.target as HTMLInputElement).value.toUpperCase();
  }
}
