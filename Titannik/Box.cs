namespace Titannik
{
    internal class Box
    {
        public double Width { get; private set; }
        double height;
        double length;

        public void SetDefaultValues()
        {
            width = 100;
            height = 110;
            length = 130;
        }

        public void PrintBoxSizes()
        {
            Console.WriteLine("Width: " + width);
            Console.WriteLine("Height: " + height);
            Console.WriteLine("Length: " + length);
        }
    }
}
