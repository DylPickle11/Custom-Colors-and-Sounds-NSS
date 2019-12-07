using System;

namespace CustomColorsAndSounds
{
    public class Toyota : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Broom!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine(direction);
        }

        public override void Stop()
        {
            Console.WriteLine("Stops slowly");
        }

        public void message()
        {
            Drive();
            Turn("The Toyota keeps straight");
            Stop();

        }

    }
}