function solve(args) {
    
    var arr = args[0].split('\n');
        n = +arr[0],
        numbers = arr.slice(1),

        current = +numbers[0],
        sum = 1,
        max = 0;

    for (var i = 0; i < n; i += 1) {

        if (current === +numbers[i + 1]) {
            sum+=1;
        }
        else {
            if (sum > max) {
                max = sum;
            }
            sum = 1;
        }
        current = +numbers[i + 1];
    }
    console.log(max);
}
