using System;
using System.Runtime.Remoting.Channels;

class StudentResume
{
    //properties: properties that provides contolled access to a class's field using get and set accessories.
    //variable create starts with small letters

    //string fileName;
    //we can give no value and you can give main method that means updated fileds
    string fileName = "KushalResume.docx";
    string fileLocation = @"D:\training\documents";
    string fileSize = "5kb";
    string createdDate = "Mar-07-2025";

    //properties can control the data. properties name starts with capital letters
    //when you remove set here, you can't assign the value that what the controlling 
    //get is the get value from filename
    //string FileName { get; }  you cant assign /set the value(if you remove set it can be read only format)
    string FileName { get; set; }
    string FileLocation { get; set; }
    string FileSize { get; set; }
    string CreatedDate { get; set; }


    static void Main()
    {
        StudentResume studentsResume = new StudentResume();
        //studentsResume.fileName = "MedhanshResume.docx";
        studentsResume.FileName = "EmployeeSalary.pdf";      // here FileName is the property
        studentsResume.FileLocation = @"c:\downloads\Account";
        studentsResume.FileSize = "5kb";
        studentsResume.CreatedDate = "Jan-22-1999";

        Console.WriteLine($"fileName is {studentsResume.FileName} and filesize is {studentsResume.FileSize}");
    }


}

