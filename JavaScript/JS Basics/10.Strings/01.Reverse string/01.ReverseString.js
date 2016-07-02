function solve(args) {

  let input = String(args),
  output = '',
  i,
  len = input.length;

  for (i = len - 1; i >= 0; i -= 1) {
    output += input[i];
  }
  console.log(output);
}
