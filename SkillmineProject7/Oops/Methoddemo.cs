using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject7.Oops
{
    class Methoddemo
    {
        public void Show()
        {
            Console.WriteLine("Helloo");
        }
        
        public void Addition(int x,float y)
        {
            float ans = x + y;
            Console.WriteLine("ans=" + ans);

        }
        public int Sumoffactor(int n)
        {
            int sum = 0;
            for (int i = 1; i <=n; i++)
            {
                if (n%i==0)
                {
                    sum = sum + i;
                }

            }
            return sum;
        }
        public int AreaofCircle(int r,double pi)
        {
            double area = pi * r * r;
            return (int)area;

        }
        public int FindCube()
        {
            int num1 = 3;
            return (num1 * num1 * num1);
        }

        static void Main(string[] args)
        {
            Methoddemo A = new Methoddemo();
            A.Show();
            A.Addition(5, 3.4f);
            Console.WriteLine(A.Sumoffactor(12));
            Console.WriteLine(A.FindCube());
            Console.WriteLine(A.AreaofCircle(4, 3.14));

        }
    }
    
}
