using System;

namespace LAB2._1OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n**************************\n");
            Console.WriteLine("X\t        Y\n");
            Console.WriteLine("**************************\n");

            double y = 0;
            for (double x = 0;x<6;x+=0.5)
            {
               
              y = 1 / (1 - Math.Sqrt(x));
                   if(x==1)
                {
                    
                    y = 0;
                    Console.Write("(Divided by zero exception y=Infinity)");
                }
                Console.WriteLine(" x={0} y={1}", x, y);
               }

        }
    }
}
