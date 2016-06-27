function solve(args){

    var input = Number(args[0]);

    var isPrime = true;
    var length = Math.sqrt(input)

    if (input < 2) {
        isPrime = false;

    }
    else {
        for (var index = 2; index <=length; index += 1) {
            if (input % index === 0) {
                isPrime = false;
                break;
            }
        }
    }
    console.log(isPrime);
}
