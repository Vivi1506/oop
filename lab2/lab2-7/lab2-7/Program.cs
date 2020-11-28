using System;

namespace lab2_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee f1 = new Employee("Viola", "Golovchenko");
            Console.WriteLine("Выбирите вашу должность: 1)офисный работник 2)глава отдела 3)зам. начальника 4)начальник");
            int pos = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите ваш стаж: ");
            int yr = int.Parse(Console.ReadLine());
            f1.Otklad(pos, yr);
            f1.ShowAllInfo();
        }
    }
}
