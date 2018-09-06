using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingClasses
{
    class FirstClass
    {
        private int id;
        private string name;

        // Define constructor
        public FirstClass(int id, string name)
        {
            setId(id);
            setName(name);
        }

        // Define getters and setters
        public void setId(int id)
        {
            this.id = id;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public int getId()
        {
            return this.id;
        }

        public string getName()
        {
            return this.name;
        }
    }
}
