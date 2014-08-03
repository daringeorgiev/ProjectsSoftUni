function checkBrackets(str) {
    var frontBrackets = 0;
    var backBrackets = 0;
    var incorect = false;

    for (var ch in str) {
        if (str[ch]=='(') {
            frontBrackets++;
        }
        if (str[ch] == ')') {
            backBrackets++;
        }
        if (frontBrackets<backBrackets) {
            incorect = true;
        }
    }
    if (incorect) {
        console.log("incorrect");
    }
    else {
        if (frontBrackets == backBrackets) {
            console.log("correct");
        }
        else {
            console.log("incorrect");
        }
    }
}

checkBrackets('( ( a + b ) / 5 – d )')
checkBrackets(') ( a + b ) )')
checkBrackets('( b * ( c + d *2 / ( 2 + ( 12 – c / ( a + 3 ) ) ) )')