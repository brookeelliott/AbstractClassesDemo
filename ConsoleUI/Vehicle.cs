using System;
namespace ConsoleUI
{
	public abstract class Vehicle
	{
		public Vehicle()
		{
		}

		public string Year { get; set; } = "0000";
		public string Make { get; set; } = "Make";
		public string Model { get; set; } = "Model";

		public abstract void DriveAbstract();
		

        public virtual void DriveVirtual()
        {
            return;
        }

    }
}

