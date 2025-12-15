using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace To_Do_List
{
    internal class Task
    {

        public string Title;
        public string Description;
        public DateTime Time;
        public Task(string title,string Description, DateTime time)
        {
            Title = title;
            this.Time = time;
            this.Description = Description;

        }
        public string ToString()
        {

            return Title +"#"+ Description + "#" + Time.ToString();
        }

    }
}