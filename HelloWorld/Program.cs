using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Press any key to exit.");

            //ввод 2-х чисел и вывод суммы
            //найти типы данных для C#
            //объявить целочисленную переменную
            //ввести в переменную a и b значения
            //сложить а и b
            //сохранить результат в третью переменную
            //вывести результат на экран
            int a, b;
            string buff = Console.ReadLine();
            a = Convert.ToInt16(buff);
            Console.WriteLine("a: " + a);
            buff = Console.ReadLine();
            b = Convert.ToInt16(buff);
            Console.WriteLine("b: " + b);
            //TODO: Написать ввод третьего значения d;
            //TODO: Вывести сумму трех значений;

            int c = a;
            a = b;
            b = c;

            Console.WriteLine("Values: " + a + ", " + b + ";");            
            string str = "TestString";
            Console.WriteLine(str + (a + b));

            double x = 1 + 0.5;
            Console.WriteLine(x);


            Console.ReadKey();
        }
        
    }
}
