using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string firstName;
            //string lastName;
            // Console.WriteLine("Enter the first name");
            //firstName = Console.ReadLine();
            //Console.WriteLine("Enter the last name");
            //lastName = Console.ReadLine();
            //Console.WriteLine("Weicome Mr. \\Ms.");
            //Console.ReadKey();
            string name;
            int age;
            char grade;
            DateTime doj;
            double salary;
            Console.WriteLine("enter name");
            name = Console.ReadLine();
            Console.WriteLine("enter age");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("enter grade");
            grade = char.Parse(Console.ReadLine());
            Console.WriteLine("enter doj");
            doj = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("enter salary");
            salary = double.Parse(Console.ReadLine());
            Console.WriteLine("name : \t" + name + "\n age: " + age + "\n grade: \t" + grade + "\n salary: \t" + salary + "\n Date of joining: \t " + doj);


            Console.ReadKey();










        }
    }
}
