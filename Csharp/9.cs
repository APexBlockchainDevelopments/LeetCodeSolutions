public class Solution
{
    public bool IsPalindrome(int x)
    {
        //Convert to string
        string numAsString = x.ToString();
        char[] reversedString = new char[numAsString.Length];
        //convert to array

        for (int i = 1; i <= numAsString.Length; i++) reversedString[numAsString.Length - i] = numAsString[i - 1];
        //check if equal
        if (new string(reversedString) == numAsString) return true;
        else return false;
    }
}