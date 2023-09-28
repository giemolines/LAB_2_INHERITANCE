using System;
namespace LAB_2_INHERITANCE
{
	internal class PartTime: Employee
	{
		//Properties
		public double Rate { get; set; }
		public double Hours { get; set; }
		//Constructors
		public PartTime()
		{

		}

		public PartTime(string id, string name, string address, string phone, long sin, string dob, string dept, double rate, double hours) :base(id, name, address, phone, sin, dob, dept)
		{
			this.Rate = rate;
			this.Hours = hours;
		}
		//Methods

		public double getPay()
		{
			return Rate * Hours;
		}

		public new void ToString()
		{

		}
	}
}

