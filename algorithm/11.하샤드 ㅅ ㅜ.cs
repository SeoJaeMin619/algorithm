using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution11
{
    public bool solution11(int x)
    {
        bool answer = true;

        int temp_x = x;
        int total_sum = 0;

        double length = Math.Truncate(Math.Log10(temp_x));

        int divide = (int)Math.Pow(10, length);

        for (int i = divide; i > 0; i /= 10)
        {
            total_sum += (temp_x / i);

            temp_x %= i;
        }

        answer = x % total_sum == 0 ? true : false;

        return answer;
    }
}

