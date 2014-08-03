function sequenceFinder(arr) {
    var lenght = 1;
    var maxLenght = 1;
    var symbol = arr[0];
    var result = [];
    for (var i = 1; i < arr.length; i++) {
        if (arr[i]===arr[i-1]) {
            lenght++;
        }
        else {
            lenght = 1;
        }
        if (lenght>=maxLenght) {
            maxLenght = lenght;
            symbol = arr[i];
        }
    }
    for (var i = 0; i < maxLenght; i++) {
        result[i] = symbol;
    }
    console.log(result);
}

sequenceFinder([2, 1, 1, 2, 3, 3, 2, 2, 2, 1])
sequenceFinder(['happy'])
sequenceFinder([2, 'qwe', 'qwe', 3, 3, '3'])