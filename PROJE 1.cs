using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILkPROJE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hello, Bob! You have 3 messages in your inbox. The temperature is 34.4 celsius.

            string name = "Bob";
            int messages = 3;
            decimal temparature = 34.4m;

            Console.Write("Hello, ");
            Console.Write(name);
            Console.Write("You have ");
            Console.Write(messages);
            Console.Write(" messages in your inbox. ");
            Console.Write("The Temperature is ");
            Console.Write(temparature);
            Console.Write("cesius");
            Console.ReadLine();

        }
    }
}
