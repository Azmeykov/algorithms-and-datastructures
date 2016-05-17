using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        private static int i;

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
            int a, b, d;  // Объявление двух переменных
            string buff = Console.ReadLine(); // Создание переменной buff 
                                              // и передача ей значения введенного из консоли
            a = Convert.ToInt16(buff); // Конвертирование строки в инт переменную
            Console.WriteLine("a: " + a); // Вывод значения в консоль
            
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

            //вызов функции
            c = y(4);   
            Console.WriteLine("Y_const = " + c);
            c = y1(4);
            Console.WriteLine("Y1_const = " + c);
            c = y2(4);
            Console.WriteLine("Y2_const = " + c);
            c = y3(4);
            Console.WriteLine("Y3_const = " + c);

            //циклы
            for (int i = -10; i < 10; i++)
            {
                Console.WriteLine("Y " + i + " = " + y(i));
                Console.WriteLine("Y1 " + i + " = " + y1(i));
                Console.WriteLine("Y2 " + i + " = " + y2(i));
                Console.WriteLine("Y3 " + i + " = " + y3(i));
            }
            Console.ReadKey();
        }

        static int y (int x)
        {
            return x + 2;
        }
        static int y1 (int x)
        {
            return 2 * x + 4;
        }
        static int y2 (int x)
        {
            return -3 * x -5;
        }
        static int y3 (int x)
        {
            return -8 * x + 1;
        }
        
        

    }
}
