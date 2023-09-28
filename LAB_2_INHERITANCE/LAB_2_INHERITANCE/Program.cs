using System;
using System.IO; 
namespace LAB_2_INHERITANCE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create list of employees

            List<Employee> employees = new List<Employee>();

            //Read from "employees.txt" file

            string[] lines = File.ReadAllLines("/Users/gie/Desktop/oop 2/LAB 2/LAB_2_INHERITANCE/LAB_2_INHERITANCE/employees.txt");

            foreach (string line in lines)
            {
                string[] columns = line.Split(":");

                // ID
                string id = columns[0];

                //NAME
                string name = columns[1];

                // ADDRESS
                string address = columns[2];

                // PHONE NUMBER
                string phone = columns[3];

                // SIN NUMBER
                long sin = long.Parse(columns[4]);

                // DATE OF BIRTH
                string dob = columns[5];

                // DEPARTMENT
                string dept = columns[6];

                //

                char firstDigitofID = id[0];

                if (firstDigitofID >= '0' && firstDigitofID <= '4')
                {
                    double salary = double.Parse(columns[7]);
                    Employee employee = new Salaried(id, name, address, phone, sin, dob, dept, salary);
                    employees.Add(employee);
                }
                else if (firstDigitofID >= '5' && firstDigitofID <= '7')
                {
                    double rate = double.Parse(columns[7]);
                    double hours = double.Parse(columns[8]);
                    Employee employee = new Wages(id, name, address, phone, sin, dob, dept, rate, hours);
                    employees.Add(employee);


                }
                else 
                {
                    continue;  
                }


                

            }

            Console.WriteLine(employees);
        }
    }
}
