function solve() {
	function isPrime(number) {
		for(let i = 2; i < number; i += 1) {
			if (number % i === 0) {
				return false;
			}		
		}
		return true;
	}

	return function findPrimes(start, end) {

		let arr = [];
		
			if (isNaN(start) || isNaN(end)) {
				throw 'Error! All elements must be convertible to numbers';
			}else if (start === null || end === null) {
				throw 'Error! Element is missing';
			}
		
			for(let i = +start; i <= +end; i += 1) {
				if (i !== 0 && i !== 1) {
					if (isPrime(i)) {
						arr.push(i);
				}
			}	
		} 
		return arr;
	};
}

module.exports = solve;
