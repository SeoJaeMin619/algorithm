using System;
using System.Reflection.Metadata.Ecma335;


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
