using System;

namespace CustomColorsAndSounds
{
    public class Honda : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Zoooooom!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine(direction);
        }

        public override void Stop()
        {
            Console.WriteLine("Car stops well.");
        }

        public void message()
        {
            Drive();
            Turn("The Honda turns to the right");
            Stop();

        }
    }
}