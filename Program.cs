using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Боровинских Алексей Сергеевич";
            string email = "Zianeed@gmail.com";
            int age = 38;
            int scoreForPhysics = 5;
            int scoreForMath = 4;
            int scoreForProgramming = 3;

            int scoreSum = scoreForPhysics + scoreForMath + scoreForProgramming;
            int averageScore = scoreSum / 3;

            string patern = "Ф.И.О: {0} \nEmail: {1} \nВозраст: {2} \nБал по Физике: {3} \nБал по Математике: {4} \nБал по Программированию: {5}";

            Console.WriteLine(patern, fullName, email, age, scoreForPhysics, scoreForMath, scoreForProgramming);
            Console.ReadKey();

            Console.WriteLine($"Средний балл: {averageScore}");
            Console.ReadKey();
        }
    }
}
