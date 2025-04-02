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
