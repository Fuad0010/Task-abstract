using System;
using Task_abstract.Models;

namespace Task_abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Key;

            do
            {

                Console.WriteLine($"1.Square\n" +
                                  $"2.Rectangular\n" +
                                  $"0.Quit\n");

                Key = Convert.ToInt32(Console.ReadLine());


            } while (Key < 0 || Key > 2);
            
            switch (Key)
                {
                    case 1:
                        {
                            Console.Write("Please enter the side: ");
                            int side = Convert.ToInt32(Console.ReadLine());
                            Square square = new Square(side);
                            square.CalcArea();
                        }
                        break;
                    case 2:
                        {
                            Console.Write("Please enter the width: ");
                            int width = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Please enter the length: ");
                            int length = Convert.ToInt32(Console.ReadLine());
                            Rectangular rectangular = new Rectangular(width, length);
                            rectangular.CalcArea();
                        }
                        break;
                    case 0:
                        return;
                }
            
        }

    }
}
