using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Прямая_последовательность_действий
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свою фамилию: ");
            string surname1 = Console.ReadLine();
            Console.WriteLine("Введите свое имя: ");
            string name1 = Console.ReadLine();
            Console.WriteLine("Введите возраст в годах: ");
            int age_years1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите возраст в месяцах: ");
            int age_months1 = Convert.ToInt32(Console.ReadLine());
            int age_sec1 = (age_months1 * 30 * 24 * 60 * 60) + (age_years1 * 365 * 24 * 60 * 60);


            Console.WriteLine("Введите свою фамилию: ");
            string surname2 = Console.ReadLine();
            Console.WriteLine("Введите свое имя: ");
            string name2 = Console.ReadLine();
            Console.WriteLine("Введите возраст в годах: ");
            int age_years2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите возраст в месяцах: ");
            int age_months2 = Convert.ToInt32(Console.ReadLine());
            int age_sec2 = (age_months2 * 30 * 24 * 60 * 60) + (age_years2 * 365 * 24 * 60 * 60);

            Console.WriteLine("Введите свою фамилию: ");
            string surname3 = Console.ReadLine();
            Console.WriteLine("Введите свое имя: ");
            string name3 = Console.ReadLine();
            Console.WriteLine("Введите возраст в годах: ");
            int age_years3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите возраст в месяцах: ");
            int age_months3 = Convert.ToInt32(Console.ReadLine());
            int age_sec3 = (age_months3 * 30 * 24 * 60 * 60) + (age_years3 * 365 * 24 * 60 * 60);
            Console.WriteLine($"{surname1,15} {name1,15} {age_sec1,20}");
            Console.WriteLine($"{surname2,15} {name2,15} {age_sec2,20}");
            Console.WriteLine($"{surname3,15} {name3,15} {age_sec3,20}");
            Console.ReadKey();

        }
    }
}
