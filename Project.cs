﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirst
{
    class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual Department Department { get; set; }
        public virtual ICollection<Employee> Employees { get; set; } // more than one emplyoee works in project
    }
}
