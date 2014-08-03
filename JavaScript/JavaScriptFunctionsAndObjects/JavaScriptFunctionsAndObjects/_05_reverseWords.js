function reverseWordsInString(str) {
    var words = str.split(" ");
    var result;

    for (var i = 0; i < words.length; i++) {
        var reveresed = words[i].split("").reverse().join("");

        if (i===0) {
            result = reveresed + " ";
        }
        else {
            result += reveresed + " ";
        }
        
    }
    console.log(result);
}

reverseWordsInString('Hello, how are you.')
reverseWordsInString('Life is pretty good, isn’t it?')
