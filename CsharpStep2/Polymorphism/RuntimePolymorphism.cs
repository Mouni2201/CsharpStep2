using System;

namespace RuntimePolymorphismSytem
{
    //Inheritance is important in Runtime overriding
class Employee
    {
        public string Name { get; set; }
        public int HoursWorked { get; set; }
        public double HourlyRate { get; set; }

        public virtual double CalculateSalary()
        {
            return HoursWorked * HourlyRate;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Employee Name:{Name}");
            Console.WriteLine($"HoursWorked: {HoursWorked}");
            Console.WriteLine($"Hourlyrate: {HourlyRate}");
        }

    }

    class PermanentEmployee : Employee
    {
        public override double CalculateSalary()
        {
            double basesalary = HoursWorked * HourlyRate;
            double bonus = basesalary * 0.2;
            return basesalary + bonus;
        }

    }

    class ContractEmployee : Employee
    {
        public override double CalculateSalary()
        {
            double basesalary = HoursWorked * HourlyRate;
            double deduction = basesalary * 0.1;
            return basesalary - deduction;
        }
    }

    class Program
    {
        static void Main()
        {
            //Employee pEmployee = new Employee();
            //pEmployee.Name = "Sahasra";
            //pEmployee.HoursWorked = 10;
            //pEmployee.HourlyRate = 9;
            //pEmployee.CalculateSalary();
            //pEmployee.DisplayDetails();

            Employee pEmployee = new PermanentEmployee()
            {
                Name = "Medhansh",
                HoursWorked = 5,
                HourlyRate = 9
            };
            double salary1 = pEmployee.CalculateSalary();
            Console.WriteLine($"Salary1: {salary1}");

            pEmployee.DisplayDetails();

            Employee cEmployee = new ContractEmployee()
            {
                Name = "Kushal",
                HoursWorked = 11,
                HourlyRate = 10
            };
            double salary2 = cEmployee.CalculateSalary();
            Console.WriteLine($"ContractSalary2: {salary2}");

            pEmployee.DisplayDetails();

        }
    }
}

