using System;

public class Example
{
    public static void Main()
    {
        String s;

        Console.Clear();
        s = Console.ReadLine();

        // ���ڿ�.Length�� ���ڿ� ���̸� ���� �� ����
        for (int i = 0; i < s.Length; i++)
        {
            if (Char.IsUpper(s[i]))
            {
                // Char.ToLower(���ڿ�)�� �빮�ڷ� �ٲ� �� ����
                Console.Write(Char.ToLower(s[i]));
            }
            else
            {
                // Char.ToUpper(���ڿ�)�� �ҹ��ڷ� �ٲ� �� ����
                Console.Write(Char.ToUpper(s[i]));
            }
        }

    }
}