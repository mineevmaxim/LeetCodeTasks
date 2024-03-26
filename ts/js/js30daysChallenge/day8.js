/**
 * @param {Function[]} functions
 * @return {Function}
 */
var compose = function(functions) {
    let currentValue;
    return function(x) {
		currentValue = x;
		if (functions.length == 0) {
			return currentValue;
		}
		for (let index = functions.length - 1; index >= 0; index--) {
			let fn = functions[index];
			currentValue = fn(currentValue);		
		}
		return currentValue;
    }
};

/**
 * const fn = compose([x => x + 1, x => 2 * x])
 * fn(4) // 9
 */