// https://leetcode.com/problems/counting-words-with-a-given-prefix/submissions/1655446609/?envType=daily-question&envId=2025-06-06
// Easy linear search

public class Solution
{

    public static bool ContainsPrefix(string s, string prefix)
    {
        for (int i = 0; i < prefix.Length; i++)
        {
            if (!(i < s.Length && prefix[i] == s[i]))
            {
                return false;
            }
        }
        return true;
    }

    public int PrefixCount(string[] words, string pref)
    {
        int count = 0;
        foreach (string word in words)
        {
            if (ContainsPrefix(word, pref))
            {
                count++;
            }
        }
        return count;
    }
}



public class Solution {
    public int PrefixCount(string[] words, string pref)
    {
        int count = 0;
        foreach (string word in words)
        {
            if (word.StartsWith(pref))
            {
                count++;
            }
        }
        return count;
    }
}