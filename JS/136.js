/**
 * @param {number[]} nums
 * @return {number}
 */
var singleNumber = function(nums) {
    for(let i =0; i < nums.length; i++){
        let arr = nums;
        arr[i] = null;
        console.log(arr);
    }
    return 0
};