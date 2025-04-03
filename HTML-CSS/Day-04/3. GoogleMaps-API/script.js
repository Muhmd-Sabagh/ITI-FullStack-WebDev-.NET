var country = document.getElementById("country");

// Get the Coords of the country when selected
country.addEventListener("change", function () {
  if (country.value == 0) {
    initMap();
  } else {
    var xhr = new XMLHttpRequest();
    // Using of geocoding API to get the country info (including its Latitude and Longitude)
    xhr.open(
      "GET",
      `https://nominatim.openstreetmap.org/search?format=json&q=${country.value}`
    );
    xhr.send();

    xhr.onreadystatechange = function () {
      if (xhr.readyState == 4 && xhr.status == 200) {
        var countryInfo = JSON.parse(xhr.response);
        initMap(countryInfo[0].lat, countryInfo[0].lon);
      }
    };
  }
});

// Display the selected country map
function initMap(myLat = 0, myLng = 0) {
  if (myLat === 0 && myLng === 0) {
    const myLatLng = { lat: Number(myLat), lng: Number(myLng) };
    const map = new google.maps.Map(document.getElementById("map"), {
      zoom: 2,
      center: myLatLng,
    });
  } else {
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
