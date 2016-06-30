function solve(args) {

    var input = args[0],
    arr = [],
    i;
 
     for(var i = 0; i < input; i += 1) {
         arr[i] = i * 5;
        console.log(arr[i]);
     }
}

solve([]);