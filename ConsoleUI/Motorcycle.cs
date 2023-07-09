using System;
namespace ConsoleUI
{
	public class Motorcycle : Vehicle
	{

        public bool ThreeWheel { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("Rumble Rumble");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("Motorcycle override");
        }
    }
}

