using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
 * Задание:
 * По заданному номеру дня недели вывести его название.
 * 
 * Выполнил: Холкин Константин Юрьевич
 */
namespace ex._3
{
    class MyClass
    {
        int a;
      
        public void Input()//Метод для запроса числа
        {
            Console.Write("Введите день недели числом:");
            a = int.Parse(Console.ReadLine());
        }

        public void Dayweek()
        {
            switch (a)// Создаем switch для вывода дня недели
            {
                case 1:Console.WriteLine("Понедельник"); break;
                case 2:Console.WriteLine("Вторник"); break;
                case 3: Console.WriteLine("Среда"); break;
                case 4: Console.WriteLine("Четверг"); break;
                case 5: Console.WriteLine("Пятница"); break;
                case 6: Console.WriteLine("Суббота"); break;
                case 7: Console.WriteLine("Воскресенье"); break;
                default:Console.WriteLine("Такого дня недели не существует."); break;
            }
        }
    }
}
