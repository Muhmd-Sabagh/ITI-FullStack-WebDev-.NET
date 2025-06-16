import { Component, Input, Output, EventEmitter } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-movie-card',
  imports: [CommonModule],
  templateUrl: './movie-card.html',
  styleUrls: ['./movie-card.css'],
})
export class MovieCard {
  @Input() movie!: {
    id: number;
    name: string;
    author: string;
    description: string;
    rating: string;
    category: string;
    image: string;
  };
  @Output() removeMovie = new EventEmitter<number>();

  // Rating helper methods
  isTopRated(rating: string): boolean {
    return parseFloat(rating) > 8;
  }

  isUnderRated(rating: string): boolean {
    return parseFloat(rating) < 5;
  }

  // Function to remove a movie
  onRemoveClick() {
    this.removeMovie.emit(this.movie.id);
  }
}
