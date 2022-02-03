using System.CodeDom.Compiler;
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
     * Complete the 'kangaroo' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. INTEGER x1
     *  2. INTEGER v1
     *  3. INTEGER x2
     *  4. INTEGER v2
     */

    /// <summary>
    /// Algorithm compares movement of two paths [x = x0 + v * t]
    /// Both paths intersect at the same distance x:
    /// x01 + v1 * t = x02 + v2 * t
    /// and at the same time:
    /// t = (x01 - x02) / (v2 - v1)
    /// the time component t has to be whole number and positive.
    /// </summary>
    public static string kangaroo(int x1, int v1, int x2, int v2)
    { 
        double dx1 = x1;
        double dx2 = x2;
        double dv1 = v1;
        double dv2 = v2;

        if (dv2 - dv1 != 0)
        {
            if ((dx1 - dx2) / (dv2 - dv1) >= 0 &&
                ((dx1 - dx2) / (dv2 - dv1) == (int)((dx1 - dx2) / (dv2 - dv1))))
            {
                return "YES";
            }
            return "NO";
        }
        if (dx1 == dx2) 
        {
            return "YES";
        }
        return "NO";
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int x1 = Convert.ToInt32(firstMultipleInput[0]);

        int v1 = Convert.ToInt32(firstMultipleInput[1]);

        int x2 = Convert.ToInt32(firstMultipleInput[2]);

        int v2 = Convert.ToInt32(firstMultipleInput[3]);

        string result = Result.kangaroo(x1, v1, x2, v2);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
