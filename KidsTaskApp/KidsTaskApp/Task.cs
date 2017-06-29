using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsTaskApp
{
    class ToDoTask
    {
        private string title { get; }
        private bool doneFlag;
        
        public ToDoTask(string title)
        {
            this.title = title;
            this.doneFlag = false;
        }

        public void done()
        {
            this.doneFlag = true;
        }

        public bool isDone()
        {
            return this.doneFlag;
        }
    }
}
