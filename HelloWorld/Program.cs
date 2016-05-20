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
                                
            Console.WriteLine("Values: " + a + ", " + b + ";");            
            string str = "TestString";
            Console.WriteLine(str + (b + a));

            double x = 1 + 0.5;
            Console.WriteLine(x);

            //вызов функции
            
            Console.WriteLine("Y_const = " + y(4, 1, 2));
            
            Console.WriteLine("Y1_const = "+ y1(4, 1, 2));
          
            Console.WriteLine("Y2_const = "+ y2(4, 1, 2));
           
            Console.WriteLine("Y3_const = "+ y3(4, 1, 2));

            //циклы
            for (int i = -10; i < 10; i++)
            {
                Console.WriteLine("Y [" + i +  "] = " + y(4,1,2));
                Console.WriteLine("Y1 [" + i + "] = " + y1(i));
                Console.WriteLine("Y2 [" + i + "] = " + y2(i));
                Console.WriteLine("Y3 [" + i + "] = " + y3(i));

            }
            Console.ReadKey();
        }

        private static string y1(int v1, int v2, int v3)
        {
            throw new NotImplementedException();
        }

        private static string y2(int v1, int v2, int v3)
        {
            throw new NotImplementedException();
        }

        private static string y3(int v1, int v2, int v3)
        {
            throw new NotImplementedException();
        }

        static int y (int x, int k, int b)
        {
            return k * x + b;
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
