// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices.JavaScript;
using System.Text.RegularExpressions;
using InterviewTests.Common;

namespace InterviewTests;

public abstract class InterviewTests
{
    public static void Main()
    {
        var array = FirstTest.OrderString("Adcefyeclcus434");
        foreach (var element in array)
        {
            Console.WriteLine("{0}", element);
        }
    }
}