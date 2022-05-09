using System;
using System.Collections.Generic;
using System.Text;

namespace LenderApi_Tests
{
    public partial class Program
    {
        static void TokenTest()
        {
            Console.Clear();
            Console.WriteLine("This test requires waiting for 30 minutes.   Do you want to continue?");
            if (Console.ReadLine().ToUpper().StartsWith("Y"))
            {
                Console.WriteLine("Begin 30 minute wait...");
                System.Threading.Thread.Sleep(30 * 60 * 1000);
                Console.WriteLine("ENTER to test token validation...");
                Console.ReadLine();
                if (_api.HasAccessToken)
                {
                    Console.WriteLine("Access Token Valid");
                    Console.ReadLine();
                }
            }
        }
    }
}
