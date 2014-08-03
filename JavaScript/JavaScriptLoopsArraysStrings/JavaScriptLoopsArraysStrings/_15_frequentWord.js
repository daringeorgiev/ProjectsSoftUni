function frequentWord(str) {
    var str = str.toLowerCase();
    var words = str.split(/\W+/);
    words = words.sort();
    var result = [];

    var repeats = 1;
    var maxRep = 1;
    for (var i = 1; i < words.length; i++) {
        if (words[i] == words[i - 1]) {
            repeats++;
            if (repeats==maxRep) {
                result.push(words[i]);
            }
            if (repeats>maxRep) {
                deleteArray(result);
                maxRep = repeats;
                result.push(words[i]);
            }
        }
        else {
            repeats = 1;
        }
    }
    for (var i = 0; i < result.length; i++) {
        if (result[i]!=undefined) {
            console.log(result[i] + " -> " + maxRep + " times")
        } 
    }

}

function deleteArray(arr) {
    for (var i = 0; i < arr.length; i++) {
        delete arr[i];
    }
}

frequentWord('in the middle of the night')
frequentWord('Welcome to SoftUni. Welcome to Java. Welcome everyone.')
frequentWord('Hello my friend, hello my darling. Come on, come here. Welcome, welcome darling.')