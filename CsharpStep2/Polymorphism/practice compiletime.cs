using System;


namespace CompileTimePolymorphism

{
    //Changing the number of Parameters
    class CompileParamter
    {
        public void Add(int a, int b)
        {
            Console.WriteLine("Sum of two integers: " + (a + b));
        }
        public void Add(int a, int b, int c)
        {
            Console.WriteLine("Sum of three integers: " + (a * b * c));
        }
        
        
    }

    class Program
    {
        static void Main()
        {
            CompileParamter p = new CompileParamter();
             p.Add(3, 4);

            //Console.WriteLine($"Sum is: {Sum1}");
           
        }
    }


}
