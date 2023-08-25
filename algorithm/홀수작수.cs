using System;
using System.Reflection.Metadata.Ecma335;


//홀수짝수 알고리즘
public class Solution 
    {
        public string solution(int num)
        {
            if (num % 2 == 0)
                return "Even";
            else
                return "Odd";
        }
    }
 

class 홀수작수 //chat GPT를 이용함
{
    static void Main(string[] args)
    {
        Solution solutionInstance = new Solution();

        int myNumber = 8; // 원하는 숫자를 설정하세요
        string result = solutionInstance.solution(myNumber);

        Console.WriteLine("Result: " + result);
    }
}
