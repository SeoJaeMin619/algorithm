using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Solution17
{
    public string solution(string phone_number)
    {
        string answer = ""; //결과를 저장할 빈문자열 선언

        string temp_str = phone_number.Substring(phone_number.Length - 4, 4);

        for (int i = 0; i < phone_number.Length - 4; ++i)
        {
            answer += "*";

        }
        answer += temp_str;
        return answer;
    }
}