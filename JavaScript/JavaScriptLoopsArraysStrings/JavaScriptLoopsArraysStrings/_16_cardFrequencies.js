function findCardFrequency(str) {
    var cards = str.split(/[♣♦♥♠ ]+/);
    var repeats;
    var percents;

    for (var i = 0; i < cards.length-1; i++) {
        repeats = 1;
        if (cards[i]!="counted") {

            for (var j = i+1; j < cards.length; j++) {
                if (cards[i] == cards[j]) {
                    repeats++;
                    //Mark card as counted
                    cards[j]="counted";
                }
            }
            percents = ((repeats / (cards.length-1)) * 100).toFixed(2);
            console.log(cards[i] + " -> " + percents + "%");
        }
    }
}

findCardFrequency('8♥ 2♣ 4♦ 10♦ J♥ A♠ K♦ 10♥ K♠ K♦')
findCardFrequency('J♥ 2♣ 2♦ 2♥ 2♦ 2♠ 2♦ J♥ 2♠')
findCardFrequency('10♣ 10♥')