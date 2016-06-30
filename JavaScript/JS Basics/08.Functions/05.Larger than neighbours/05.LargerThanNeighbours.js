function solve(args) {

    var len = +args[0];
    var arr = args[1].split(' ').map(Number);
    var counter = 0;

    for (var i = 1; i < len - 1; i += 1) {
        if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1]) {

            counter += 1;
        }
    }
    console.log(counter);
}