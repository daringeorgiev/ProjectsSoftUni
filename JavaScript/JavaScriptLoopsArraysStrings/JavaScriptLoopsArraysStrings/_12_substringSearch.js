function countSubstringOccur(arr) {
    var keyword = arr[0];
    var string = arr[1];
    var count = 0;
    string = string.toLowerCase();
    string = string.split(" ");

    for (var i = 0; i < string.length; i++) {
        if (string[i] === keyword) {
            count++;
        }
    }
    console.log(count);
}

countSubstringOccur(["in", "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days."])
countSubstringOccur(["your", "No one heard a single word you said. They should have seen it in your eyes. What was going around your head."])
countSubstringOccur(["but", "But you were living in another world tryin' to get your message through."])