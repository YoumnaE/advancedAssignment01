using System;
using System.Buffers;
using System.Collections.Generic;
using System.Text;

namespace advancedAssignment01
{
    internal class ContainerMultiple<T>where T : Learn, Iprintable, new()
    {
        //Q12: How do you apply multiple constraints? apply more than one restriction
        public void Print()
        {
            T item = new T();
            item.Print();
        }
    }
}
