using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
 * Задание:
 * Выяснить является ли число чётным.
 * 
 * Выполнил: Холкин Константин Юрьевич
 */
namespace ex._6
{
    class MyClass
    {
        double a;

        public void Input()//Метод для запроса числа
        {
            Console.Write("Введите число:");
            a = double.Parse(Console.ReadLine());
        }
        public void Print()// Проверка и вывод
        {
            
            if(a % 2 ==0)
            {
                Console.WriteLine("Число четное");
            }
            else
            {
                Console.WriteLine("Число не четное");
            }
        }
    }
}
