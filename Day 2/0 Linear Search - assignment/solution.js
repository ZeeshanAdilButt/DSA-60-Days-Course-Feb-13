function findNumbersInRange(arr, low, high) {
    let result = [];
    for (let num of arr) {
        if (num >= low && num <= high) {
            result.push(num);
        }
    }
    return result;
}
