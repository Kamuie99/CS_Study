using System;

namespace Programmers
{
    class LV0_문자열붙이기
    {
        public static void Main()  // 모든 C# 프로그램은 Main 메서드에서 실행을 시작함, static으로 선언되었기에 인스턴스 생성 불필요
        {
            string[] input;   // input 이름의 문자열 배열 선언

            Console.Clear();  // 콘솔 초기화
            input = Console.ReadLine().Split(' ');  // 공백으로 구분하여 input 배열에 입력값 저장

            String s1 = input[0];  // 배열 0번째 요소를 s1에 저장
            String s2 = input[1];  // 배열 1번째 요소를 s2에 저장

            Console.WriteLine($"{s1}{s2}");
        }
    }
}
