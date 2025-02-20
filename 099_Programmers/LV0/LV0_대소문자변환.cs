using System;

public class Example
{
    public static void Main()
    {
        String s;

        Console.Clear();
        s = Console.ReadLine();

        // 문자열.Length로 문자열 길이를 구할 수 있음
        for (int i = 0; i < s.Length; i++)
        {
            if (Char.IsUpper(s[i]))
            {
                // Char.ToLower(문자열)로 대문자로 바꿀 수 있음
                Console.Write(Char.ToLower(s[i]));
            }
            else
            {
                // Char.ToUpper(문자열)로 소문자로 바꿀 수 있음
                Console.Write(Char.ToUpper(s[i]));
            }
        }

    }
}