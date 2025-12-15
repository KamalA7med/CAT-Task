using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;
using To_Do_List;

namespace To_Do_List
{
    internal class DealwithTask_Screen
    {
        public static void Show_DealwithTask_Screen(action del, Task_Mangment_System Sys, string Message)
        {
            Console.WriteLine($"                   {Message}");
            Console.WriteLine("----------------------------------------------------");
            Console.Write("Enter The Task Number  : ");
            int TaskNumber = int.Parse(Console.ReadLine());
            if (del(Sys, TaskNumber))
            {
                Console.WriteLine("Done Successfully");
            }
            else
            {
                Console.WriteLine("Out Of Range");
            }
            Console.ReadKey();

        }
    }
}