var time = new Date();
var hours = time.getHours();
var mins = time.getMinutes();
if (mins < 10) {
    console.log(hours + ":" + 0 + mins);
} else {
    console.log(hours + ":" + mins);
}
