using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace LAB4
{
    class ChildClass : ParentClass
    {
        public string Name { get; set; }
        
        public void WriteMethod(string name, double length)
        {
            Debug.WriteLine(name.GetType() + "\t" + length.GetType());
        }
    }
}
