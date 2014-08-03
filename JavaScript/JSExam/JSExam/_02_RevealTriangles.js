function revealTriangles(input) {
    var result = [];
    var char;
    var row;
    var secondRow;
    var oldRow;
    //console.log(input.length);
    function repalceAt(str,index) {
        var a = str.split("");
        a[index] = "*";
        return a.join("");
    }

    function twoRows(row1, row2) {
        var row="";
        var row1 = row1.toString();
       // var row2 = row2.toString();
        for (var i = 0; i < row2.length; i++) {
            if (row2[i] === '*') {
                //console.log(row1[i]);
                //repalceAt(row1, i)
                row += "*";
            }
            else {
                //console.log(row1[i]);
                //console.log(row1[0]);
                row += row1[i];
            }
        }
        console.log(row);
    }

    for (var i = 0; i < input.length-1 ; i++) {
        row = input[i];
        secondRow = input[i + 1];
        //console.log(row);
        for (var j = 0; j < row.length; j++) {
            char = row[j];
       
            if (((char === secondRow[j - 1]) || ("*" === secondRow[j - 1])) && ((char === secondRow[j]) || ("*" === secondRow[j])) && ((char === secondRow[j + 1]) || ("*" === secondRow[j + 1]))) {
            //if ((char === secondRow[j - 1]) && (char === secondRow[j])  && (char === secondRow[j + 1])) {
                row = repalceAt(row, j);
                secondRow = repalceAt(secondRow, j - 1);
                secondRow = repalceAt(secondRow, j);
                secondRow = repalceAt(secondRow, j +1);
            }
        }
        //twoRows(oldRow, secondRow);
        //console.log(row);
        if (i===0) {
            console.log(row);
        }
        else if (i === input.length - 2) {
            twoRows(oldRow, row);
            //console.log(row);
            console.log(secondRow);
            
        }
        else {
            //console.log(secondRow);
            twoRows(oldRow, row);
        }
        oldRow = secondRow;
        //twoRows(row, secondRow);
        //console.log(secondRow);
    }
   
}

revealTriangles(["abcdexgh", "bbbdxxxh", "abcxxxxx"])
revealTriangles(["ax", "xxx", "b", "bbb", "bbbb"])