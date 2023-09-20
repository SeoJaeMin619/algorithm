using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution13
{
    public int solution(long num)
    {
        int answer = 0;

        if (num == 1) return 0;

        for (int i = 0; i < 500; i++)
        {
            answer++;

            if (num % 2 == 0) num = num / 2;
            else num = num * 3 + 1;

            if (num == 1) return answer;
        }
        return -1;
    }
}