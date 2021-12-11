using System;
using System.Collections.Generic;
using System.Text;

namespace _2quvveti
{
    class Quvvet
    {
        public void Yoxlama (int a)
        {
            int quvvet = 2;
            while (a % quvvet == 0)
            {

                a = a / quvvet;
            }
            if(a==1)
            {
                Console.WriteLine("2nin quvvetidir");
            }
            else
            {
                Console.WriteLine("2nin quvveti deyil");
            }
        }
        

	
    }
}
