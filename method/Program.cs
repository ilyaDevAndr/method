using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method
{
    internal class Program
    {
        static void byeMethod() // обьявляем пустой статический метод
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Good bye!");
            }
        }
        static void helloMethod() // обьявляем пустой статический метод
        {
            // Выводим два раза на экран привет
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Hello!");
            }
        }
        static void Main(string[] args) // главный пустой статический метод
        {
            Console.WriteLine("Козырский Илья");
            byeMethod(); // вызываем метод прощания
            Console.WriteLine(); // пустая строчка
            helloMethod(); // вывзываем метод приветствия
            Console.ReadKey(); // задержка монитора
        }


    }
}

