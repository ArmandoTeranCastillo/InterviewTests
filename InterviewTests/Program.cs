// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices.JavaScript;
using System.Text.RegularExpressions;
using InterviewTests.Common;

namespace InterviewTests;

public abstract partial class InterviewTests
{
    public static void Main()
    {
        const string input = "Hello Worldddddddddddddddd";
        var counts = FirstTest.CountEachCharacter(input);

        foreach (var pair in counts)
        {
            Console.WriteLine($"Character: {pair.Key}, Count: {pair.Value}");
        }
    }
    //Reverse String
   
}