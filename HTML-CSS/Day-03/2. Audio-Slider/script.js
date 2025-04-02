// // Audio tracks array
// const tracks = [
//   {
//     title: "Track 1",
//     artist: "Artist 1",
//     src: "tracks/track1.mp3",
//   },
//   {
//     title: "Track 2",
//     artist: "Artist 2",
//     src: "tracks/track2.mp3",
//   },
//   {
//     title: "Track 3",
//     artist: "Artist 3",
//     src: "tracks/track3.mp3",
//   },
//   {
//     title: "Track 4",
//     artist: "Artist 4",
//     src: "tracks/track4.mp3",
//   },
// ];

// // DOM elements
// const audioPlayer = document.getElementById("audio-player");
// const trackTitle = document.getElementById("track-title");
// const trackArtist = document.getElementById("track-artist");
// const playBtn = document.getElementById("play-btn");
// const pauseBtn = document.getElementById("pause-btn");
// const stopBtn = document.getElementById("stop-btn");
// const prevBtn = document.getElementById("prev-btn");
// const nextBtn = document.getElementById("next-btn");
// const muteBtn = document.getElementById("mute-btn");
// const progressBar = document.getElementById("progress-bar");
// const currentTimeDisplay = document.getElementById("current-time");
// const durationDisplay = document.getElementById("duration");
// const trackList = document.getElementById("track-list");

// // Variables
// let currentTrackIndex = 0;
// let isPlaying = false;
// let isMuted = false;
// let updateProgress;

// // Initialize the player
// function initPlayer() {
//   // Create playlist
//   tracks.forEach((track, index) => {
//     const li = document.createElement("li");
//     li.textContent = `${track.title} - ${track.artist}`;
//     li.addEventListener("click", () => loadTrack(index));
//     trackList.appendChild(li);
//   });

//   // Load the first track
//   loadTrack(currentTrackIndex);
// }

// // Load a track
// function loadTrack(index) {
//   currentTrackIndex = index;
//   const track = tracks[index];

//   audioPlayer.src = track.src;
//   trackTitle.textContent = track.title;
//   trackArtist.textContent = track.artist;

//   // Update active track in playlist
//   const playlistItems = trackList.querySelectorAll("li");
//   playlistItems.forEach((item) => item.classList.remove("playing"));
//   playlistItems[index].classList.add("playing");

//   // If player was playing, continue playing
//   if (isPlaying) {
//     audioPlayer.play();
//   }
// }

// // Play the current track
// function playTrack() {
//   audioPlayer.play();
//   isPlaying = true;
//   playBtn.style.display = "none";
//   pauseBtn.style.display = "block";

//   // Start updating progress bar
//   updateProgress = setInterval(updateProgressBar, 1000);
// }

// // Pause the current track
// function pauseTrack() {
//   audioPlayer.pause();
//   isPlaying = false;
//   playBtn.style.display = "block";
//   pauseBtn.style.display = "none";

//   // Stop updating progress bar
//   clearInterval(updateProgress);
// }

// // Stop the current track
// function stopTrack() {
//   audioPlayer.pause();
//   audioPlayer.currentTime = 0;
//   isPlaying = false;
//   playBtn.style.display = "block";
//   pauseBtn.style.display = "none";

//   // Stop updating progress bar
//   clearInterval(updateProgress);
//   updateProgressBar(); // Update one last time
// }

// // Play next track
// function nextTrack() {
//   currentTrackIndex = (currentTrackIndex + 1) % tracks.length;
//   loadTrack(currentTrackIndex);
//   if (isPlaying) {
//     playTrack();
//   }
// }

// // Play previous track
// function prevTrack() {
//   currentTrackIndex = (currentTrackIndex - 1 + tracks.length) % tracks.length;
//   loadTrack(currentTrackIndex);
//   if (isPlaying) {
//     playTrack();
//   }
// }

// // Toggle mute
// function toggleMute() {
//   isMuted = !isMuted;
//   audioPlayer.muted = isMuted;
//   muteBtn.innerHTML = isMuted
//     ? '<i class="fas fa-volume-mute"></i>'
//     : '<i class="fas fa-volume-up"></i>';
// }

// // Update progress bar
// function updateProgressBar() {
//   const progress = (audioPlayer.currentTime / audioPlayer.duration) * 100;
//   progressBar.style.setProperty("--progress", `${progress}%`);

//   // Update time displays
//   currentTimeDisplay.textContent = formatTime(audioPlayer.currentTime);
//   if (audioPlayer.duration) {
//     durationDisplay.textContent = formatTime(audioPlayer.duration);
//   }
// }

// // Format time (seconds to MM:SS)
// function formatTime(seconds) {
//   const minutes = Math.floor(seconds / 60);
//   const secs = Math.floor(seconds % 60);
//   return `${minutes}:${secs < 10 ? "0" : ""}${secs}`;
// }

// // Seek functionality
// progressBar.addEventListener("click", (e) => {
//   const percent = e.offsetX / progressBar.offsetWidth;
//   audioPlayer.currentTime = percent * audioPlayer.duration;
//   updateProgressBar();
// });

// // Event listeners
// playBtn.addEventListener("click", playTrack);
// pauseBtn.addEventListener("click", pauseTrack);
// stopBtn.addEventListener("click", stopTrack);
// prevBtn.addEventListener("click", prevTrack);
// nextBtn.addEventListener("click", nextTrack);
// muteBtn.addEventListener("click", toggleMute);

// // When track ends, play next one
// audioPlayer.addEventListener("ended", nextTrack);

// // When metadata is loaded, update duration
// audioPlayer.addEventListener("loadedmetadata", () => {
//   durationDisplay.textContent = formatTime(audioPlayer.duration);
// });

// // Initialize the player when DOM is loaded
// document.addEventListener("DOMContentLoaded", initPlayer);

// Audio tracks array
var tracks = [
  {
    title: "Track 1",
    src: "tracks/track1.mp3",
  },
  {
    title: "Track 2",
    src: "tracks/track2.mp3",
  },
  {
    title: "Track 3",
    src: "tracks/track3.mp3",
  },
  {
    title: "Track 4",
    src: "tracks/track4.mp3",
  },
];

// DOM Elements
var audio = document.getElementById("audio");
var trackTitle = document.getElementById("track-title");
var prevBtn = document.getElementById("prev-btn");
var playPauseBtn = document.getElementById("play-pause-btn");
var stopBtn = document.getElementById("stop-btn");
var nextBtn = document.getElementById("next-btn");
var muteBtn = document.getElementById("mute-btn");
var playBtn = document.getElementById("play-btn");
var speed = document.getElementById("speed-list");
var volumeBar = document.getElementById("volume-bar");
var timeBar = document.getElementById("time-bar");
var currentTimeDisplayed = document.getElementById("current-time");
var duration = document.getElementById("duration");
var tracksList = document.getElementById("tracks");

var currentTrackIndex = 0;
var isPlaying = false;

// Initialize the audio player
function initPlayer() {
  tracks.forEach(function (track) {
    var li = document.createElement("li");
    li.innerHTML = track.title;
    tracksList.appendChild(li);
  });
  loadTrack();
}

// Load the current track and highlight it in the playlist
function loadTrack() {
  var track = tracks[currentTrackIndex];
  audio.src = track.src;
  trackTitle.innerHTML = track.title;

  tracksList
    .querySelectorAll("li")
    .forEach((item) => item.classList.remove("active"));

  tracksList
    .getElementsByTagName("li")
    [currentTrackIndex].classList.add("active");

  audio.addEventListener("loadedmetadata", function () {
    duration.innerHTML = formatTime(audio.duration);
    timeBar.value = 0;
    timeBar.max = audio.duration;
  });

  if (isPlaying) {
    audio.play();
  }
}

// Control Buttons Functions
function playTrack() {
  audio.play();
  isPlaying = true;
  playPauseBtn.innerHTML = "pause";
}

function pauseTrack() {
  audio.pause();
  isPlaying = false;
  playPauseBtn.innerHTML = "play";
}

function stopTrack() {
  audio.load();
  audio.pause();
  isPlaying = false;
  playPauseBtn.innerHTML = "play";
}

function prevTrack() {
  currentTrackIndex--;
  if (currentTrackIndex < 0) currentTrackIndex = tracks.length - 1;
  loadTrack();
}

function nextTrack() {
  currentTrackIndex++;
  if (currentTrackIndex == tracks.length) currentTrackIndex = 0;
  loadTrack();
}

function toggleMute() {
  audio.muted = !audio.muted;
  if (audio.muted) {
    volumeBar.value = 0;
    muteBtn.style =
      "background-color: rgb(118,118,118); text-decoration: line-through;";
  } else {
    volumeBar.value = audio.volume;
    muteBtn.style = "background-color: #5c48ca; text-decoration: none;";
  }
}

// Time format helper function
function formatTime(seconds) {
  var minutes = Math.floor(seconds / 60);
  var secs = Math.floor(seconds % 60);
  return `${minutes < 10 ? "0" : ""}${minutes} : ${
    secs < 10 ? "0" : ""
  }${secs}`;
}

// Buttons Events Listeners
playPauseBtn.addEventListener("click", function () {
  if (isPlaying) pauseTrack();
  else playTrack();
});
stopBtn.addEventListener("click", stopTrack);
prevBtn.addEventListener("click", prevTrack);
nextBtn.addEventListener("click", nextTrack);
muteBtn.addEventListener("click", toggleMute);
volumeBar.addEventListener("input", function () {
  audio.volume = volumeBar.value;
  audio.volume == 0
    ? (muteBtn.style =
        "background-color: rgb(118,118,118); text-decoration: line-through;")
    : (muteBtn.style = "background-color: #5c48ca; text-decoration: none;");
});
audio.addEventListener("timeupdate", function () {
  timeBar.value = audio.currentTime;
  currentTimeDisplayed.innerHTML = formatTime(audio.currentTime);
  if (audio.currentTime == audio.duration) {
    nextTrack();
  }
});
timeBar.addEventListener("input", function () {
  audio.currentTime = timeBar.value;
});
speed.addEventListener("change", function () {
  audio.playbackRate = speed.value;
});
// Initialize the Audio Player when DOM is loaded
document.addEventListener("DOMContentLoaded", initPlayer);
