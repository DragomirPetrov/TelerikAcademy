function solve(args) {
  var arr = args,
    remove = arr[0];

  Array.prototype.remove = function (rem) {
    var result = [];

    for(var i in this){
      if (this[i] !== rem && typeof this[i] !== 'function') {
        result.push(this[i]);
      }
    }
   return result;
  };

  console.log(arr.remove(remove).join('\n'));
}
