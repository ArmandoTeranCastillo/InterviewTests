using System.Text;

namespace InterviewTests.Common;

public abstract class BasicAlgorithms
{
    public static int SumTwoValues(int num1, int num2)
    {
        if (num1 == num2)
        {
            return (num1 + num2) * 3;
        }
        else
        {
            return (num1 + num2);
        }
    }

    public static int AbsoluteDifference(int num)
    {
        if (num <= 51)
        {
            return (51 - num);
        }

        return (num - 51) * 3;
    }

    public static bool IsSum30(int num1, int num2)
    {
        return (num1 + num2) is 30;
    }

    public static string RemoveCharacter(string str, int position)
    {
        var charList = new List<char>(str);
        if (position < charList.Count)
        {
            charList.RemoveAt(position);

        }

        return string.Concat(charList);
    }

    public static string ChangeFirstAndLast(string str)
    {
        if (str.Length < 2) return str;
        var strList = new List<char>(str);
        (strList[0], strList[^1]) = (strList[^1], strList[0]);
        return string.Concat(strList);
    }

    public static string RepeatFirstCharacters(string str)
    {
        return str.Length < 2
            ? str
            : new string(new[] { str[0], str[1], str[0], str[1], str[0], str[1], str[0], str[1] });
    }

    public static string ExpandString(string str)
    {
        return new string(str[^1] + str + str[^1]);
    }

    public static bool ThreeNumbersOneRange(int num1, int num2, int num3)
    {
        return Enumerable.Range(20, 50).Contains(num1) ||
               Enumerable.Range(20, 50).Contains(num2) ||
               Enumerable.Range(20, 50).Contains(num3);
    }

    public static int MaxNumber(int num1, int num2, int num3)
    {
        var list = new List<int>
        {
            num1,
            num2,
            num3
        };
        return list.Max();
    }

    public static int Similar100(int num1, int num2)
    {
        return Math.Abs(100 - num1) < Math.Abs(100 - num2) ? num1 : num2;
    }

    public static bool Range40or60(int num1, int num2)
    {
        return (Enumerable.Range(40, 50).Contains(num1) &&
               Enumerable.Range(40, 50).Contains(num2)) ||
               (Enumerable.Range(50, 60).Contains(num1) &&
               Enumerable.Range(50, 60).Contains(num2));
    }

    public static int LargestRangeNumber(int num1, int num2)
    {
        if (num1 is >= 20 and <= 50
            && num2 is >= 20 and <= 50)
        {
            return Math.Max(num1, num2);
        }
        return 0;
    }
}

