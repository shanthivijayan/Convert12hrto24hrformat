﻿using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        DateTime dt = Convert.ToDateTime(s);
        String MilitaryDate = dt.ToString("HH:mm:ss");
        return MilitaryDate;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
       
        Console.WriteLine("Enter a Time as a 24 hr Format");
        string s = Console.ReadLine();

        string result = Result.timeConversion(s);
        Console.WriteLine(result);
    }
}
