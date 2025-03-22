using System;

namespace _3_lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            //short
            Console.WriteLine("Variable: short (int16)");
            System.Console.WriteLine(typeof(short));
            System.Console.WriteLine("Short min value: " + short.MinValue);
            System.Console.WriteLine("Short max value: " + short.MaxValue);
            System.Console.WriteLine("Short value of data: " + sizeof(short));

            //int
            Console.WriteLine("Variable: int (int32)");
            System.Console.WriteLine(typeof(int));
            System.Console.WriteLine("Int min value: " + int.MinValue);
            System.Console.WriteLine("Int max value: " + int.MaxValue);
            System.Console.WriteLine("Int value of data: " + sizeof(int));

            //long
            Console.WriteLine("Variable: long (int64)");
            System.Console.WriteLine(typeof(long));
            System.Console.WriteLine("Long min value: " + long.MinValue);
            System.Console.WriteLine("Long max value: " + long.MaxValue);
            System.Console.WriteLine("Long value of data: " + sizeof(long));

            //float
            Console .WriteLine("Variable: float (float32)");
            System.Console.WriteLine(typeof(float));
            System.Console.WriteLine("Float min value: " + float.MinValue);
            System.Console.WriteLine("Float max value: " + float.MaxValue);
            System.Console.WriteLine("Float value of data: " + sizeof(float));

            //double
            Console.WriteLine("Variable: double (float64)");
            System.Console.WriteLine(typeof(double));
            System.Console.WriteLine("Double min value: " + double.MinValue);
            System.Console.WriteLine("Double max value: " + double.MaxValue);
            System.Console.WriteLine("Double value of data: " + sizeof(double));

            //decimal
            Console.WriteLine("Variable: decimal (float128)");
            System.Console.WriteLine(typeof(decimal));
            System.Console.WriteLine("Decimal min value: " + decimal.MinValue);
            System.Console.WriteLine("Decimal max value: " + decimal.MaxValue);
            System.Console.WriteLine("Decimal value of data: " + sizeof(decimal));
        }
    }
}


