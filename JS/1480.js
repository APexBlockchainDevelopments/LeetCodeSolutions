/**
 * @param {number[]} nums
 * @return {number[]}
 */
var runningSum = function(nums) {
    let arr = []

    for(let i = 0; i < nums.length; i++){
        if(i === 0) arr[i] = nums[i]
        else arr[i] = nums[i] + arr[i -1]
    }

    return arr
};
