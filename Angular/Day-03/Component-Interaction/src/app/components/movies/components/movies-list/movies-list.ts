import { Component, Input, Output, EventEmitter } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MovieCard } from '../movie-card/movie-card';

@Component({
  selector: 'app-movies-list',
  imports: [CommonModule, MovieCard],
  templateUrl: './movies-list.html',
  styleUrls: ['./movies-list.css'],
})
export class MoviesList {
  @Input() movies: {
    id: number;
    name: string;
    author: string;
    description: string;
    rating: string;
    category: string;
    image: string;
  }[] = [];
  @Output() movieRemoved = new EventEmitter<number>();

  onRemoveMovie(id: number) {
    this.movieRemoved.emit(id);
  }
}
