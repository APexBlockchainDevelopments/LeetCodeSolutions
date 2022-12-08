public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int x = nums.Length * 2;
        int[] result = new int[x];
        for(int i = 0; i < nums.Length; i++){
            result[i] = nums[i];
            result[i + nums.Length] = nums[i];
        }
        return result;
    }
}