using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solutin11
{
    public long solution11(int a, int b)
    {
        long answer = 0;

        if (a < b)
        {
            for (int i = a; i <= b; i++)
            {
                answer += i;
            }
        }
        else
        {
            for (int i = a; i >= b; i--)
            {
                answer += i;
            }
        }

        return answer;
    }
}