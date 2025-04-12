function initMap() {
  const myLatLng = { lat: 42.37326, lng: -71.06217 };
  const map = new google.maps.Map(document.getElementById("map"), {
    zoom: 14,
    center: myLatLng,
  });

  new google.maps.Marker({
    position: myLatLng,
    map,
    title: "Hello World!",
  });
}

window.initMap = initMap;
