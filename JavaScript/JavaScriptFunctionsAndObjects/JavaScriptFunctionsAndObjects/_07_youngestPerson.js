function findYoungestPerson(persons) {
    var minAge=persons[0].age;
    var name = persons[0].firstname + " " + persons[0].lastname;
    for (var i = 1; i < persons.length; i++) {
        if (minAge > persons[i].age) {
            minAge = persons[i].age;
            name = persons[i].firstname + " " + persons[i].lastname;
        }
    }

    console.log("The youngest person is %s", name);

}

findYoungestPerson([{ firstname : 'George', lastname: 'Kolev', age: 32}, 
{ firstname : 'Bay', lastname: 'Ivan', age: 81},
{ firstname : 'Baba', lastname: 'Ginka', age: 40}])
