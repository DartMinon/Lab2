using System;

namespace Lab2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько ворон на ветке?:");
            try
            {
                int a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        Console.WriteLine("На ветке " + a + " Ворона");
                        break;
                    case 2:
                    case 3:
                    case 4:
                        Console.WriteLine("На ветке " + a + " Вороны");
                        break;
                    case 0:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                        Console.WriteLine("На ветке " + a + " Ворон");
                        break;
                }
                if (a > 9)
                { Console.WriteLine("На ветке " + a + " Ворон"); }

            }
            catch (Exception)
            {
                Console.WriteLine("Введите количесво целым числом");
            }
            
        }
    }
}
