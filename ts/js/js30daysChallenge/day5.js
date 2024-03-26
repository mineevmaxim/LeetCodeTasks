/**
 * @param {number[]} arr
 * @param {Function} fn
 * @return {number[]}
 */
var map = function(arr, fn) {
    let resultArray = [];
	arr.forEach((currentValue, index, array) => {
		resultArray.push(fn(currentValue, index, array));
	})
	return resultArray;
};