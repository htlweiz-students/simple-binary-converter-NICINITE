using System;
using Mylibrary;

namespace Programm
{
    class Program{
        public static int Main() {
            Console.WriteLine("___Binary-to-dezimal-converter___");
            Console.Write("Please enter a binanry code: ");
            string? binary_code = Console.ReadLine();

            double result = Binary.Todezimal(binary_code);
            Console.WriteLine(result);
            return 0;
        }
    }
}