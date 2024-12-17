using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Security.Cryptography;
using System.Reflection.Metadata;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata.Ecma335;
using System;

namespace assigment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1
            ////Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.

            //int test1;
            //bool result = int.TryParse(Console.ReadLine(), out test1);
            //if (result && test1 % 3 == 0 && test1 % 4 == 0)
            //{
            //    Console.WriteLine("yes");
            //}
            //else if (result)
            //{
            //    Console.WriteLine("no");
            //}
            //else
            //{
            //    Console.WriteLine("NOT CORRECT INPUT");
            //}
            #endregion

            #region 2
            ////Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive
            //int input;
            //bool result = int.TryParse(Console.ReadLine(), out input);
            //if (result && input > 0)
            //{
            //    Console.WriteLine("Positive");
            //}
            //else if (result && input < 0)
            //{
            //    Console.WriteLine("Negative");
            //}
            //else {
            //    Console.WriteLine("NOT CORRECT INPUT");   
            //}
            #endregion

            #region 3
            ////Write a program that takes 3 integers from the user then prints the max element and the min element.
            //int num1, num2, num3;
            //bool result1, result2, result3;
            //result1 = int.TryParse(Console.ReadLine(), out num1);
            //result2 = int.TryParse(Console.ReadLine(), out num2);
            //result3 = int.TryParse(Console.ReadLine(), out num3);
            //int[] ints = { num1, num2, num3 };
            //if (result1 && result2 && result3)
            //{
            //    Console.WriteLine($"input {num1},{num2},{num3}\noutput:\nmax element: {ints.Max()}\nmin element: {ints.Min()}");
            //}
            //else {
            //    Console.WriteLine("NOT CORRECT INPUT"); 
            //}
            #endregion

            #region 4
            ////Write a program that allows the user to insert an integer number then check If a number is even or odd.
            //int number;
            //bool result = int.TryParse(Console.ReadLine(), out number);

            //Console.WriteLine(result switch
            //{
            //    true when number % 2 == 0 => "even",
            //    true when number % 2 != 0 => "odd",
            //    _ => "not correct input"
            //}
            //);
            #endregion

            #region 5
            ////Write a program that takes character from the user then if it is a vowel chars(a, e, I, o, u) then print(vowel) otherwise print(consonant).
            //char test;
            //bool Return = char.TryParse(Console.ReadLine(), out test);
            //string vowel = "aeIou";
            //if (Return && vowel.Contains(char.ToLower(test)) && char.IsLetter(test))
            //{
            //    Console.WriteLine($"Input: {test}\nOutput: Vowel");
            //}
            //else if (Return && char.IsLetter(test))
            //{
            //    Console.WriteLine($"Input: {test}\nOutput: Consonant");
            //}
            //else
            //    Console.WriteLine("not correct input");
            #endregion

            #region 6
            //int test;
            //bool result = int.TryParse(Console.ReadLine(), out test);
            //int i = 1;
            //if (result)
            //{
            //    Console.Write($"Input: {test}\nOutput: ");
            //    for (; i <= test; i++)
            //    {
            //        Console.Write(i == test ? i : $"{i}, ");
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("not correct input");
            //}
            #endregion

            #region 7
            //int test;
            //bool result = int.TryParse(Console.ReadLine(), out test);
            //if (result)
            //{
            //    Console.Write($"Input: {test}\nOutput: ");
            //    int output = 0,i = 0;
            //    for (; i < 12; i++)
            //    {
            //        Console.Write(i == 11 ? output += test : $"{output += test}, ");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("not correct input");
            //}
            #endregion

            #region 8
            //   int test;
            //bool result = int.TryParse(Console.ReadLine(), out test);
            //int i = 1;
            //if (result)
            //{
            //    Console.Write($"Input: {test}\nOutput:");
            //    for (; i <= test; i++)
            //    {
            //        if (i % 2 == 0)
            //        {
            //            Console.Write($" {i}");
            //        }
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("not correct input");
            //}
            #endregion

            #region 9
            //int num, power;
            //bool result1, result2;
            //Console.WriteLine("enter number ...");
            //result1 = int.TryParse(Console.ReadLine(), out num);
            //Console.WriteLine("enter power ...");
            //result2 = int.TryParse(Console.ReadLine(), out power);
            //if (result1 && result2)
            //{
            //    Console.WriteLine($"Input: {num} {power}\nOutput: {Math.Pow(num, power)}");
            //}
            //else
            //{
            //    Console.WriteLine("not correct");
            //}
            #endregion

            #region 10
            //int subject1, subject2, subject3, subject4, subject5;
            //bool return1, return2, return3, return4, return5;
            //Console.WriteLine("Enter first subject mark...");
            //return1 = int.TryParse(Console.ReadLine(), out subject1);
            //Console.WriteLine("Enter second subject mark...");
            //return2 = int.TryParse(Console.ReadLine(), out subject2);
            //Console.WriteLine("Enter third subject mark...");
            //return3 = int.TryParse(Console.ReadLine(), out subject3);
            //Console.WriteLine("Enter fourth subject mark...");
            //return4 = int.TryParse(Console.ReadLine(), out subject4);
            //Console.WriteLine("Enter fifth subject mark...");
            //return5 = int.TryParse(Console.ReadLine(), out subject5);
            //if (return1 && return2 && return3 && return4 && return5)
            //{
            //    int sum = subject1 + subject2 + subject3 + subject4 + subject5;
            //    Console.WriteLine($"Total mark: {sum}\nAverage: {sum / 5}\npercent: {sum / 5}%");
            //}
            //else
            //{
            //    Console.WriteLine("not correct input");
            //}
            #endregion

            #region 11
            //Console.WriteLine("Enter the month number (1-12):");
            //bool result = int.TryParse(Console.ReadLine(), out int month);
            //if (result)
            //{
            //    Console.WriteLine($"Input: Month Number: {month}\nOutput: Days in Month: {DateTime.DaysInMonth(2024, month)}");
            //}
            //else
            //{
            //    Console.WriteLine("ivalid input");
            //}
            #endregion

            #region 12
            //char Operator;
            //bool result1, result2, result3;
            //Console.WriteLine("Enter the first number:");
            //result1 = double.TryParse(Console.ReadLine(), out double num1);
            //Console.WriteLine("Enter an operator (+, -, *, /):");
            //result3 = char.TryParse(Console.ReadLine(), out Operator);
            //Console.WriteLine("Enter the second number: ");
            //result2 = double.TryParse(Console.ReadLine(), out double num2);
            //bool full_result = (result1 == result2 == result3);
            //Console.WriteLine(full_result switch
            //{
            //    true when Operator == '+' => $"{num1 + num2}",
            //    true when Operator == '-' => $"{num1 - num2}",
            //    true when Operator == '*' => $"{num1 * num2}",
            //    true when Operator == '/' => $"{num1 / num2}",
            //    _ => "invaild input"
            //});
            #endregion

            #region 13
            //string input = Console.ReadLine();
            //if (!string.IsNullOrEmpty(input))
            //{
            //    for (int i = input.Length - 1; i >= 0; i--)
            //    {
            //        Console.Write(input[i]);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("invaild");
            //}
            #endregion

            #region 14
            //bool result = int.TryParse(Console.ReadLine(), out int numbers);
            //if (result)
            //{
            //    int output = 0;
            //    while (numbers != 0)
            //    {
            //        int last = numbers % 10; //store last digit
            //        output = output * 10 + last; //add it to new int
            //        numbers  = numbers / 10; //remove last digit
            //    }
            //    Console.WriteLine(output);
            //}
            //else
            //{
            //    Console.WriteLine("invaild input");
            //}
            #endregion

            #region 15 
            //Console.WriteLine("ENTER FIRST NUM..");
            //bool result1 = int.TryParse(Console.ReadLine(), out int fnum);
            //Console.WriteLine("ENTER SECOND NUM..");
            //bool result2 = int.TryParse(Console.ReadLine(), out int lnum);
            //if (result1 && result2)
            //{
            //    for (; fnum <= lnum; fnum++)
            //    {
            //        if (fnum == 2 || fnum == 3)
            //        {
            //            Console.Write($" {fnum}");
            //            continue;
            //        }
            //        else
            //        {
            //            for (int i = 3; i <= fnum; i++)
            //            {
            //                if (fnum % 2 == 0 || (fnum % i == 0 && fnum != i))
            //                {
            //                    break;
            //                }
            //                else if (fnum == i)
            //                {
            //                    Console.Write($" {fnum}");
            //                }
            //            }
            //        }
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("invaild input");
            //}
            #endregion

            #region 16
            //bool result = int.TryParse(Console.ReadLine(), out int x);
            //if (result)
            //{
            //    string stored = "";
            //    Console.Write($"the binary of {x} is ");
            //    while (x != 0)
            //    {
            //        if (x % 2 == 0)
            //        {
            //            if (stored == null)
            //                stored = "0";
            //            else
            //                stored = string.Format("{0}{1}", "0", stored);
            //        }
            //        else
            //        {
            //            if (stored == null)
            //                stored = "1";
            //            else
            //                stored = string.Format("{0}{1}", "1", stored);
            //        }
            //        x = x / 2;
            //    }
            //    Console.WriteLine(stored);
            //}
            //else
            //{
            //    Console.WriteLine("invalid input");
            //}
            #endregion

            #region 17
            ////(y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1) ==> get this equation from GPT
            //Console.WriteLine("enter first points");
            //bool one = int.TryParse(Console.ReadLine(), out int x1);
            //bool two = int.TryParse(Console.ReadLine(), out int y1);
            //Console.WriteLine("enter second points");
            //bool three = int.TryParse(Console.ReadLine(), out int x2);
            //bool four = int.TryParse(Console.ReadLine(), out int y2);
            //Console.WriteLine("enter first point");
            //bool fifth = int.TryParse(Console.ReadLine(), out int x3);
            //bool six = int.TryParse(Console.ReadLine(), out int y3);

            //bool full_result = one == two == three == four == fifth == six;
            //Console.WriteLine(full_result switch
            //{
            //    true when (y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1) => "these points lie on a single straight line",
            //    true when (y2 - y1) * (x3 - x2) != (y3 - y2) * (x2 - x1) => "these points dont lie on a single straight line",
            //    _ => "invaild input"
            //});
            #endregion

            #region 18
            //Console.WriteLine("enter task time..");
            //bool result = double.TryParse(Console.ReadLine(), out double task_time);
            //Console.WriteLine(result switch
            //{
            //    true when task_time >= 2 && task_time <= 3 => $"Highly efficient",
            //    true when task_time >= 3 && task_time <= 4 => $"instructed to increase their speed",
            //    true when task_time >= 4 && task_time <= 5 => $"provided with training to enhance their speed",
            //    true when task_time > 5  => $"leave the company",
            //    _ => "not valid"
            //});
            #endregion
        }
    }
}
