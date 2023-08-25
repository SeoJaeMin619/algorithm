using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//평균값 구하기 알고리즘
class Calculator
{
    public static double Arr(int[] arr)
    {
        int totalSum = 0; // 배열 요소들의 합을 저장할 변수 초기화

        foreach (int num in arr) // 배열의 각 요소를 순회하며 값을 더함
        {
            totalSum += num;  // 현재 요소 값을 합산
        }

        double average = (double)totalSum / arr.Length; 
        return average;  // 평균값 반환
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