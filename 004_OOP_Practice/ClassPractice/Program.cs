using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice
{
    class Calc
    {
        public void addValue(double v1, double v2)
        {
            Console.WriteLine("double 계산 -> {0}", (v1 + v2));
        }
        public void addValue(int v1, int v2)
        {
            Console.WriteLine("int 계산 -> {0}", (v1 + v2));
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Calc myCalc = new Calc();

            myCalc.addValue(1.1, 1.1);
            myCalc.addValue(1, 1);
        }
    }


}
