//Given an array of integers, calculate the fractions of its elements that are positive, negative, and are zeros. Print the decimal value of each fraction on a new line.


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


namespace plusMinus
{
  class Solution {

    // Complete the plusMinus function below.
    static void plusMinus(int[] arr) {
        double positiveNums = 0;
        double negativeNums = 0;
        double zeroes = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0)
            {
                positiveNums++;
            }
            else if (arr[i] < 0)
            {
                negativeNums++;
            }
            else
            {
                zeroes++;
            }
        }

        Console.WriteLine(positiveNums/arr.Length);
        Console.WriteLine(negativeNums/arr.Length);
        Console.WriteLine(zeroes/arr.Length);

    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        plusMinus(arr);
    }
}

}
