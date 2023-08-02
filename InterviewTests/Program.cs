// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices.JavaScript;
using System.Text.RegularExpressions;
using InterviewTests.Common;

namespace InterviewTests;

public abstract class InterviewTests
{
    public static void Main()
    {
        Console.WriteLine(FirstTest.SumAllDigits("1234567810"));
    }
}