using System;

namespace interfacesBasics
{
    interface Interface
    {
        //can create methods, properties
        //In interface we can't implement we can only define properties and methods
        int property { get; set; }  //property

        int int_method1();  //methods
        string str_method1();   //methods

        string str_method2(int a, int b);   //methods
    }


}