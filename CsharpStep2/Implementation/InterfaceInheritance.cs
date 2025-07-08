using System;

namespace interfacesBasics
{
    interface Interface1
    {
        //can create methods, properties
        //In interface we can't implement we can only define properties and methods
        int property { get; set; }  //property

        int int_method1();  //methods
        string str_method1();   //methods

        string str_method2(int a, int b);   //methods
    }

    interface Interface3
    {
        string str_method3();

    }

    //need to implement rules in interface1, Interface3
    interface Interface2 : Interface1, Interface3
    {
        string str_method4(); //rules
    }
}