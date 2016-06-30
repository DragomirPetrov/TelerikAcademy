function solve(args) {

    var len = +args[0];
    var arr = args[1].split(' ').map(Number);
    var numToFind = +args[2];
    var counter = 0;

    for (var i = 0; i < len; i += 1) {
        if (arr[i] === numToFind) {

            counter += 1;
        }
    }
    console.log(counter);
}