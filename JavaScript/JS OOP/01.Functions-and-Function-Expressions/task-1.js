function solve() {
	return function sum(args) {

		let result = 0;

		if (args.length === 0) {
			return null;
		}else if (args === 'undefined') {
			throw 'Error! Parameter is not passed!';
		}

		for(let i = 0; i < args.length; i += 1) {

			if (isNaN(args[i])) {
				throw 'Error! All elements must be convertible to numbers';
			}else	
			result += args[i] * 1;	
		}
		return result;			
	};	
}
module.exports = solve;
