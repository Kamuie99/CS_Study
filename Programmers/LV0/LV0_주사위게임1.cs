using System;

public class Solution
{
    public int solution(int a, int b)
    {
        int answer = 0;
        if (a % 2 == 1 && b % 2 == 1)
        {
            answer = (int)(Math.Pow(a, 2) + Math.Pow(b, 2));
        }
        else if (a % 2 == 1 || b % 2 == 1)
        {
            answer = 2 * (a + b);
        }
        else if (a % 2 == 0 && b % 2 == 0)
        {
            answer = Math.Abs(a - b);
        }
        else
        {
            answer = -1;
        }
        return answer;
    }
}