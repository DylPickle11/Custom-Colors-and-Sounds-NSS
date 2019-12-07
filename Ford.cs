using System;

namespace CustomColorsAndSounds
{
    public class Ford : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Vrrrrroooooommmmoommm!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine(direction);
        }

        public override void Stop()
        {
            Console.WriteLine("Stops clunkily");
        }
        public void message()
        {
            Drive();
            Turn("The Ford turns to the left");
            Stop();

        }

    }
}