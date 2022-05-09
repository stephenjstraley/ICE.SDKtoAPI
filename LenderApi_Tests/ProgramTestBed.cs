using System;
using System.Collections.Generic;
using System.Text;

namespace LenderApi_Tests
{
    public partial class Program
    {
        public static void TestBedMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Individual Test Bed Tests");
                Console.WriteLine("----------------");
                Console.WriteLine("1. Folder Permissions");
                Console.WriteLine();

                Console.WriteLine("99. Return to Main Menu");
                try
                {
                    var opt = Convert.ToInt32(Console.ReadLine());
                    if (opt == 99)
                        break;
                    else
                    {
                        switch (opt)
                        {
                            case 1:
                                FolderPermission();
                                break;
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine();
                    Console.WriteLine(e.Message);
                    Console.ReadKey();
                }

            }
        }
    }
}
