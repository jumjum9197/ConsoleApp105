using System;
using System.IO;

namespace ConsoleApp105
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //string a = @"C:\Users\MY PC\Desktop\jum";
            //if(Directory.Exists(a))
            //{
            //    Directory.Delete(a);
            //    Console.WriteLine("file deleted");

            //}
            //else
            
            //    Console.WriteLine("folder not found");

            Console.WriteLine("enter a world: ");
            string v = Console.ReadLine();
            if (v==null)
            {
                Console.WriteLine("invalid");
            }
            else
            {
                if (Directory.Exists(v))
                {
                    Directory.Delete(v);
                    Console.WriteLine("file deleted");

                }
                else
                    Console.WriteLine("not found");
            }
        }

        
    }
}
