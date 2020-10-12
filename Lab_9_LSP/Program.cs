using System;

namespace Lab_9_LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();

            Square s1 = new Square();

            Console.WriteLine("Now, calling the function with a Rectanlge");
            UserOfRectangle(r1);

            Console.WriteLine("Now, calling the function with a Square");
            UserOfRectangle(s1);
            Console.ReadLine();
        }

        static void UserOfRectangle(Rectangle r)
        {
            r.Height = 5;
            r.Width = 4;
            if (r.CalculateArea() != 20)
            {
                throw new Exception("Bad Area!");
            }
            else
            {
                Console.Write("For the Shape with sides: " + r.Height + " by " + r.Width + ", ");
                Console.WriteLine("The area is: " + r.CalculateArea());
            }
        }
    }
}
