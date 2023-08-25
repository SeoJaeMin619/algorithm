﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//평균값 구하기 알고리즘
class Calculator
{
    public static double Arr(int[] arr)
    {
        int totalSum = 0;

        foreach (int num in arr)
        {
            totalSum += num; 
        }

        double average = (double)totalSum / arr.Length; 
        return average;
    }
}

class Program
{
    static void Main1(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5 };

        double avg = Calculator.Arr(arr);
        Console.WriteLine("평균값: " + avg);
    }
}