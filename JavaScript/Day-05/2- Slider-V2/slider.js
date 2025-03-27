// Array of image paths
var images = [
  "images/image1.png",
  "images/image2.jpg",
  "images/image3.jpg",
  "images/image4.webp",
];

var currentIndex = 0;

var sliderImage = document.getElementById("slider-image");

// Show the next image
function nextImage() {
  if (currentIndex == images.length - 1) currentIndex = 0;
  else currentIndex++;
  sliderImage.setAttribute("src", images[currentIndex]);
}

// Show the previous image
function previousImage() {
  if (currentIndex == 0) currentIndex = images.length - 1;
  else currentIndex--;
  sliderImage.setAttribute("src", images[currentIndex]);
}

var myInterval;
// Play the slider when button clicked
function sliderPlay() {
  myInterval = setInterval(nextImage, 2000);
}

// Stop the slider when button clicked
function sliderStop() {
  clearInterval(myInterval);
}
