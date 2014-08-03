function findPalindromes(str) {
    var str = str.toLowerCase();
    var words = str.split(/\W+/);
    var result=[];

    for (var i = 0; i < words.length; i++) {
        var reversed = words[i].split("").reverse().join("");
        if (words[i] == reversed) {
            if (words[i]!="") {
                result.push(words[i])
            }
        }
    }
    console.log(result);
}
findPalindromes('There is a man, his name was Bob.')
