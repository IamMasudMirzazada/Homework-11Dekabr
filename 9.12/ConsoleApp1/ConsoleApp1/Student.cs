using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Student
    {
        public string Name;
        public int Course;
        public string Email;
        public int Phonenumber;
        public string Subject;
        public string University;

        public Student(string name, int course, string email, int phonenumber, string subject, string university)
        {
            Name = name;
            Course = course;
            Email = email;
            Phonenumber = phonenumber;
            Subject = subject;
            University = university;
        }

        public string Info()
        {
       
            return $" {Name} {Course} {Email}{Phonenumber}{Subject}{University}";
        }
    }
}
