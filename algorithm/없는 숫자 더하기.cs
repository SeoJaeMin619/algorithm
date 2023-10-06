using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution18

{
    public int solution(int[] numbers)
    {
        int answer = 0;

        for (int i = 0; i < 10; i++)  //0부터 9까지의 숫자를 반복적으로 처리하는 반복문입니다.
                                      //i 변수가 0부터 9까지 증가하면서 아래의 코드 블록을 실행합니다.
        {
            answer += i; //0부터 9까지 숫자를 더한 결과가 answer변수에 저장
        }

        foreach (var data in numbers) //배열 numners를 반복적으로 처리하는 반복분
                                      //var data는 배열 numbers의 각 요소를 나타내는 변수

        {
            answer -= data; //answer 변수에서 data값을 뺌
        }

        return answer;  //0부터 9까지의 숫자를 모두 더한 후, 배열 numbers의 모든 요소를 뺀 결과
    }
}
