function solve(args) {

    var numberA = (+args[0]);
    var numberB = (+args[1]);
    var numberC = (+args[2]);

    if (numberA > numberB && numberA > numberC) {
        console.log(numberA);
    }
    else if (numberB > numberA && numberB > numberC) {
        console.log(numberB);
    }
    else {
        console.log(numberC);
    }
}
