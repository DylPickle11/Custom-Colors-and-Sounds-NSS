using System;

namespace CustomColorsAndSounds
{

    public class Vehicle
    {
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }
        public virtual void Turn(string direction)
        {
            Console.WriteLine(direction);
        }
        public virtual void Stop()
        {
            Console.WriteLine("Eeerrrgghhhh");
        }
    }
}