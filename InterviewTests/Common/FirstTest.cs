using System.Text;
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

    public static string RemoveDuplicates(string s)
    {
        var array = s.ToCharArray();
        var newlist = new List<char>();
        foreach (var character in array)
        {
            if (!newlist.Contains(character))
            {
                newlist.Add(character);
            }
        }
        return string.Join(" ", newlist);
    }

    public static string GetAllSubStrings(string s)
    {
        var allSubstrings = new StringBuilder();
        for (var i = 0; i < s.Length; i++)
        {
            var substring = new StringBuilder(s.Length - i);
            for (var j = i; j < s.Length; j++)
            {
                substring.Append(s[j]);
                allSubstrings.Append(substring + ", ");
            }
        }
        if (allSubstrings.Length > 0)
        {
            allSubstrings.Remove(allSubstrings.Length - 2, 2);
        }
        return allSubstrings.ToString();
    }

    public static string RotateLeft(string s)
    {
        var array = s.ToCharArray();
        for (var i = 0; i < s.Length - 1; i++)
        {
            (array[i + 1], array[i]) = (array[i], array[i + 1]);
        }
        return string.Concat(array);
    }

    public static string RotateRight(string s)
    {
        var array = s.ToCharArray();
        for (var i = s.Length - 1; i > 0; i--)
        {
            (array[i - 1], array[i]) = (array[i], array[i - 1]);
        }
        return string.Concat(array);
    }

    public static string IsPrime(double n)
    {
        if (n < 2) return "No es primo";
        
        for (var i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                return "No es primo";
            }
        }
        return "Es primo";
    }

    public static string SumAllDigits(string s)
    {
        var charArray = s.ToCharArray();
        var array = Array.ConvertAll(charArray, c => (int)char.GetNumericValue(c));
        var sum = array.Sum();
        return sum.ToString();
    }
}