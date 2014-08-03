function calcCircleArea() {
    var radius = document.getElementById('radius').value;
    document.body.innerHTML += "area = " + (Math.PI * Math.pow(radius, 2));
}