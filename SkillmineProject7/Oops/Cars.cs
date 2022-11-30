using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject7.Oops
{
    class Cars
    {
        int Modelno;
        string Name;
        int Price;
        string colour;

        static void Main(string []args)
        {
            Cars A = new Cars();
            A.Modelno = 1234;
            A.Name = "BMW";
            A.Price = 465641;
            A.colour = "White";
            Console.WriteLine(A.Modelno + "  " + A.Name + "  " + A.Price+"  " + A.colour);
            Cars B = new Cars();
            B.Modelno = 16654;
            B.Name = "Swift";
            B.Price = 465651;
            B.colour = "Black";
            Console.WriteLine(B.Modelno + "  " + B.Name + "  " + B.Price + "  " + B.colour);
            Cars C = new Cars();
            C.Modelno = 87989;
            C.Name = "EnoVa";
            C.Price = 465641;
            C.colour = "White";
            Console.WriteLine(C.Modelno + "  " + C.Name + "  " + C.Price + "  " + C.colour);
        }
    }
}
