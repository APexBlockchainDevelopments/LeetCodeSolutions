public class Solution {
    public int SingleNumber(int[] nums) {
        
        List<int> listInt = new List<int>();
        for(int i = 0; i < nums.Length; i++){
            if(listInt.Contains(nums[i])){
                listInt.Remove(nums[i]);
            } else {
                listInt.Add(nums[i]);
            }
        }
        
        return listInt[0];
    }
}