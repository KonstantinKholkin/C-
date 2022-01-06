using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
 * Задание:
 * Даны два числа. Показать большее и меньшее число
 * 
 * Выполнил: Холкин Константин Юрьевич
 */
namespace ex._2
{
    class MyClass
    {
        int a;
        int b;
       
        public void Input()//Метод для запроса числа
        {
            Console.Write("Введите первое целое число:");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введите второе целое число:");
            b = int.Parse(Console.ReadLine());

        }
        public void Print()//Вывод результата 
        {
            if (a > b)//если число а больше b, то выводим
            {
                Console.Write($"MAX = {a}, MIN = {b}");
            }
            else if (a < b)//если число b больше а, то выводим
            {
                Console.Write($"MAX = {b}, MIN = {a}");

            }
            else
            {
                Console.Write("Числа равны");
            }

        }
    }
}
