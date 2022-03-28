namespace Task_abstract.Models
{
    class Square:Figure
    {
        
        private int _side;
        public int Side
        {
            get
            {
                return _side;
            }

            set 
            { 
                if (value < 0)
                {
                    System.Console.WriteLine("Side deyeri menfi ola bilmez!");
                    return;
                }
                _side = value;
            }
        
        }
        public Square(int side)
        {
            Side = side;
        }

        public override void CalcArea()
        {
            System.Console.WriteLine($"Side = {Side}");
        }
    }

}
