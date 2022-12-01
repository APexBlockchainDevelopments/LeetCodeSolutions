public class Solution {
    public string DefangIPaddr(string address) {
         string result = address.Replace(".", "[.]");
        return result;
    }
}