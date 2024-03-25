using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1
{
    class ArrayGeneric<P>
    {
        private P[] list;
        private int capacity;
        private int default_capacity = 7;
        private int size = 0;
        
        public ArrayGeneric(int capacity)
        {
            this.capacity = capacity;
            list = new P[capacity];
        }
        public ArrayGeneric()
        {
            this.capacity = default_capacity;
            list = new P[default_capacity];
        }
        public void Add(P element)
        {
            if (size == capacity)
            {
                Resize(); 
            }
            list[size] = element;
        }
        public void Resize()
        {
            capacity = capacity * 2 + 1;
            P[] _list = new P[capacity];
            Array.Copy(list, _list, size);
            list = _list;
        }
    }
}
