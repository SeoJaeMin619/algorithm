using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Solution7
{
    public int[] solution7(long n)
    {
        string a = n.ToString();
        int[] answer = new int[a.Length];
        for (int i = 0; i < a.Length; i++)
        {
            answer[i] = (int)(n % 10);
            n = n / 10;
        }
        return answer;
    }
}
