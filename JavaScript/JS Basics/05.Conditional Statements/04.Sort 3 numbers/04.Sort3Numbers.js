function solve(args) {

    var numberA = (+args[0]);
    var numberB = (+args[1]);
    var numberC = (+args[2]);

    if (numberA >= numberB && numberA >= numberC) {
        if (numberB >= numberC) {
            console.log(numberA + ' ' + numberB + ' ' + numberC);
        }
        else {
            console.log(numberA + ' ' + numberC + ' ' + numberB);
        }
    }
    else if (numberB >= numberA && numberB >= numberC) {
        if (numberA >= numberC) {
            console.log(numberB + ' ' + numberA + ' ' + numberC);
        }
        else {
            console.log(numberB + ' ' + numberC + ' ' + numberA);
        }
    }
    else if (numberC >= numberA && numberC >= numberB) {
        if (numberA >= numberB) {
            console.log(numberC + ' ' + numberA + ' ' + numberB);
        }
        else {
            console.log(numberC + ' ' + numberB + ' ' + numberA);
        }
    }
}
