function maxSequenceFinder(arr) {
    var lenght = 1;
    var maxLenght = 1;
    var startIndex = 0;
    var result = [];
    for (var i = 1; i < arr.length; i++) {
        if (arr[i] > arr[i - 1]) {
            lenght++;
        }
        else {
            lenght = 1;
        }
        if (lenght >= maxLenght) {
            maxLenght = lenght;
            startIndex = i-maxLenght+1;
        }
    }
    if (lenght==1) {
        console.log("no");
    }
    else {
        for (var i = 0; i < maxLenght; i++) {
            result[i] = arr[startIndex + i];
        }
        console.log(result);
    }
 
}

maxSequenceFinder([3, 2, 3, 4, 2, 2, 4])
maxSequenceFinder([3, 5, 4, 6, 1, 2, 3, 6, 10, 32])
maxSequenceFinder([3, 2, 1])
