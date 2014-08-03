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
    console.log(arr);
}

sortArray([5, 4, 3, 2, 1])
sortArray([12, 12, 50, 2, 6, 22, 51, 712, 6, 3, 3])