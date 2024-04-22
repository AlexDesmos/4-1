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
        private int current_size = 0;
        
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
            if (current_size == capacity)
            {
                Resize(); 
            }
            list[current_size] = element;
        }
        public void Resize()
        {
            capacity = capacity * 2 + 1;
            P[] _list = new P[capacity];
            Array.Copy(list, _list, current_size);
            list = _list;
        }
        public void Remove(P element)
        {
            capacity--;
            int index = FindIndex(element);
            if (index != -1)
            {
                Array.Copy(list, index += 1, list, index, capacity - index);
            }
        }
        private int FindIndex(Func<P, bool> func)
        {
            for (int i = 0; i < current_size; i++)
            {
                if (func(list[i]))
                {
                    return i;
                }
            }
            return -1;
        }
        private int FindIndex(P element)
        {
            for (int i = 0; i < current_size; i++)
            {
               if (element.Equals(list[i]))
               {
                    return i;
               }
            }
            return -1;
        }
        public int Length(Func<P, bool> func)
        {
            int output = 0;
            for (int i = 0; i < capacity; i++)
            {
                if (func(list[i]))
                {
                    output += 1;
                }
            }
            return output;
        }
        public int Length()
        {
            return current_size;
        }
        public bool Check(P element)
        {
            return FindIndex(element) != -1;
        }
        public P Find(Func<P, bool> func)
        {
            return list[FindIndex(func)];
        }
        public P[] FindMn(Func<P, bool> func)
        {
            P[] elements = new P[Length(func)];
            int index = 0;
            for (int i = 0; i < current_size; i++)
            {
                if (func(list[i]))
                {
                    elements[index] = list[i];
                    index++;
                }
            }
            Array.Resize(ref elements, index);
            return elements;
        }
        public P[] FindMn<Result>()
        {
            P[] elements = new P[current_size];
            int index = 0;
            for (int i = 0; i < capacity; i++)
            {
                if (list[i] is Result)
                {
                    elements[index] = list[i];
                    index++;
                }
            }
            Array.Resize(ref elements, index);
            return elements;
        }
        public void Print()
        {
            foreach (P element in list)
            {
                Console.Write(element + "\t");
            }
            Console.WriteLine();
        }
        public void Print(P[] array)
        {
            foreach (P element in array)
            {
                Console.Write(element + "\t");
            }
            Console.WriteLine();
        }
    
    
    }
}
