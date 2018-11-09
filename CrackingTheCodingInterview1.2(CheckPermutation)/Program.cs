using System;

namespace CrackingTheCodingInterview1._2_CheckPermutation_
{
    class Program
    {
        static void Main(string[] args)
        {
            String StringA = "";
            String StringB = "";
            Console.WriteLine("Insert the first word");
            StringA = Console.ReadLine();

            Console.WriteLine("Insert the second word");
            StringB = Console.ReadLine();

            Implementation I = new Implementation();
            I.CheckPermutation(StringA, StringB);


        }
    }
}
