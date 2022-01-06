using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex._0
{
    /* 
     * Задание:
     * Вывести квадрат числа
     * 
     * Выполнил: Холкин Константин Юрьевич
     */
    class MyClass
    {
        int a;
        int result;
        public void Input()//Метод для запроса числа
        {
            Console.Write("Введите целое число:");
            a = int.Parse(Console.ReadLine());
        }

        public void Result()//Вычисление квадрата числа
        {
            result = a * a;
        }
        public void Print()//Вывод результата вычисления
        {
            Console.Write($"Квадрат числа равен: {result}");
        }
    }
}
