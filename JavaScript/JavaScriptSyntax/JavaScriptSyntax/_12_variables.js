function variablesTypes(input) {
    console.log("My name: %s // type is %s ", input[0], typeof (input[0]));
    console.log("My age: %s // type is", input[1], typeof (input[1]));
    console.log("I am male: %s // type is %s ", input[2], typeof (input[2]));
    console.log("My favourite foods are: %s // type is %s", input[3].toString(), typeof (input[3]));
}
variablesTypes(['Darin', 24, true, ['fries', 'banana', 'cake']]);

