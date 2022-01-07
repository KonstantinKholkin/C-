using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
 * Задание:
 * Написать программу вычисления значения функции y = f(a).
 * 
 * Выполнил: Холкин Константин Юрьевич
 */
namespace ex._5
{
    internal class MyClass
    {
        double x;
        double k;
        double y;

        public void Input()//Метод для запроса числа
        {
            Console.Write("Введите число:");
            x = double.Parse(Console.ReadLine());
        }
            public void F()//Решение функции
        {
           
            if (Math.Sin(x) < 0)
                k = x * x;
            else
                k = Math.Abs(x);

            if (k < x)
                y = k * x;
            else
                y = k + x;
        }
        public void Print()//Вывод результата 
        {
            
           Console.Write($"{y}");
                      
        }
    }
}
