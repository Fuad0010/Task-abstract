using System;

namespace Task_abstract.Models
{
    internal class Rectangular : Figure
    {
        private int _width;
        private int _length;

        public int Width
        {
            get
            {
                return _width;
            }

            set
            {
                if (value < 0)
                {
                    Console.WriteLine("width menfi ola bilmez!");
                    return;
                }
                _width = value;
            }

        }
        public int Length
        {
            get
            {
                return _length;
            }

            set
            {
                if (value < 0)
                {
                    Console.WriteLine("length menfi ola bilmez!");
                    return;
                }
                    _length = value;
            }
        }
        public Rectangular(int width, int length)
        {
            Width = width;
            Length = length;
        }

        public override void CalcArea()
        {
            Console.WriteLine($"Width = {Width}\n" +
                              $"Length = {Length}");
        }
    }
}
