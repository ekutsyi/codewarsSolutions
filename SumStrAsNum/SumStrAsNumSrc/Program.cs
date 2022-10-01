﻿using System;
using System.Numerics;

class Kata
{
    public static string sumStrings(string a, string b)
    {
        BigInteger result = BigInteger.Parse(a) + BigInteger.Parse(b);
        return result.ToString();
    }
}

class Program
{
    public static void Main()
    {
        Console.WriteLine(Kata.sumStrings("1212234563767373376736736733", "1212234563767373376736736733"));
        Console.WriteLine(Kata.sumStrings("999", "211"));
        Console.WriteLine(Kata.sumStrings("13", "999"));
        Console.WriteLine(Kata.sumStrings("-99", "-9"));
    }
}
