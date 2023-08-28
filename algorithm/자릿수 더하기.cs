using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution3
{
    public int solution(int n)
    {
        int answer = 0;
        //정수 n을 String형으로 변환 후 CharArray로 변환
        char[] arr = n.ToString().ToCharArray();

        //반복문을 통해 각 해당 문자를 int형으로 바꾸어 answer에 더해줌.
        foreach (char a in arr)
        {
            answer += System.Convert.ToInt32(a.ToString());
        }
        return answer;
    }
}