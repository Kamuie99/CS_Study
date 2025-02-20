using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader inFp;
            StreamWriter outFp;
            string inFname, outFname;
            string inStr, outStr;
            string secuYN;
            int secu = 0;

            string filePath = "C:\\Users\\yclee\\Desktop\\250219_실습\\EncryptionApp\\temp\\";

            Console.Write("1. 암호화 2. 암호해석 중 선택 : ");
            secuYN = Console.ReadLine();
            Console.Write("입력 파일명을 입력하세요: ");
            inFname = filePath + Console.ReadLine() + ".txt";
            Console.Write("출력 파일명을 입력하세요: ");
            outFname = filePath + Console.ReadLine() + ".txt";

            if (secuYN == "1")
            {
                secu = 100;
            }
            else if (secuYN == "2")
            {
                secu = -100;
            }

            inFp = new StreamReader(inFname);
            outFp = new StreamWriter(outFname);

            while (true)
            {
                inStr = inFp.ReadLine();
                if (inStr == null)
                    break;

                outStr = "";
                foreach (char ch in inStr)
                {
                    int chNum = (int)ch;
                    chNum += secu;
                    char newCh = (char)chNum;
                    outStr += newCh;
                }
                outFp.WriteLine(outStr);
            }

            inFp.Close();
            outFp.Close();
            Console.WriteLine("{0} --> {1} 변환 완료", inFname, outFname);
        }
    }
}
