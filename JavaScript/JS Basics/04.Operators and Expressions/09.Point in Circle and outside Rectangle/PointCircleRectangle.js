function solve(args){

  var pointX = Number(args[0]);
  var pointY = Number(args[1]);

  var inCricle = false;
  var inRectangle = false;

  var distanceToCircleX = pointX - 1;
  var distanceToCircleY = pointY - 1;

  var distanceToCircle = Math.sqrt(
    (distanceToCircleX
      * distanceToCircleX)
    + (distanceToCircleY
      * distanceToCircleY));

  if (distanceToCircle <= 1.5) {
    inCricle = true;
  }

  if (pointX >= -1
    && pointX <= 5
    && pointY <= 1
    && pointY >= -1) {

    inRectangle = true;
  }

  var output = '';
  if (inCricle) {
    output += 'inside circle ';
  }
  else {
    output += 'outside circle ';
  }

  if (inRectangle) {
    output += 'inside rectangle';
  }
  else {
    output += 'outside rectangle';
  }
  console.log(output);
}
