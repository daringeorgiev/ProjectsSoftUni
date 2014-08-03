function sortArray(arr) {
    var min;
    var minIndex;
    var temp;
    for (var i = 0; i < arr.length; i++) {
        min = arr[i];
        minIndex = i;
        for (var j = i; j < arr.length; j++) {
            if (min > arr[j]) {
                min = arr[j];
                minIndex = j;
            }
        }
        temp = arr[i];
        arr[i] = min;
        arr[minIndex] = temp;
    }

}

function findMostFreqNum(arr) {
    sortArray(arr);
    var repeats=1;
    var maxRepeats=1;
    var value = arr[0];
    for (var i = 1; i < arr.length; i++) {
        if (arr[i]===arr[i-1]) {
            repeats++;
        }
        else {
            repeats = 1;
        }
        if (maxRepeats<repeats) {
            maxRepeats = repeats;
            value = arr[i];
        }
    }
    console.log(value + " (" + maxRepeats + " times)");
}



findMostFreqNum([4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3])
findMostFreqNum([2, 1, 1, 5, 7, 1, 2, 5, 7, 3, 87, 2, 12, 634, 123, 51, 1])
findMostFreqNum([1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13])