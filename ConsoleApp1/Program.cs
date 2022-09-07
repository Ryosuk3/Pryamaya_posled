using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] surnames = new string[3];
            string[] names = new string[3];
            int[] age_years = new int[3];
            int[] age_months = new int[3];
            int[] age_sec = new int[3];
            for (int i = 0; i<3; i++)
            {
                Console.Write("Введите свою фамилию: ");
                surnames[i] = Console.ReadLine();
                Console.Write("Введите свое имя: ");
                names[i] = Console.ReadLine();
                Console.Write("Введите возраст в годах: ");
                age_years[i] = Convert.ToInt32(Console.ReadLine());
                if (age_years[i]<0)
                {
                    while (age_years[i]<0)
                    {
                        Console.Write("Введен некорректный возраст, введите допустимое значение: ");
                        age_years[i] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                Console.Write("Введите возраст в месяцах: ");
                age_months[i] = Convert.ToInt32(Console.ReadLine());
                if (age_months[i]<1 | age_months[i]>12)
                {
                    while (age_months[i]<1 | age_months[i]>12)
                    {
                        Console.Write("Введен некорректный возраст в месяцах, введите допустимое значение: ");
                        age_months[i] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                age_sec[i] = (age_years[i] * 365 * 24 * 60 * 60) + (age_months[i] * 30 * 24 * 60 * 60);
                Console.WriteLine("                ");
            }
            Console.WriteLine("        ");
            for (int j = 0; j<3; j++)
            {
                Console.WriteLine($"{surnames[j],15} {names[j],15} {age_sec[j],20}");
            }
            Console.ReadKey();
        }
    }
}
