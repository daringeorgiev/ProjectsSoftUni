function displayProperties() {
    var properties = [];
    for (var prop in document) {
        properties.push(prop);
    }
    console.log(properties);
}

displayProperties()