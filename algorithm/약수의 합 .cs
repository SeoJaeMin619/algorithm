using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution4
{
    public int solution4(int n)
    {
        int answer = 0;

        // i가 1부터 n/2값이 될때까지 증가시키면서 for문 반복
        for (int i = 1; i <= n / 2; i++)
        {
            if (n % i == 0)
            {
                // 나눠떨어지면 약수이므로 곧장 answer에 더해줌
                answer += i;
            }
        }
        // 마지막으로 자기자신 n을 더해주면서 리턴한다.
        return answer + n;
    }
}
