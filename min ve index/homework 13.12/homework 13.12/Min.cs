using System;
using System.Collections.Generic;
using System.Text;

namespace homework_13._12
{
    class Min
    {
        public void Find(int [] arr)
        {
            int min = arr[0];
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
              if (min > arr[i])
                {
                    min = arr[i];
                    index = i;
                }
            }
            Console.WriteLine($"en kicik eded {min}");
            Console.WriteLine($"en kicik ededin index-{index}" );
        }
    }
}
