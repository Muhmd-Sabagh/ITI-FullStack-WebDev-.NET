import { Component, Output, EventEmitter, Input } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-add-movie',
  imports: [FormsModule, CommonModule],
  templateUrl: './add-movie.html',
  styleUrls: ['./add-movie.css'],
})
export class AddMovie {
  @Output() movieAdded = new EventEmitter<any>();

  @Input() categories: string[] = [
    'Action',
    'Animation',
    'Drama',
    'Comedy',
    'Horror',
    'Sci-Fi',
  ];

  movie = {
    name: '',
    author: '',
    description: '',
    rating: '',
    category: '',
    image: '',
  };

  submitMovie() {
    if (
      this.movie.name &&
      this.movie.author &&
      this.movie.description &&
      this.movie.rating &&
      this.movie.category &&
      this.movie.image
    ) {
      this.movieAdded.emit(this.movie);
      this.movie = {
        name: '',
        author: '',
        description: '',
        rating: '',
        category: '',
        image: '',
      };
    } else {
      console.error('Please fill in all movie fields.');
    }
  }
}
