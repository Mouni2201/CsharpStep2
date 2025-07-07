using System;


//Every member is  a static member
//No instance members(you can call directly without creating an instance of the class)

static class logger
{
    //fields
    //string logfile = "application1.txt"; // every member is static(can't declare instance in static member) 
    static string logFile = "application1.txt";
    static string logDescription = "you have logged in app at July-07-2025 at 9:20PM";

    //properties
    static string LogFile { get; set; }

    //constructor
    //In static constructor you cant pass parameters and it will call only one single time and
    //we write one single constructor
    static logger()
    {
        logger.LogFile = "application2.txt";
    }

    static void LogMessage(string level, string Message)
    {
        Console.WriteLine($"{DateTime.Now} [{level} - {Message}]");
    }

    static void LogInfo(string Message)
    {
        logger.LogMessage("INFO", Message);
    }

    static void LogWarning(string Message)
    {
        logger.LogMessage("Warning", Message);
    }

    static void LogError(string Message)
    {
        logger.LogMessage("Error", Message);
    }
    static void Main()
    {

        //logger.logFile
        string str1 = logger.logFile; //you can call directly without creating an instance of the class
        string str2 = logger.logDescription; 
        //Console.WriteLine($"The log file name is {logger.logFile}");
        //Console.WriteLine($"The log file description is {logger.logDescription}");
        logger.LogInfo("Application Has started");//the argument goes to loginfo parameter message

        logger.LogWarning("You have entered wrong password. Please try again after few mins.");
        logger.LogError("Something is Wrong.Try again later");
        logger.LogInfo("Application has stopped");
    }


}
