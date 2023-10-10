using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
public class Solution19
{
    public int[] solution(int[] arr)
    {
        //배열의 길이가 하나라면 해당 배열을 -1로 초기화 후 리턴
        if (arr.Length == 1) { arr[0] = -1; return arr; }

        //가장 작은 수를 제거하기 위한 배열 첫 번째 수를 temp 변수에 대입
        int temp = arr[0];

        //0부터 배열 크기 까지 반복하면서 가장 작은 수를 판별
        for (int i = 0; i < arr.Length; i++)
        {
            if (temp > arr[i]) temp = arr[i];
        }
        //리스트 선언        
        List<int> list = new List<int>();
        //리스트에 배열 넣기
        list.AddRange(arr);
        //리스트 중 가장 작은수 temp 제거
        list.Remove(temp);

        //answer 선언 후 리스트 배열화 해서 리턴
        int[] answer = new int[] { };
        answer = list.ToArray();
        return answer;
    }
}