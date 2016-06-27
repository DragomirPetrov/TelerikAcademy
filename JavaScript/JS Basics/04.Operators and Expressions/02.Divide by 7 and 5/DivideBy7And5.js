function solve(args) {

    var input = Number(+args[0]);

    var number;
    if (input % 7 === 0 && input % 5 === 0) {
        number = 'true';
    }
    else {
        number = 'false';
    }
    console.log(number + ' ' + input);
}
