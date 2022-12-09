/**
 * @param {number[]} nums
 * @return {number}
 */
var singleNumber = function(nums) {
    for(let i =0; i < nums.length; i++){
        let temp = nums[i]
        nums[i] = null
        if(nums.includes(temp)){
            nums[i] = temp
        } else {
            return temp
        }
    }
    return 0
};