using System;
using System.Linq;

namespace practise
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task2
            //int[] numarr = { 2, 15, 45, 36, 125, 456, 7, 64, 87, 348, 999 };
            //for (int i = numarr.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(numarr[i]);
            //}
            #endregion
            #region Task3

            //int[] x = { 7, 20, 36, 58 };
            //int[] y = { 22, 71, 85, 276 };

            //var z = new int[x.Length + y.Length];
            //x.CopyTo(z, 0);
            //y.CopyTo(z, x.Length);

            //Array.Sort(z);

            //for (int i = z.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(z[i]);
            //}
            #endregion
            #region task4
            //int[] num = { 10, 6, 48, 125, 459 };
            ////int min = num[0];
            ////int max = num[0];
            ////for (int i = 0; i < num.Length; i++)
            ////{
            ////    if (num[i]>max)
            ////    {
            ////        max = num[i];
            ////    }
            ////    else if(min>num[i])
            ////    {
            ////        min = num[i];
            ////    }

            ////}
            ////Console.WriteLine(max);
            //Console.WriteLine(min);
            #endregion
            #region task5
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var arr1 = new int[arr.Length];
            var arr2 = new int [arr.Length];

            for (int i = 0,j=0,b=0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    arr1[j] = arr[i];
                    j++;
                }

                else
                {
                    arr2[b] = arr[i];
                    b++;
                }
                Console.WriteLine();

                 
            }

            #endregion

            #region task4-2   
            //string word = "SALAM      CODE    ahgsjgd        Academy     ";
            //int count = 0;
            //string[] arr = word.Split(" ");
            //foreach (string item in arr)
            //{
            //    if (item != "")
            //    {
            //        count++;
            //    }
            //}

            //Console.WriteLine(count);
            #endregion

            #region task5
            //string cumle = "Code academy code cOde program CODE code cOde";
            //string[] sozarr = cumle.Split(" ");
            //string search = "code";
            //int count = 0;

            //foreach (var item in sozarr)
            //{
            //    if (item.ToLower() == search)
            //    {
            //        count++;
            //    }

            //}
            //Console.WriteLine(count);
            #endregion


            #region task3-1
            //int[] arr = { 123, 5, 25, 478, 68 };
            //int res = 0;
            //int res2 = 0;
            //int ferq = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (99 < arr[i] &&  arr[i]<999)
            //    {
            //        res = res + arr[i];
            //    }
            //    else
            //    {
            //        res2 = res2 + arr[i];
            //    }

            //}
            //ferq = res - res2;

            //Console.WriteLine(ferq);

            #endregion

           
        }
    }
}