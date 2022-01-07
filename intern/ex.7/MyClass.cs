using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
 * Задание:
 * Показать числа от -N до N.
 * 
 * Выполнил: Холкин Константин Юрьевич
 */
namespace ex._7
{
    class MyClass
    {
        int a;
        int b;
        public void Input()//Метод для запроса чисел
        {
            Console.Write("Введите min целое число:");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введите max целое число:");
            b = int.Parse(Console.ReadLine());
        }
        public void Print()// Вывод используя цикл
        {
            for(int i = 0; i <= (b-a); i++)
            {
                Console.Write($"  {a+i}  ");
            }
        }
    }
}
