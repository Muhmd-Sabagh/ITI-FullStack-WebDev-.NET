var preloader = document.getElementsByClassName("preloader")[0];
var heroH1 = document.querySelector(".hero-content h1");
var heroP = document.querySelector(".hero-content p");
var heroA = document.querySelector(".hero-content a");

window.onload = function () {
  setTimeout(function () {
    preloader.style.transition = "opacity .3s ease";
    preloader.style.opacity = "0";
    setTimeout(function () {
      preloader.style.display = "none";
    }, 1000);
  }, 400);
  heroH1.style.animation = "fadeInLeft 1s 0.1s ease forwards";
  heroP.style.animation = "fadeInLeft 1s 0.3s ease forwards";
  heroA.style.animation = "fadeInLeft 1s 0.5s ease forwards";
};

var header = document.getElementsByTagName("header")[0];
var offers = document.getElementsByClassName("offer");
var services = document.getElementsByClassName("service");
var backTopBtn = document.querySelector(".back-top a");
console.log(backTopBtn);

window.onscroll = function () {
  if (scrollY > 2200) {
    services[0].style.animation = "fadeInUp 1s forwards";
    services[1].style.animation = "fadeInUp 1s .2s forwards";
    services[2].style.animation = "fadeInUp 1s .4s forwards";
    services[3].style.animation = "fadeInUp 1s .6s forwards";
  } else if (scrollY > 420) {
    header.classList.add("fixed-bar");
    offers[0].style.animation = "fadeInUp 1s forwards";
    offers[1].style.animation = "fadeInUp 1s .2s forwards";
    offers[2].style.animation = "fadeInUp 1s .4s forwards";
    // backTopBtn.style.opacity = "1";
    backTopBtn.style = "opacity: 1; transform: translateY(0);";
    console.log(backTopBtn);
  } else {
    backTopBtn.style = "opacity: 0; transform: translateY(30px);";
    // backTopBtn.style.opacity = "0";
    header.classList.remove("fixed-bar");
  }
};
