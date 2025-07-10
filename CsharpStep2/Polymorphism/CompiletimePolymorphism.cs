using System;

namespace CompileTimePolymorphismSystem
{
    //Method overloading is a compile-time polymorphism technique where multiple methods can have the same name but different parameters (type, number, or both).
    //Input types and number of parameters are used to differentiate between methods.
    //Same Method name and return types aslo same but the parameters are fifferent.
    public class SalaryCalculator
    {
        public double CalculateSalary( double monthlySalary)
        {
            return monthlySalary;
        }

        public double CalculateSalary(int HoursWorked)
        {
            return HoursWorked;
        }

        public double CalculateSalary(int HoursWorked, int HourlyRate)
        {
            return HoursWorked * HourlyRate;
        }

        public double CalculateSalary(double salesAmount, double commissionRate)
        {
            return salesAmount * commissionRate;
        }

        public double CalculateSalary(int HoursWorked, int HourlyRate, double bonus)
        {
            return (HoursWorked * HourlyRate) + bonus;
        }
    }


    class Program
    {
        static void Main()
        {
            SalaryCalculator calculator = new SalaryCalculator();
            double salary1 = calculator.CalculateSalary(3000);
            double salary2 = calculator.CalculateSalary(10000);
            double salary3 = calculator.CalculateSalary(9, 4);
            double salary4 = calculator.CalculateSalary(5000, 0.1);
            double salary5 = calculator.CalculateSalary(9, 4, 100);


            Console.WriteLine($"salary1: {salary1}");
            Console.WriteLine($"salary2: {salary2}");
            Console.WriteLine($"salary3: {salary3}");
            Console.WriteLine($"salary4: {salary4}");
            Console.WriteLine($"salary4: {salary4}");
        }
    }

}
