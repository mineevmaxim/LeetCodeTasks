/**
 * @param {number[]} arr
 * @param {Function} fn
 * @return {number[]}
 */
var filter = function(arr, fn) {
    let resultArray = [];

	arr.forEach((currentValue, index, array) => {
		if (Boolean(fn(currentValue, index, array))) {
			resultArray.push(currentValue);
		}
	})
	return resultArray;
};