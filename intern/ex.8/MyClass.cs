using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex._8
{
    class MyClass
    {
        double a = 1;
        double b;
        public void Input()//Метод для запроса чисел
        {
            Console.Write("Введите число:");
            b = double.Parse(Console.ReadLine());
        }
        public void Print()// Вывод используя цикл
        {
            for (int i = 0; i <= (b - a); i++)//цикл запускает счет от a до b
            {
                if ((a+i) % 2 == 0) // если число четное выводим его
                {
                    Console.Write($"  {a + i}  ");
                }
                
            }
        }
    }
}
