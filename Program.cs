using System;

namespace CustomColorsAndSounds
{
    class Program
    {
        static void Main(string[] args)
        {
            Honda Honda = new Honda();
            Tesla Tesla = new Tesla();
            Ford Ford = new Ford();
            Toyota Toyota = new Toyota();

            Honda.message();
            Tesla.message();
            Ford.message();
            Toyota.message();

        }
    }
}