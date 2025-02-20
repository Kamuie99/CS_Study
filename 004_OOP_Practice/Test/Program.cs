using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Car
    {
        private int speed;
        private static int count = 0;

        public Car()
        {
            count++;
        }

        public static int GetCount()     // 클래스 메서드
        {
            return count;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("현재 생산된 자동차 숫자 => {0}", Car.GetCount());

            Car myCar1 = new Car();
            Console.WriteLine("현재 생산된 자동차 숫자 => {0}", Car.GetCount());
        }
    }

}
