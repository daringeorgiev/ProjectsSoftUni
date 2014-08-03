function numberChecker(n) {
    var nums=[];
    for (var i = 0; i < n; i++) {
        if (i%4!=0 && i%5!=0 ) {
            nums.push(i);
        }
    }
    if (nums.length == 0) {
        console.log('no');
    }
    else {
        console.log(nums);
    }
}

numberChecker(20)
numberChecker(-5)
numberChecker(13)