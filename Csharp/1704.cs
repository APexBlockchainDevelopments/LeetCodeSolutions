public class Solution
{
    public bool HalvesAreAlike(string s)
    {
        //splitting a string in 2
        s = s.ToLower();
        int half = s.Length / 2;

        char[] firstHalf = s.Take(half).ToArray();
        char[] secondHalf = s.Skip(half).ToArray();

        //count how mahy vowles each contains
        int a = countVowles(firstHalf);
        int b = countVowles(secondHalf);


        //if they are equal retgurn true otherwise false
        if (a == b) return true;
        else return false;

    }

    public int countVowles(char[] message)
    {
        int a = 0;
        foreach (var letter in message)
        {
            if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u') a++;
        }
        return a;
    }
}