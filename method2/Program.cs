using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method2
{
    internal class Program
    {
        static void Main(string[] args) // главный пустой статический метод
        {
            Console.WriteLine("Козырский Илья");
            showMessage1();
            Console.WriteLine();
            showMessage2();
            Console.ReadKey(); // задержка монитора
        }
        static void showMessage1()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Тарелка");
                Console.WriteLine("Чашка");
                Console.WriteLine("Кастрюля");
                Console.WriteLine("Сковородка");
            }
        }
        static void showMessage2()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Стол");
                Console.WriteLine("Стул");
                Console.WriteLine("Кресло");
                Console.WriteLine("Диван");
            }
        }

    }
}
