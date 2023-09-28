﻿using System;
namespace LAB_2_INHERITANCE
{
	internal class Employee
	{
		// Properties

		public string ID { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }
		public string Phone { get; set; }
		public long SIN { get; set; }
		public string DOB { get; set; }
		public string Dept { get; set; }
		
		// Constructors

		public Employee()
		{

		}

		public Employee(string id, string name, string address, string phone, long sin, string dob, string dept)
		{
			this.ID = id;
			this.Name = name;
			this.Address = address;
			this.Phone = phone;
			this.SIN = sin;
			this.DOB = dob;
			this.Dept = dept;
		}
        // Methods

        public override string ToString()
        {
			return $"ID: {this.ID} \n Name: {this.Name} \n Address: {this.Address} \n Phone: {this.Phone} \n SIN: {this.SIN} \b DOB: {this.DOB} \n Dept: {this.Dept}";
        }
    }
}

