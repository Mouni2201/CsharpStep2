using System;
using System.Threading;

class ConstReadonlyExample

{
    const double pi = 3.1459;
    //const double pi;  compulsory give a atleat one value
    //double pi = 3.1459; when you want change the value you can give like that.
    //compile time constant

    const string companyName = "DXC";

    readonly string createdDate = "Mar-01-2025";  //readonly variable can't change the value but in constructors we will change.

    readonly double length; //here we can give no value, but in constructor we can give value.

    public ConstReadonlyExample()    //constructor
    {
        //pi = 3.1859;
        //this.pi = pi*pi;
        //companyName = "Misard";   //give like (string companyName = "Misard";)
        // here we can't change the the value beacause we gave const. if you give contant we can't change anywhere in the program.
        createdDate = "Oct-08-2025";  //here we can change the value in contructor.
    }

    public void Method1()
    {
        //this.pi = 3.568; 
        //createdDate = "Oct-08-2025"; // change change the value in methods 
    }

    static void Main()
    {
        ConstReadonlyExample example = new ConstReadonlyExample();

        //no need to call with instance, you can call directly with variable
    }
}
