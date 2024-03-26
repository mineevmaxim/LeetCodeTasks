/**
 * @param {Function} fn
 * @return {Function}
 */
function argsToString (...args) {
	return args.join('123');
}

function memoize(fn) {
    const mapArgumentsResult = {};
    return function(...args) {
        const argsStr = argsToString(...args);
		if (argsStr in mapArgumentsResult) {
			return mapArgumentsResult[argsStr];
		}
		const callbackResult = fn(...args);
		mapArgumentsResult[argsStr] = callbackResult;
		return callbackResult;
    }
}


/** 
 * let callCount = 0;
 * const memoizedFn = memoize(function (a, b) {
 *	 callCount += 1;
 *   return a + b;
 * })
 * memoizedFn(2, 3) // 5
 * memoizedFn(2, 3) // 5
 * console.log(callCount) // 1 
 */