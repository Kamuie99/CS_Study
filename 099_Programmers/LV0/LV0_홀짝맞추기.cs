using System;

namespace Programmers
{
    class LV0_홀짝맞추기
    {
        
        public static void Example()  // 모든 C# 프로그램은 Main 메서드에서 실행을 시작함, 사용 안할때는 다른걸로 변경
        {
            String[] s;  // 문자열 배열 s를 선언, 사용자 입력 데이터를 저장할 공간으로 활용

            Console.Clear();  // 콘솔 화면을 초기화 하는 명령어
            s = Console.ReadLine().Split(' '); // 사용자로부터 입력받은 한줄을 공백으로 나누어 s에 저장

            // Int32.Parse는 문자열을 정수로 변환하는 메서드
            // a는 사용자 입력값을 저장한 배열의 0번째 요소를 int로 변환하여 a에 저장
            int a = Int32.Parse(s[0]);

            if (a % 2 == 1)             // a를 2로 나눈 나머지가 1일 때는
            {
                Console.WriteLine($"{a} is odd");   // a is odd 라는 문장을 출력
            }
            else                       // 그렇지 않은 경우에는
            {
                Console.WriteLine($"{a} is even"); // a is even 라는 문장을 출력
            }
        }
    }
}
