using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System;

public class Solution16
{
    public int solution(int[] absolutes, bool[] signs)
    {
        int answer = 0;

        for (int i = 0; i < absolutes.Length; i++)
        {
            if (!signs[i])
            {
                absolutes[i] = -absolutes[i];
            }

            answer += absolutes[i];
        }
        return answer;
    }
}