/**
 * @param {Function} fn
 * @return {Function}
 */
function memoize(fn) {
    const mapArgumentsResult = {};
    return function(...args) {
        const jsonArgs = JSON.stringify(args);
		if (jsonArgs in mapArgumentsResult) {
			return mapArgumentsResult[jsonArgs];
		}
		const callbackResult = fn(...args);
		mapArgumentsResult[jsonArgs] = callbackResult;
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