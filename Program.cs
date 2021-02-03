using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4_PM
{
    class Program
    {
        static float SquareAreaCount(int side)
        {
            float area;
            area = side * side;
            return area;
        }
        static void Main(string[] args)
        {
            int side = 0;
            bool needMoreAttempts = false;
            while (true)
            {
                do
                {
                    needMoreAttempts = false;
                    Console.Write("Введите длину стороны квадрата: ");
                    if (!int.TryParse(Console.ReadLine(), out side))
                    {
                        needMoreAttempts = true;
                        Console.WriteLine("\nВидимо, вы ввели не только число\n");
                    }
                    else if(side <= 0)
                    {
                        needMoreAttempts = true;
                        Console.WriteLine("\nДлина стороны не может быть меньше или равна 0\n");
                    }
                } while (needMoreAttempts);
                Console.WriteLine($"\nПлощадь квадрата со стороной {side} = {SquareAreaCount(side)}\n");
            }
        }
    }
}
