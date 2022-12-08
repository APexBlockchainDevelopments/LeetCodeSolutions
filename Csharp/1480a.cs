public class Solution {
    public int[] RunningSum(int[] nums) {
        int[] result = new int[nums.Length];
        for(int i = 0; i < nums.Length; i++){
            int sum =0;
            for(int j = 0; j < nums.Length -i; j++){
                sum += nums[j];
            }
            result[nums.Length - i -1] = sum;
        }
        return result;
    }
}