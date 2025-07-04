using System;
using System.Globalization;
using System.Xml.Linq;


class FieldDetails
{
    //class: Fundamental building block of OOP .
    //serves as blueprint for maintaining fields, properties, methods, constructors, delgates and other members.
    //class organizes related data and functions together, enabling modular and resulable code.

    //fields : fields are variables that belong to a class. they represent the data that an object of the class can hold.


    //these are non static fields/members/objects of class
    string fileName = "Convoid's.docx";
    string fileLocation = @"D:\training\documents";
    string fileSize = "5kb";
    string createdDate = "Mar-07-2025";

    DateTime createdDateTime = DateTime.Now;



    //non - static method we use instance in non static method. we can create no
    void showMessage(string fileName, string fileLocation)
    {
        Console.WriteLine($"Hello, the filename is {this.fileName} and the fileLocation is {fileLocation} ");
        //when you comment updated filename this.filename  taakes in class fields details
    }

    //static method - we don't need to use instance
    static void showPDFMessage(string name, string location)
    {
        Console.WriteLine($"Hello, the filename is {name} and the fileLocation is {location}");

    }

     void showPDFfileSize(string name, string filesize)
    {
        Console.WriteLine($"Hello, the filename is {name} and the filesie is {filesize}");

    }

    static void showDetailMessage(FieldDetails file)
    {
        //for updated fields write like below
        //    file.fileName
        //    file.fileLocation
        //    file.filesize
        Console.WriteLine($"Hello, the filename is {file.fileName}, fileLocation is {file.fileLocation}, size is {file.fileSize} and the createdDate is {file.createdDate}");

    }


    static void Main()
    {

        FieldDetails file2 = new FieldDetails();
        file2.fileName = "visualstudio.docx";  //updated fields
        file2.fileSize = "4kb";
        file2.showPDFfileSize(file2.fileName, file2.fileSize); //if we take non-static method and call like this
        //showPDFfileSize(file2.fileName, file2.fileSize); //if we take static method and call like this


        //FieldDetails fieldDetails = new FieldDetails();
        //string fieldCreatedDate = fieldDetails.createdDate;  //Mar-07-2025
        //Console.WriteLine(fieldCreatedDate);


        FieldDetails fileInstance = new FieldDetails();
        fileInstance.fileName = "Aoflow.docx";
        fileInstance.fileLocation = @"D:\training\document\Aoflow";   //updated fields
        fileInstance.fileSize = "10kb";
        fileInstance.createdDate = "Aug-08-2025";

        string fileDetails = fileInstance.createdDate;
        Console.WriteLine(fileDetails);

        //Console.WriteLine($"Print the Instance of class i.e., {fileInstance}");
        //Console.WriteLine("fileName: {fileInstance.fileName}");
        //Console.WriteLine("fileLocation: {fileInstance.fileLocation}");
        //Console.WriteLine("fileSize: {fileInstance.fileSize}");
        //Console.WriteLine("fileCreatedDate: {fileInstance.createdDate}");
         
        
    
       
        fileInstance.showMessage(fileInstance.fileName, fileInstance.fileLocation); //non static
        //showPDFMessage(fileInstance.fileName, fileInstance.fileLocation);  //satic
        showPDFMessage("HDFCbankd- details.docx", @"D:\training\document");


        showDetailMessage(fileInstance);
        // here the Fielddetails reference needs to mention, so the fieldDetails refernces are fileInstance and file2. so, now we take fileInstance

       
        
        //another method (*************************************************************************)
        FieldDetails file4 = new FieldDetails() //creating instance of class FileDetails
        {
            fileName = "Avsq.docx",
            fileLocation = @"D:\training",   //updated fields
            fileSize = "03kb",
            createdDate = "April-08-2025"
        };
        showDetailMessage(file4);


        //(*******************************************************************************************)


        //when you do below steps debugger is On compulsory
        //quickwatch - shift+F9
        //immediate Window - ctrl+Alt+I

        //don't use this.in main method

    }
}

