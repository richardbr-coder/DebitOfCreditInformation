using System;
using static System.Console;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebitOrCreditInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "AccountInformation.txt";

            if (File.Exists(filename))
            {
                // call the GetInformation method and pass it the filename
                WriteLine(filename);
            }
            else
            {
                // if file doesn't exist, print error message
                Console.WriteLine(filename + " does not exist");
            }
        }
    }
    }
}
