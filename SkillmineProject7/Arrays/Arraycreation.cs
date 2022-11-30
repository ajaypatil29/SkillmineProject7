using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject7.Arrays
{
    class Arraycreation
    {
        static void Main(string []args)
        {
            int[] arr = { 5, 3, 2, 8 };
            int[] myarray = new int[4];
            myarray[0]=1;
            myarray[1] = 5;
            myarray[2] = 8;
            myarray[3] = 7;

            Console.WriteLine("Enter the array element");
            for (int i = 0; i < myarray.Length ; i++)
            {
                myarray[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < myarray.Length; i++)
            {
                Console.WriteLine(myarray[i]);
            }
            foreach(int element in myarray )
            {
                Console.WriteLine(element);
            }
            Console.WriteLine(string.Join(" ", myarray));
        }
    }
}
