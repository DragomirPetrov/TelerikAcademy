function solve(args) {

    var numberA = (+args[0]);
    var numberB = (+args[1]);
    var numberC = (+args[2]);

    var result = numberA * numberB * numberC;

    if (result > 0) {
        console.log('+');
    }
    else if (result < 0) {
        console.log('-');
    }
    else {
        console.log('0');
    }
}
