using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
 * Задание:
 * По двум заданным числам проверять является ли первое квадратом второго
 * 
 * Выполнил: Холкин Константин Юрьевич
 */
namespace ex._1
{

    class MyClass
    {
        int a;
        int b;
        int result;
        public void Input()//Метод для запроса числа
        {
            Console.Write("Введите первое целое число:");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введите второе целое число:");
            b = int.Parse(Console.ReadLine());

        }

        public void Result()//Вычисление квадрата числа а
        {
            result = a * a;
        }
        public void Print()//Вывод результата вычисления
        {
            if (result == b)//если квадрат числа а равен b, то выводим
            {
                Console.Write("второе число является квадратом первого числа");
            }
            else//если нет, то выводим
            {
                Console.Write("второе число  не является квадратом первого числа");

            }
           
        }
    }
}
