using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Calculator
{
    public static double CalculateAverage(int[] arr)
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
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5 };

        double avg = Calculator.CalculateAverage(arr);
        Console.WriteLine("평균값: " + avg);
    }
}