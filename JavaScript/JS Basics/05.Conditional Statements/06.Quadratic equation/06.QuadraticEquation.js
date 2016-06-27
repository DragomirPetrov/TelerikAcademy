function solve(args) {

    var a = (+args[0]);
    var b = (+args[1]);
    var c = (+args[2]);

    var x = (b * b) - (4 * a * c);
    var root, firstRoot, secondRoot;

    if (x < 0) {
        console.log('no real roots');
    }
    else if (x === 0) {
        root = -b / (2 * a);
        console.log('x1=x2=' + root.toFixed(2));
    }
    else {
        firstRoot = ((-b + Math.sqrt(x)) / (2 * a));
        secondRoot = ((-b - Math.sqrt(x)) / (2 * a));
        console.log('x1=' + secondRootRoot.toFixed(2) + '; ' + 'x2=' + firstRoot.toFixed(2));
    }

}
