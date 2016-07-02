function solve(args) {

    let word = (args[0] + '').toLowerCase(),
    str = (args[1] + '').toLowerCase(), 
    counter = 0;

    let index = str.indexOf(word);

    while (index >= 0) {
        counter += 1;
        index = str.indexOf(word, index + 1);
    }
    console.log(counter);
}
//solve ([
//   'in',
//    'We are living in an yellow submarine. We don\'t have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.'
//]);