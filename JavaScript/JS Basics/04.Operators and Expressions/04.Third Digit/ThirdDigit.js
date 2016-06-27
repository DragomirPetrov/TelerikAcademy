function solve(args) {

    var input = Number(+args);

    thirdDigit = Math.floor(input / 100);
    thirdDigit = thirdDigit % 10;

    if (thirdDigit === 7) {

        console.log(true);
    }
    else {
        console.log(false + ' ' + thirdDigit);
    }
}    
