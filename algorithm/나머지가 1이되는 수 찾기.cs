using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution5
{
    public int solution5(int n) //정수값 n을 반환
    {
        for (int i = 1; i < n; i++) //for루프를 사용하여 i변수를 1부터 n-1까지 증가시키며 반복
        {
            if (n % i == 1) //if문을 사용 n을 1로 나눈 나머지가 1인지 확인
                return i; //n%1의 결과가 1이라면 i값을 반환하고 메서드 종료
        }
        return -1; //i에 대해 조건을 만족시키지못해 값을 못찾으면 -1반환
    }
} 