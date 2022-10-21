using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Козырский Илья ");
            Console.WriteLine(getSum()); // вывод на экран метода получения суммы
            Console.ReadKey(); // задержка экрана
        }
        static int getSum() // пустой целочисленный метод
        {
            int sum = 0; // инициализация переменной суммы равна 0
            Console.Write("Введите начальное значение: "); // вывод на экран
            int A = Convert.ToInt32(Console.ReadLine()); // считывание, конвертирование и инициализация переменной
            Console.Write("Введите конечное значение: "); // вывод на экран
            int B = Convert.ToInt32(Console.ReadLine()); // считывание, конвертирование и инициализация переменной
            for (; A <= B; A++) // цикл для A до B, A++
            {
                sum += A; // находим сумму в диапазоне от A до B
            }
            return sum; // оператор возврата суммы
        }

    }
}
