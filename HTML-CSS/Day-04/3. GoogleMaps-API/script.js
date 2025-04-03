var country = document.getElementById("country");

country.addEventListener("change", function () {
  if (country.value == 0) {
    initMap();
  } else {
    var xhr = new XMLHttpRequest();
    xhr.open(
      "GET",
      `https://nominatim.openstreetmap.org/search?format=json&q=${country.value}`
    );
    xhr.send();

    xhr.onreadystatechange = function () {
      if (xhr.readyState == 4 && xhr.status == 200) {
        var countryInfo = JSON.parse(xhr.response);
        console.log(countryInfo);
        initMap(countryInfo[0].lat, countryInfo[0].lon);
      }
    };
  }
});

function initMap(myLat = 0, myLng = 0) {
  if (myLat === 0 && myLng === 0) {
    console.log(myLat, myLng);
    const myLatLng = { lat: Number(myLat), lng: Number(myLng) };
    const map = new google.maps.Map(document.getElementById("map"), {
      zoom: 2,
      center: myLatLng,
    });
  } else {
    console.log(myLat, myLng);
    const myLatLng = { lat: Number(myLat), lng: Number(myLng) };
    const map = new google.maps.Map(document.getElementById("map"), {
      zoom: 5,
      center: myLatLng,
    });
    new google.maps.Marker({
      position: myLatLng,
      map,
      title: "Hello World!",
    });
  }
}

window.initMap = initMap;
