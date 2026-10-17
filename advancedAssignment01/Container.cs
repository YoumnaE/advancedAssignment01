using System;
using System.Collections.Generic;
using System.Text;

namespace advancedAssignment01
{
    internal class Container<T>
    {
        private T item;

        public void Add(T value){
            item = value;
        }

        public T Get(){
            return item;
        }
    }
}
