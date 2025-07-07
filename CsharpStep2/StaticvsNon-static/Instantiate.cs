using System;


//Instantiate is the process of creating an instance of a class. When you instantiate a class)
namespace StaticVsNonStaticInstantiate
{
    //In static class we can only write only Members and static methods only and
    //there is no need to create instance and we can call directly without creating instance
    public static class StaticClass
    {
        public static void PrintMessage()
        {
            Console.WriteLine("This is a static class Method");
        }
    }

    //In stati class we can create static and non-static members and methods
    //we need to create instance for non-static class and when we write static method in non-static class for this no need to write Instance for static method direcetly we can call it.
    public class  NonStaticClass
    {
        public void PrintMessage()
        {
            Console.WriteLine("This is a non-static class Method");
        }

        public static void PrintMessage2()
        {
            Console.WriteLine("This is a Non-static Class and static Method");
        }

    }

    public class program
    {
        static void Main()
        {
            StaticClass.PrintMessage(); //In static class- static method

            NonStaticClass nonStaticClass = new NonStaticClass();   //In non-stact class - nonstatic method
            nonStaticClass.PrintMessage();

            NonStaticClass.PrintMessage2();  //In nonstatic class- static method

        }
    }
}