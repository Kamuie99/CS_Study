using System;

namespace Programmers
{
    class Test
    {
        public int Calculate(int a, int b) // 계산 메서드
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
            return answer;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Test test = new Test();

            Console.WriteLine("Enter two integers (a and b) separated by a space:");
            string[] input = Console.ReadLine().Split(' '); // 사용자 입력 받기 (공백 기준으로 분리)

            int a = int.Parse(input[0]); // 첫 번째 입력값
            int b = int.Parse(input[1]); // 두 번째 입력값

            int result = test.Calculate(a, b); // Test 클래스의 Calculate 메서드 호출
            Console.WriteLine($"Result: {result}"); // 결과 출력
        }
    }
}
