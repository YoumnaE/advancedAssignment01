using System;
using System.Collections.Generic;
using System.Text;

namespace advancedAssignment01
{
    internal class ContainerInterface<T> where T : Iprintable
    {
        //What is the Interface Constraint? generic type parameter implements a specific interface

        public void Print(T item){
            item.Print();
        }
    }
}
