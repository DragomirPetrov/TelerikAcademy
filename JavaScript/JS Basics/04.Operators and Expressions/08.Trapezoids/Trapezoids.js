function solve(args){

    var sideA = Number(args[0]);
    var sideB = Number(args[1]);
    var height = Number(args[2]);
    var area = ((sideA + sideB) * height) / 2

    console.log(area.toFixed(7));
}
