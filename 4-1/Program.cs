using System;
using System.Collections;

namespace _4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // создание листа кастом
            Console.WriteLine("write 'true' if custom, 'false' if default");
            bool flag = bool.Parse(Console.ReadLine());
            if (flag)
            {
                Console.WriteLine("write size of the array");
                int custom_capacity = int.Parse(Console.ReadLine());
                ArrayGeneric<int> custom_list = new ArrayGeneric<int>(custom_capacity);
                Console.WriteLine("Write elements of the list");
                for (int i = 0; i < custom_capacity; i++)
                {
                    custom_list.Add(int.Parse(Console.ReadLine()));

                }
                custom_list.Print();
                Console.WriteLine("First element:");
                Console.WriteLine(custom_list.Find(t => t % 2 == 0));

                Console.WriteLine("elements > 10");
                custom_list.Print(custom_list.FindMn(t => t > 10));

                Console.WriteLine("All double elements");
                custom_list.Print(custom_list.FindMn<double>());

                Console.WriteLine("Write an element you want to find in list");
                Console.WriteLine(custom_list.Check(int.Parse(Console.ReadLine())));

                Console.WriteLine("Write element to destroy it");
                custom_list.Remove(int.Parse(Console.ReadLine()));
                custom_list.Print();
            }    // создание дефолтного листа
            else
            {
                ArrayGeneric<double> default_list = new ArrayGeneric<double>();
                Console.WriteLine("Write elements of the list");
                for (int i = 0; i < 7; i++)
                {
                    default_list.Add(int.Parse(Console.ReadLine()));
                }
                default_list.Print();
                Console.WriteLine("First element:");
                Console.WriteLine(default_list.Find(t => t % 2 == 0));

                Console.WriteLine("elements > 10");
                default_list.Print(default_list.FindMn(t => t > 10));

                Console.WriteLine("All double elements");
                default_list.Print(default_list.FindMn<double>());

                Console.WriteLine("Write an element you want to find in list");
                Console.WriteLine(default_list.Check(int.Parse(Console.ReadLine())));

                Console.WriteLine("Write element to destroy it");
                default_list.Remove(int.Parse(Console.ReadLine()));
                default_list.Print();
            }
            
        }
    }
}
