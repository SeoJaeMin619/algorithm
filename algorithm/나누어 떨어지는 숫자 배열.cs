using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;

public class Solution15
{
    public int[] solution(int[] arr, int divisor)
    {

        int[] answer;
        List<int> list = new List<int>();

        //배열 arr크기만큼 반복하여 divisor로 나누어 떨어지는지 확인 하고 떨어진다면 list에 추가
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % divisor == 0) list.Add(arr[i]);
        }
        //만약 리스트 갯수가 0이 아니면
        if (list.Count != 0)
        {
            //리스트 정렬 후 배열화 하여 answer에 대입
            list.Sort();
            answer = list.ToArray();
        }
        //리스트 갯수가 0이면
        else
        {
            //answer -1로 초기화
            answer = new int[] { -1 };
        }
        return answer;
    }
}