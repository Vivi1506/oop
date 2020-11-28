using System;

namespace LAB4
{
    class Program
    {
        static void Main(string[] args)
        {
            ParentClass p = new ChildClass();
            Console.WriteLine(p.Calculation(3.223, 3.4));
            ChildClass r = (ChildClass)p;
            r.Name = "Viola";
            r.WriteMethod(r.Name, 1.75);
            
        }
 

    }
}
