using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace individual
{
    class Program
    {
        static void Main(string[] args)
            
        {
            Console.WriteLine("Введите");
            Console.WriteLine("Фамилию:");
            string name1 = Console.ReadLine();
            Console.WriteLine("Должность(П,С,А):");
            string job1 = Console.ReadLine();
            Console.WriteLine("Год рождения:");
            int birthyear1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Оклад(грн):");
            double pay1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Фамилию:");
            string name2 = Console.ReadLine();
            Console.WriteLine("Должность(П,С,А):");
            string job2 = Console.ReadLine();
            Console.WriteLine("Год рождения:");
            int birthyear2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Оклад(грн):");
            double pay2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Фамилию:");
            string name3 = Console.ReadLine();
            Console.WriteLine("Должность(П,С,А):");
            string job3= Console.ReadLine();
            Console.WriteLine("Год рождения:");
            int birthyear3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Оклад(грн):");
            double pay3 = Convert.ToDouble(Console.ReadLine());

            // заголовок таблицы
            Console.WriteLine("----------------------------------------------------------------------|");
            Console.WriteLine(" Отдел кадров                                                         |");
            Console.WriteLine("----------------------------------------------------------------------|");
            // данные
            Console.WriteLine(" Фамилия      | Должность       | Год рождния         |     Оклад(грн)|");
            Console.WriteLine("----------------------------------------------------------------------|");
            Console.WriteLine(" "+name1+"  |  "+job1+"  |  "+birthyear1+"  |  "+pay1+"  |  ");
            Console.WriteLine("----------------------------------------------------------------------|");
            Console.WriteLine(" " + name2 + "  |  " + job2 + "  |  " + birthyear2 + "  |  " + pay2 + "  |  ");
            Console.WriteLine("----------------------------------------------------------------------|");
            Console.WriteLine(" " + name3 + "  |  " + job3 + "  |  " + birthyear3 + "  |  " + pay3 + "  |  ");
            Console.WriteLine("----------------------------------------------------------------------|");
            // примечания
            Console.WriteLine(" П-преподаватель, С-студент, А-аспирант                               |");
            Console.WriteLine("----------------------------------------------------------------------|");





        }
    }
}
