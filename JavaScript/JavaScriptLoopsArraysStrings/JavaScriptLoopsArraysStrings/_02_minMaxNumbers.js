function findMinAndMax(value) {
    var min = value[0];
    var max = value[0];
    for (var i = 0; i < value.length; i++) {
        if (min > value[i]) {
            min = value[i];
        }
        if (max < value[i]) {
            max = value[i];
        }
    }
    console.log("min -> " + min);
    console.log("max -> " + max);
}

findMinAndMax([1, 2, 1, 15, 20, 5, 7, 31])
findMinAndMax([2, 2, 2, 2, 2])
findMinAndMax([500, 1, -23, 0, -300, 28, 35, 12])