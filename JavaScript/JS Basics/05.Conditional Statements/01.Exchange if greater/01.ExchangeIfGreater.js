function solve(args) {

    var numberA = (+args[0])
    var numberB = (+args[1])

    if (numberA > numberB) {
        console.log(numberB + ' ' + numberA);
    }
    else {
        console.log(numberA + ' ' + numberB);
    }
}
