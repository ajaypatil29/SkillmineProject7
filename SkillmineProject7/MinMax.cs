using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject7
{
    class MinMax
    {
        static int MinMax1(int[] a)
        {
            int max = a[0];
            int min = a[0];
            for (int i = 0; i <a.Length; i++)
            {
                if (max>a[i])
                {
                    max = a[i];
                }
                /*else if (min<a[i])
                {
                    min = a[i];
                }*/

            }
            return max;
           /* return min;*/

        }
        static void Main(string []args)
        {
            int[] arr = { 5, 9, 56, 6898, 12, 22, -84, 1 };
            MinMax b = new MinMax();
            /*MinMax c = new MinMax();*/
            
        }

    }
}
