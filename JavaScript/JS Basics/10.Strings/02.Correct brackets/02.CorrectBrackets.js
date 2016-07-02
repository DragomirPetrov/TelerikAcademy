function solve(args) {

    let str = args[0] + "",
    len = str.length,
    i,
    counter = 0;

    for(let i = 0; i < len; i += 1) {
        if (str[i] === '(') {
            counter += 1;
        }else if (str[i] === ')') {
         counter -= 1;   
        }
    }
    console.log(counter ? 'Incorrect' : 'Correct');
}