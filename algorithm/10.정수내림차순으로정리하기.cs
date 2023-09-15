using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution10
{
    public long solution10(long n)
    {
        char[] arr = n.ToString().ToCharArray();
        Array.Sort(arr);
        Array.Reverse(arr);
        long answer = Convert.ToInt64(new string(arr));

        return answer;
    }
}