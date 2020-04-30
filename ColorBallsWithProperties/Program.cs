using System;

namespace ColorBallsWithProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Color red = new Color() {Red = 255, Green  = 0 , Blue = 0};
            Color purple = new Color(){ Red = 255, Green = 0, Blue = 255 };


            Ball bigRed = new Ball(red, 5);
            Ball littlePurple = new Ball (purple, 3);

            bigRed.Throw();
            bigRed.Throw();
            bigRed.Throw();


            Console.WriteLine($"Red throw {bigRed.NumberOfThrows} ");

            bigRed.Throw();
            bigRed.Throw();

            Console.WriteLine($"Red throw {bigRed.NumberOfThrows} ");

            littlePurple.Throw();
            littlePurple.Throw();

            Console.WriteLine($"Purple throw { littlePurple.NumberOfThrows} ");

            littlePurple.Pop();
            littlePurple.Throw();

            Console.WriteLine($"Purple throw { littlePurple.NumberOfThrows} ");
        }
    }
}
