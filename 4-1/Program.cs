using System;
using System.Collections;

namespace _4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // создание листа кастом
            int custom_capacity = int.Parse(Console.ReadLine());
            ArrayGeneric<int> custom_list = new ArrayGeneric<int>(custom_capacity);
            // создание дефолтного листа
            ArrayGeneric<double> default_list = new ArrayGeneric<double>();
            // добавление элементов
            custom_list.Add(1);
            custom_list.Add(2);
            custom_list.Add(3);
            // печать элементов
            foreach(object t in custom_list)
            {
                Console.WriteLine(t);
            }
            
        }
    }
}
