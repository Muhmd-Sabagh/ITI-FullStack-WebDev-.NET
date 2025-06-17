import { CommonModule } from '@angular/common';
import { Component, EventEmitter, Output } from '@angular/core';
import {
  FormControl,
  FormGroup,
  ReactiveFormsModule,
  Validators,
} from '@angular/forms';

@Component({
  selector: 'app-registeration',
  imports: [ReactiveFormsModule, CommonModule],
  templateUrl: './registeration.html',
  styleUrl: './registeration.css',
})
export class Registeration {
  @Output() onRegister = new EventEmitter();

  userForm = new FormGroup({
    username: new FormControl('', [
      Validators.required,
      Validators.minLength(3),
      Validators.maxLength(50),
      Validators.pattern('[a-zA-Z ]*'),
    ]),
    email: new FormControl('', [
      Validators.required,
      Validators.pattern('^[a-z0-9._%+-]+@[a-z0-9.-]+\\.[a-z]{2,4}$'),
    ]),
    age: new FormControl('', [
      Validators.required,
      Validators.min(18),
      Validators.max(100),
    ]),
    address: new FormControl('', [
      Validators.required,
      Validators.minLength(3),
      Validators.maxLength(100),
      Validators.pattern("^[a-zA-Z0-9\\s.,#\\-()/']{3,100}$"),
    ]),
  });

  get username() {
    return this.userForm.controls['username'];
  }

  get email() {
    return this.userForm.controls['email'];
  }

  get age() {
    return this.userForm.controls['age'];
  }

  get address() {
    return this.userForm.controls['address'];
  }

  onSubmit() {
    this.userForm.markAllAsTouched();
    if (this.userForm.valid) {
      this.onRegister.emit(this.userForm.value);
    }
  }
}
