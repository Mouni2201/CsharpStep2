using System;

namespace StaticAndNonStaticMembers
{
    public static class EmployeeStaticLogger
    {
        public static int EmployeeList = 0;

        //log message is for print the message as well as increase  the count of EmployeeList
        //example: if we log 5 messages then EmployeeList will be 6
        public static void LogMessage(string Message) 
        {

            Console.WriteLine($"[log] {Message}");
            EmployeeList = EmployeeList + 1;

        }
        public static int GetMessageCount()
        {
            return EmployeeList;
        }

        //static constructor can create only once in the static class an can't pass any parameters.
        //static EmployeeStaticLogger() //static constructor
        //{
        //    Console.WriteLine("Static Logger Initialized");
        //}
    }

    public class  EmployeeNonStaticLogger
    {
      public int EmployeeList = 0; 
        public void LogMessage(string Message)
        {
            Console.WriteLine($"[Log], {Message}"); 
            EmployeeList = EmployeeList + 1;
        }

        public int GetMessagecount()
        {
            return EmployeeList;

        }
        
    }

    class program
    {
        static void Main()
        {
            //i don't have a chance to change because it can't create instanc here
            EmployeeStaticLogger.LogMessage("John has started learn at 3:00PM");
            EmployeeStaticLogger.LogMessage("Arab has started learn at 5:00PM");
            Console.WriteLine($"Total static logMessages {EmployeeStaticLogger.GetMessageCount()}");

            //situation based i can take any instance over here
            EmployeeNonStaticLogger employeeNonStaticLogger1 = new EmployeeNonStaticLogger();
            employeeNonStaticLogger1.LogMessage("Emily is in paris");
            employeeNonStaticLogger1.LogMessage("Arnab is in london");
            employeeNonStaticLogger1.LogMessage("Akash is in NewYork");

            EmployeeNonStaticLogger employeeNonStaticLogger2 = new EmployeeNonStaticLogger();
            employeeNonStaticLogger2.LogMessage("Stranger Things");

            Console.WriteLine($"Total non-static logMessages {employeeNonStaticLogger1.GetMessagecount()}");
            Console.WriteLine($"Total non-static logMessages {employeeNonStaticLogger2.GetMessagecount()}");


        }
    }
}
