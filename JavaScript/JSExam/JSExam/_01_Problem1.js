function problem1(input) {
    var start= Number (input[0]);
    var end= Number (input[1]);
    var fib;
    
    var row1 = "<table>\n<tr><th>Num</th><th>Square</th><th>Fib</th></tr>"
    console.log(row1);
   
    for (var i = start; i < end + 1; i++) {
        if (((Math.sqrt((5 * (i * i) + 4)) % 1 === 0) || (Math.sqrt((5 * (i * i) - 4)) % 1 === 0))&&i!=0) {
            fib = "yes";
        }
        else {
            fib = "no";
        }

        var row = "<tr><td>" + i + "</td><td>" + i * i + "</td><td>" + fib + "</td></tr>";
        console.log(row);
    }
   
    console.log("</table>");
}
problem1([0, 1])