using System;
using System.Runtime.InteropServices;

internal class Program//class
{    //opening of class
    //datatypes
    //long
    //short
    //decimal
    //float
    //how to declare datatypes

    static long p = 7689868678;
    static short i = 8768;
    static decimal n = 9876;
    static float k = 63920;

    //array
    static long[] a = { 67, 09, 767, 908 };
    static short[] y = { 73, 3658, 9102, 9389, 939 };
    static decimal[] d = { 787, 869, 098, };
    static float[] b = { 67, 5465, 097, 5678, 689 };
    private static void Main(string[] args)//method
    {   //opening of your method
        //curly braces{}

        //statement
        Console.WriteLine(i);
        Console.WriteLine(n);
        Console.WriteLine(k);
        Console.WriteLine(p);
        Console.WriteLine("welcome to my world");

        //how to print an array
        foreach (long p in a)
        {
            Console.WriteLine(p);
        }
        foreach (short i in y)
        {
            Console.WriteLine(i);
        }
        foreach (decimal n in d) 
        {
            Console.WriteLine(n);
        }
        foreach (float k in b)
        {
            Console.WriteLine(k);
        }
        Console.WriteLine("Class");

    }//closing of your method

}//closing of your class