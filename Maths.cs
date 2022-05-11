using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace Maths
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i;
            Console.Write("NHAP VAO MOT SO : ");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.Write("SO VUA NHAP LA SO CHAN");
                Console.Read();
            }
            else
            {
                Console.Write("SO VUA NHAP LA SO LE");
                Console.Read();
            }
        }
    }
}