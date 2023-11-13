namespace Titannik
{
    internal class Box
    {
        public Box()
        {
            Console.WriteLine("ya rodivsya");
            Console.WriteLine("ya rodivsya");
            Console.WriteLine("ya rodivsya");
            Console.WriteLine("ya rodivsya");
            Console.WriteLine("ya rodivsya");
        }

        public double Width
        {
            get
            {
                Console.WriteLine("Width is got");
                Console.WriteLine("Fuck you Tony");
                return _width;
            }
            set
            {
                if(value < 0)
                {
                    _width = 0;
                    Console.WriteLine("you entered incorrect value");
                    return;
                }

                _width = value;
            }
        }
        private double _width;

        double height;
        double length;

        public int Age { get; set; }

        public int Age1 { 
            get 
            {
                return _age1;
            }
            set
            {
                _age1 = value;
            } 
        }

        private int _age1;
        public void SetDefaultValues()
        {
            Width = 100;
            height = 110;
            length = 130;
        }

        public void PrintBoxSizes()
        {
            Console.WriteLine("Width: " + Width);
            Console.WriteLine("Height: " + height);
            Console.WriteLine("Length: " + length);
        }
    }
}
