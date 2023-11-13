namespace Titannik
{
    internal class Box
    {
        public Box()
        {

        }

        public Box(double width, double height, double length)
        {
            Width = width;
            Height = height;
            Length = length;
        }

        public double Width { get; set; }
        public double Height { get; set; }
        public double Length { get; set; }

        private int _age1;
        public void SetDefaultValues()
        {
            Width = 100;
            Height = 110;
            Length = 130;
        }

        public void PrintBoxSizes()
        {
            Console.WriteLine("Width: " + Width);
            Console.WriteLine("Height: " + Height);
            Console.WriteLine("Length: " + Length);
        }
    }
}
