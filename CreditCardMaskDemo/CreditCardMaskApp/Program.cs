using MaskLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardMaskApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Muskify.MaskCreditCard("4556364607935616"));
            Console.WriteLine(Muskify.MaskCreditCard("64607935616"));
            Console.WriteLine(Muskify.MaskCreditCard("1"));
            Console.WriteLine(Muskify.MaskCreditCard(""));
            Console.WriteLine(Muskify.MaskCreditCard("Skippy"));
            Console.WriteLine(Muskify.MaskCreditCard("Nananananananananananananananana Batman!"));

            // Allow the user to close the application
            Console.ReadLine();
        }
    }
}
