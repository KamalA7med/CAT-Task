using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using To_Do_List;

namespace To_Do_List
{
    internal class Add_Taskk_Screen
    {
        public static void Show_Add_Task_Screen(Task_Mangment_System Sys)
        {
            Console.WriteLine("Entre Task title : ");
            string title = Console.ReadLine();
            Console.WriteLine("Entre Task Details : ");
            string Details = Console.ReadLine();
            List<string> list = new List<string>();
            list.Add(title);
            list.Add(Details);
            Sys.Add_Task(list);
            Console.WriteLine("Added Successfly");
            Console.ReadKey();
        }
    }
}