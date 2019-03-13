using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkApp.Events
{
    public class ProjectSaveEvent
    {
        public ProjectSaveEvent(string message)
        {
            this.Message = message;
        }

        public string Message { get; private set; }
    }
}