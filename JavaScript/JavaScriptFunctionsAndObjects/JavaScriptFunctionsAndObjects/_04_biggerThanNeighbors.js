function biggerThanNeighbors(index, arr) {
    if (index==0) {
        console.log("Only one neighbor");
        return;
    }
    if (index==arr.length-1) {
        console.log("Only one neighbor");
        return;
    }
    if (index > arr.length - 1) {
        console.log("invalid index");
        return;
    }

    if ((arr[index] > arr[index - 1]) && (arr[index] > arr[index + 1])) {
        console.log("bigger");
        return;
    }
    else {
        console.log("not bigger");
        return;
    }
    
}

biggerThanNeighbors(2, [1, 2, 3, 3, 5])
biggerThanNeighbors(2, [1, 2, 5, 3, 4])
biggerThanNeighbors(5, [1, 2, 5, 3, 4])
biggerThanNeighbors(0, [1, 2, 5, 3, 4])