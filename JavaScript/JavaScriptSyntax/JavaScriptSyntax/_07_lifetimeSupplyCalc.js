function calcSupply() {
    kg = (arguments[1] - arguments[0]) * 365 * arguments[2];
    console.log(kg + "kg of chocolate would be enough until I am " + arguments[1] +" years old.");
}

calcSupply(38, 118, 0.5) 
calcSupply(20, 87, 2) 
calcSupply(16, 102, 1.1)

