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

        public void SetDefaultValues()
        {
            Width = 100;
            Height = 110;
            Length = 130;
        }

        public void SetDefaultValues(bool isEven)
        {
            Width = isEven ? 100 : 101;
            Height = isEven ? 110 : 111;
            Length = isEven ? 130: 131;
        }

        public void SetDefaultValues(int countOfPartsToDivide)
        {
            Random rnd = new Random();
            int multiplyier = new Random().Next(20);

            Width = Height = Length = multiplyier * countOfPartsToDivide;
        }

        public void PrintBoxSizes ()
        {
            if (Width == 5)
            {
                Console.WriteLine("fsdfs");
            }

            Console.WriteLine("Width: " + Width);
            Console.WriteLine("Height: " + Height);
            Console.WriteLine("Length: " + Length);
        }


    }
}
