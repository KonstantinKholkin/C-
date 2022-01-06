using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
 * Задание:
 * Найти максимальное из трех чисел.
 * 
 * Выполнил: Холкин Константин Юрьевич
 */
namespace ex._4
{
    class MyClass
    {
        int a;
        int b;
        int c;

        public void Input()//Метод для запроса числа
        {
            Console.Write("Введите первое число:");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число:");
            b = int.Parse(Console.ReadLine());
            Console.Write("Введите третье число:");
            c = int.Parse(Console.ReadLine());
        }
        public void Print()//Метод для Вывода
        {
            if(a > b && a>c)//Если a больше b и c 
            {
                Console.WriteLine($"Наибольшее число: {a}");
            }
            else if(b > c)//Если b больше с
            {
                Console.WriteLine($"Наибольшее число: {b}");
            }
            else//Если не 1 и не 2, то большее с
            {
                Console.WriteLine($"Наибольшее число: {c}");
            }
        }
    }
}
