using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student("Mesud",3, "masudjm@code.edu.az ", 531 , " mathematics ","ADNSU ");
            Console.WriteLine(stu1.Info());
        }
    }
}
