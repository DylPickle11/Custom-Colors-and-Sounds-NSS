using System;

namespace CustomColorsAndSounds
{
    public class Tesla : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Just a whisper");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine(direction);
        }

        public override void Stop()
        {
            Console.WriteLine("Stops on a dime!");
        }
        public void message()
        {
            Drive();
            Turn("The Tesla swerves to the right");
            Stop();

        }

    }
}