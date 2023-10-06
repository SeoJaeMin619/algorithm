using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution18

{
    public int solution(int[] numbers)
    {
        int answer = 0;

        for (int i = 0; i < 10; i++)
        {
            answer += i;
        }

        foreach (var data in numbers)
        {
            answer -= data;
        }

        return answer;
    }
}
