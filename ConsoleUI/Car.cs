using System;
namespace ConsoleUI
{
	public class Car : Vehicle
	{

		public bool FourDoor { get; set; }

        public override void DriveAbstract()
        {
			Console.WriteLine("Vroom Vroom");
        }
    }
}

