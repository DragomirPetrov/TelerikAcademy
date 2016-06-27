function solve(args){

    var input = Number(args[0]);

    var x = args[0];
    var y = args[1];

    var distance = Math.sqrt((x * x) + (y * y));

  if (distance <= 2) {
    console.log('yes ' + distance.toFixed(2));
  }
  else {
    console.log('no ' + distance.toFixed(2));
  }
}
