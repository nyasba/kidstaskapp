using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsTaskApp
{
    class User
    {
        private int id;
        private string name { get; }
        private int level { get; set; }

        public User(string name)
        {
            this.name = name;
            this.level = 1;
        }

        public void levelUp()
        {
            this.level+= 1;
        }
        
    }
}
