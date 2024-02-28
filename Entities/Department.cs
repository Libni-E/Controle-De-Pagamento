using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courser.Entities
{
    internal class Department
    {
        public string Name { get; set; }
        public Department()
        { 

        }

        public Department (string name)
        {
            this.Name = name;
        }
    }
}
