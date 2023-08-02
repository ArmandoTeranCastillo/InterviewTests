using System.Text.RegularExpressions;

namespace InterviewTests.Common;

public abstract class FirstTest
{
    public static string ReverseString(string s)
    {
        var charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
    
    //Check palindrome
    public static string CheckPalindrome(string s)
    {
        int i;
        s = s.ToLower();
        var normalArray = s.ToCharArray();
        var reverseArray = s.ToCharArray(); 
        Array.Reverse(reverseArray);
        for(i = 0; i < reverseArray.Length; i++)
        {
            if (normalArray[i] != reverseArray[i])
                return "No es palindromo";
        }
        return "Es un palindromo";
    }
    //Reverse phrase
    public static string ReversePhrase(string s)
    {
        var array = Regex.Split(s, "( )");
        Array.Reverse(array);
        return string.Concat(array);
    }

    public static string ReverseEachString(string s)
    {
        var array = Regex.Split(s, "( )");
        var newArray = new List<string>();
        foreach (var element in array)
        {
            var chararray = element.ToCharArray();
            Array.Reverse(chararray);
            newArray.Add(new string (chararray));
        }
        return string.Concat(newArray);
    }

    public static Dictionary<char, int>CountEachCharacter(string s)
    {
        var count = new Dictionary<char, int>();
        var array = s.ToCharArray();
        foreach (var element in array)
        {
            if (element == ' ') continue;
            if (!count.ContainsKey(element))
            {
                count.Add(element, 1);
            }
            else
            {
                count[element]++;
            }

        }
        return count;
    }
}