import { Component } from '@angular/core';
import { AddMovie } from './components/add-movie/add-movie';
import { MoviesList } from './components/movies-list/movies-list';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-movies',
  imports: [AddMovie, MoviesList, FormsModule],
  templateUrl: './movies.html',
  styleUrls: ['./movies.css'],
})
export class Movies {
  movies: {
    id: number;
    name: string;
    author: string;
    description: string;
    rating: string;
    category: string;
    image: string;
  }[] = [
    {
      id: 1,
      name: 'Inception',
      author: 'Christopher Nolan',
      description:
        "A thief who steals corporate secrets through dream-sharing technology is given the task of planting an idea into a CEO's mind.",
      rating: '9',
      category: 'Sci-Fi',
      image: 'https://m.media-amazon.com/images/I/81p+xe8cbnL._AC_SY679_.jpg',
    },
    {
      id: 2,
      name: 'The Lion King',
      author: 'Roger Allers',
      description:
        'Lion prince Simba flees his kingdom after the murder of his father and returns to reclaim his place.',
      rating: '8',
      category: 'Animation',
      image: 'https://image.tmdb.org/t/p/w500/2CAL2433ZeIihfX1Hb2139CX0pW.jpg',
    },
    {
      id: 3,
      name: 'Gladiator',
      author: 'Ridley Scott',
      description:
        'A former Roman General sets out to exact vengeance against the corrupt emperor.',
      rating: '8.5',
      category: 'Action',
      image: 'https://image.tmdb.org/t/p/w500/ty8TGRuvJLPUmAR1H1nRIsgwvim.jpg',
    },
    {
      id: 4,
      name: 'Titanic',
      author: 'James Cameron',
      description:
        'A seventeen-year-old aristocrat falls in love with a kind but poor artist aboard the ill-fated R.M.S. Titanic.',
      rating: '9',
      category: 'Drama',
      image: 'https://image.tmdb.org/t/p/w500/9xjZS2rlVxm8SFx8kPC3aIGCOYQ.jpg',
    },
    {
      id: 5,
      name: 'The Conjuring',
      author: 'James Wan',
      description:
        'Paranormal investigators work to help a family terrorized by a dark presence in their farmhouse.',
      rating: '7',
      category: 'Horror',
      image: 'https://image.tmdb.org/t/p/w500/wVYREutTvI2tmxr6ujrHT704wGF.jpg',
    },
    {
      id: 6,
      name: 'The Avengers',
      author: 'Joss Whedon',
      description:
        'Earth’s mightiest heroes must unite to stop a global threat.',
      rating: '8.5',
      category: 'Action',
      image: 'https://image.tmdb.org/t/p/w500/RYMX2wcKCBAr24UyPD7xwmjaTn.jpg',
    },
    {
      id: 7,
      name: 'Inside Out',
      author: 'Pete Docter',
      description:
        'Young Riley is guided by her emotions through life-changing events.',
      rating: '8',
      category: 'Animation',
      image: 'https://image.tmdb.org/t/p/w500/lRHE0vzf3oYJrhbsHXjIkF4Tl5A.jpg',
    },
    {
      id: 8,
      name: 'The Notebook',
      author: 'Nick Cassavetes',
      description:
        'A couple falls in love in the early 1940s, but are soon separated by fate.',
      rating: '7.8',
      category: 'Drama',
      image: 'https://image.tmdb.org/t/p/w500/rNzQyW4f8B8cQeg7Dgj3n6eT5k9.jpg',
    },
    {
      id: 9,
      name: 'Interstellar',
      author: 'Christopher Nolan',
      description:
        'A team of explorers travel through a wormhole in space in an attempt to ensure humanity’s survival.',
      rating: '9',
      category: 'Sci-Fi',
      image: 'https://image.tmdb.org/t/p/w500/gEU2QniE6E77NI6lCU6MxlNBvIx.jpg',
    },
    {
      id: 10,
      name: 'It',
      author: 'Andy Muschietti',
      description:
        'In the town of Derry, a group of kids face their biggest fears when they square off against a murderous clown named Pennywise.',
      rating: '7',
      category: 'Horror',
      image: 'https://image.tmdb.org/t/p/w500/9E2y5Q7WlCVNEhP5GiVTjhEhx1o.jpg',
    },
    {
      id: 11,
      name: 'Deadpool',
      author: 'Tim Miller',
      description:
        'A former special forces operative turned mercenary is subjected to a rogue experiment.',
      rating: '8',
      category: 'Comedy',
      image:
        'https://www.techadvisor.com/wp-content/uploads/2023/09/Deadpool.jpg?quality=50&strip=all',
    },
    {
      id: 12,
      name: 'Disaster Movie',
      author: 'Jason Friedberg',
      description: 'Over-the-top parodies of disaster and adventure films.',
      rating: '1.9',
      category: 'Comedy',
      image:
        'https://static.filmin.es/img/resources/web/film/poster/poster-resized/disaster-movie.jpg',
    },
    {
      id: 13,
      name: 'Coco',
      author: 'Lee Unkrich',
      description:
        'Young Miguel dreams of becoming a musician and enters the Land of the Dead to find his great-great-grandfather.',
      rating: '8.5',
      category: 'Animation',
      image: 'https://image.tmdb.org/t/p/w500/gGEsBPAijhVUFoiNpgZXqRVWJt2.jpg',
    },
    {
      id: 14,
      name: 'The Dark Knight',
      author: 'Christopher Nolan',
      description:
        'Batman battles the Joker, a criminal mastermind who wants to plunge Gotham into anarchy.',
      rating: '9',
      category: 'Action',
      image: 'https://image.tmdb.org/t/p/w500/qJ2tW6WMUDux911r6m7haRef0WH.jpg',
    },
    {
      id: 15,
      name: 'Forrest Gump',
      author: 'Robert Zemeckis',
      description:
        'The life journey of Forrest Gump, a man with a low IQ but good intentions.',
      rating: '9',
      category: 'Drama',
      image: 'https://image.tmdb.org/t/p/w500/saHP97rTPS5eLmrLQEcANmKrsFl.jpg',
    },
    {
      id: 16,
      name: 'Get Out',
      author: 'Jordan Peele',
      description:
        'A young Black man uncovers disturbing secrets when he meets his white girlfriend’s family.',
      rating: '8',
      category: 'Horror',
      image: 'https://image.tmdb.org/t/p/w500/tFXcEccSQMf3lfhfXKSU9iRBpa3.jpg',
    },
    {
      id: 17,
      name: 'Back to the Future',
      author: 'Robert Zemeckis',
      description:
        'Marty McFly travels back in time and risks erasing his own existence.',
      rating: '8.5',
      category: 'Sci-Fi',
      image: 'https://image.tmdb.org/t/p/w500/fNOH9f1aA7XRTzl1sAOx9iF553Q.jpg',
    },
    {
      id: 18,
      name: 'Cats',
      author: 'Tom Hooper',
      description:
        'A tribe of cats must decide yearly which one will ascend to the Heaviside Layer.',
      rating: '2.8',
      category: 'Comedy',
      image:
        'https://image.tmdb.org/t/p/original/2wWHK7QRASgtvnIk9zYh5KVVLaZ.jpg',
    },
    {
      id: 19,
      name: 'Zootopia',
      author: 'Byron Howard',
      description:
        'A bunny cop and a fox con artist uncover a conspiracy in the animal city of Zootopia.',
      rating: '8',
      category: 'Animation',
      image:
        'https://th.bing.com/th/id/R.9d9262b1e48893a8d05f15ff5d583602?rik=2YgSz6EMgolisw&riu=http%3a%2f%2fwww.shmee.me%2fwp-content%2fuploads%2f2016%2f08%2fzootopia.jpg&ehk=yZJ8TtlP61jcwJ7M2wj5SO%2bNvj8Ell%2bkZdxm%2fQ95Tns%3d&risl=&pid=ImgRaw&r=0',
    },
    {
      id: 20,
      name: 'The Hangover',
      author: 'Todd Phillips',
      description:
        'Three friends wake up from a bachelor party with no memory and a missing groom.',
      rating: '7.5',
      category: 'Comedy',
      image:
        'https://th.bing.com/th/id/R.266b2e66b9dfc4292d02d1287de0f6c9?rik=TIc3lNQJQdUoig&riu=http%3a%2f%2fimages2.fanpop.com%2fimages%2fphotos%2f6800000%2fThe-Hangover-the-hangover-6886695-1280-960.jpg&ehk=BQWuhpAHvMK917n5tSRbUs851FMXBBNYtmv3K%2fZV00s%3d&risl=&pid=ImgRaw&r=0',
    },
    {
      id: 21,
      name: 'Avengers: Endgame',
      author: 'Anthony Russo',
      description:
        'After Thanos wiped out half the universe, the Avengers must undo the damage.',
      rating: '9',
      category: 'Action',
      image: 'https://image.tmdb.org/t/p/w500/ulzhLuWrPK07P1YkdWQLZnQh1JL.jpg',
    },
    {
      id: 22,
      name: 'Parasite',
      author: 'Bong Joon Ho',
      description:
        'A poor family schemes to become employed by a wealthy family by infiltrating their household.',
      rating: '8.6',
      category: 'Drama',
      image: 'https://image.tmdb.org/t/p/w500/7IiTTgloJzvGI1TAYymCfbfl3vT.jpg',
    },
    {
      id: 23,
      name: 'The Room',
      author: 'Tommy Wiseau',
      description:
        'A banker’s life falls apart after his fiancée betrays him with his best friend.',
      rating: '3.7',
      category: 'Drama',
      image:
        'https://th.bing.com/th/id/R.582c95b5497ec606a554e31c0ac44025?rik=c5E1kG8GGDXqKw&pid=ImgRaw&r=0',
    },
  ];

  categories: string[] = [
    'Action',
    'Animation',
    'Drama',
    'Comedy',
    'Horror',
    'Sci-Fi',
  ];

  searchTerm: string = '';
  selectedCategory: string = '';

  // Function to Add a Movie
  addMovie(newMovie: any) {
    this.movies.push({ ...newMovie, id: this.getNextId() });
  }

  // Function to Remove a Movie
  removeMovie(id: number) {
    this.movies = this.movies.filter((movie) => movie.id !== id);
  }

  // Function to get the next Movie Id
  getNextId(): number {
    return this.movies.length > 0
      ? Math.max(...this.movies.map((m) => m.id)) + 1
      : 1;
  }

  // Function to Filter Movies
  get filteredMovies() {
    return this.movies.filter(
      (movie) =>
        (!this.selectedCategory || movie.category === this.selectedCategory) &&
        (!this.searchTerm ||
          movie.name.toLowerCase().includes(this.searchTerm.toLowerCase()))
    );
  }
}
