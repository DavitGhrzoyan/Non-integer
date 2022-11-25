using System;

namespace Non_integer
{
    class Program
    {
        static void Main(string[] args)
        {

            //   Non - Integer(Floating Point) Data Types

            // Type      Description                   Scale                               Precision              Bits

            //float      Single Precision Number 	    ±1.5x10 - 45 to ±3.4x1038           7 digits               32
            //double     Double Precision Number	    ±5x10 - 324 to ±1.7x10308           15 or 16 digits        64
            //decimal    Decimal Number                ±10 - 28 to ±7.9x1028               28 or 29 digits        128

            float f = 1.23456789f;   
            Console.WriteLine(f);

            double d = 1.2345678912345678;
            Console.WriteLine(d);

            decimal money = 105.123456789222222m;
            Console.WriteLine(money); 

























        }
    }
}
