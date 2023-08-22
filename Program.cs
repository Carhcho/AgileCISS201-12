using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Cesar Roncancio
//CISS201
//Agile Development
//10/18/2020
namespace dropbox12
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName;
            double studentScore;

            Console.WriteLine("Enter student name: ");
            studentName = Console.ReadLine();
            Console.WriteLine("Enter student score: ");
           
            while (!(double.TryParse(Console.ReadLine(), out studentScore)) || (studentScore < 0) || (studentScore > 100))
            {
                Console.WriteLine("Score must be between 0 and 100, Try again");
            }
            //valid score
            char letterGrade;
            if (studentScore >= 90)
                letterGrade = 'A';
            else if (studentScore >= 80)
                letterGrade = 'B';
            else if (studentScore >= 70)
                letterGrade = 'C';
            else if (studentScore >= 60)
                letterGrade = 'D';
            else
                letterGrade = 'F';
            Console.WriteLine("Name: {0} Grade: {1}", studentName, letterGrade);
            Console.ReadKey();
        }
    }
}
