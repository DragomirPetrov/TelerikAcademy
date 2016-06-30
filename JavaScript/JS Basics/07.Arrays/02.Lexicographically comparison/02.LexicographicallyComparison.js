function solve(args) {

    var words = args[0].split('\n'),
    first = String(words[0]),
    second = String(words[1]);
    
    if (first > second) {
        console.log('>');
    }
    else if (first < second) {
        console.log('<');
    }
    else if (first === second) {
        console.log('=');
    }
}