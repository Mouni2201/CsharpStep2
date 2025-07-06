using System;



//constructor is a special method that is used to initialize objects.called when an instance of a class is created.
class FieldDetailsConstructors
    {
    string fileName = "studentResume.docx";
    string fileLocation = @"D:\training\documents";
    string fileSize = "5kb";
    string createdDate = "Mar-07-2025";

    DateTime CreatedDateTime = DateTime.Now;

    public FieldDetailsConstructors()
    {
        Console.WriteLine("File object created");

         this.fileName = "KushalResume.docx";
         this.fileLocation = @"D:\training";
         this.fileSize = "7kb";
         this.createdDate = "Mar-09-2025";


        Console.WriteLine(this.fileName);
        Console.WriteLine(this.fileLocation);
        Console.WriteLine(this.fileSize);
        Console.WriteLine(this.createdDate);

        Console.WriteLine("Constructor is calling");
    }
    public FieldDetailsConstructors(string fileName, string fileLocation, string fileSize, string createdDate)
    {
        Console.WriteLine("File object created");

        this.fileName = fileName;
        this.fileLocation = fileLocation;
        this.fileSize = fileSize;
        this.createdDate = createdDate;
   

        Console.WriteLine(this.fileName);
        Console.WriteLine(this.fileLocation);
        Console.WriteLine(this.fileSize);
        Console.WriteLine(this.createdDate);
    }

    //public FieldDetailsConstructors(string name)
    //{
    //    Console.WriteLine("Constructor is calling");
    //}

    static void Main()
    {
        FieldDetailsConstructors fileDetailsConstructors1 = new FieldDetailsConstructors();
        //FieldDetailsConstructors fileDetailsConstructors2 = new FieldDetailsConstructors("Mounica");
        FieldDetailsConstructors fileDetailsConstructors3 = new FieldDetailsConstructors("HDFCBankDetails.docx", @"D:/documents", "10kb", "Mar-01-2025");
    }
}

