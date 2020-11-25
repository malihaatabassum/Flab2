using System;

namespace Flab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c1 = new Calculator();
            Console.WriteLine("Summation : " + c1.Summation(1, 2));

            Console.WriteLine("Subtraction : " + c1.Subtraction(3, 4));

            Console.WriteLine("Multiplication : " + c1.Multiplication(1, 2));

            Console.WriteLine("Division : " + c1.Division(4, 2));

            Scientific c2 = new Scientific();
           
            Console.WriteLine("Root : " + c2.Root(4));

            Console.WriteLine("To the power : " + c2.AtoB(2, 3));
        }