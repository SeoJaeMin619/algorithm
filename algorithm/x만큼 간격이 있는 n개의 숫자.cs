using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution6
{
    public long[] solution6(int x, int n)
    {
        long[] answer = new long[n];

        for (int i = 0; i < n; i++)
        {
            if (i == 0)
                answer[i] = x;
            else
                answer[i] = x + answer[i - 1];
        }

        return answer;

    }
}
