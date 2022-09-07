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
    public static void Main(string[] args)
    {
        var result = diagonalDifference(new List<List<int>>
        {
            new List<int>{ 1,2,3 },
            new List<int>{ 4,5,6 },
            new List<int>{ 9,8,9 }
        }
        );

        Console.WriteLine(result);
    }

    /*
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int diagonalDifference(List<List<int>> arr)
    {
        var a = 0;
        var b = 0;
        for (var i = 0; i < arr.Count; i++)
        {
            a += arr[i][i];
            arr[i].Reverse();
            b += arr[i][i];
        }
        return Math.Abs(a - b);
    }
}