using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наследование.Полеоморфизм2
{
    class Program
    {
        public class BaseConverter
        {
            public int temp;
            public int kel;
            public float far;

            public int Temp { get { return temp; } set { temp = value; } }
            public int Kel { get { return kel; } set { kel = value + 273; } }
            public float Far { get { return far; } set { far = value * 9 / 5 + 32; } }

            public void Info()
            {
                Console.WriteLine($"В Цельсиях: {temp}, В Кельвинах: {kel}, В Фаренгейтах: {far}");
            }
        }
        static void Main(string[] args)
        {
            BaseConverter t = new BaseConverter();
            t.Temp = 50;
            t.Kel = 50;
            t.Far = 50;
            t.Info();


            Console.ReadLine();
        }
    }
}
