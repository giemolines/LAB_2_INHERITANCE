using System;
namespace LAB_2_INHERITANCE
{
	internal class Salaried: Employee
	{
		//Properties
		public double Salary { get; set; }
		//Constructors

		public Salaried()
		{

		}

		public Salaried(string id, string name, string address, string phone, long sin, string dob, string dept, double salary) : base (id, name, address, phone, sin, dob, dept)
		{
			this.Salary = salary;
        }

		//Methods

		public double getPay()
		{
			return Salary;
		}

		public new void ToString()
		{
		}
       
    }

}


