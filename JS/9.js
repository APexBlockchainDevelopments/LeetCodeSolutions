/**
 * @param {number} x
 * @return {boolean}
 */
var isPalindrome = function (x) {
    let xString = [...x.toString()]
    let xStringReversed = []

    for (let i = 0; i < xString.length; i++) {
        xStringReversed.push(xString[xString.length - i - 1]);
    }

    if (xString.toString() === xStringReversed.toString()) return true
    else return false
};