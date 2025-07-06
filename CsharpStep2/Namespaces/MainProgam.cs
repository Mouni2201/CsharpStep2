//using ExcelFileSystem;
//using PPTFileSystem;
//using WordFileSystem;
//when we give three it will give compile time error.


using System;

namespace MainProgramSystem
{
    class MainProgam
    {
        public static void Main()
        {
            //when you give one using ExcelFileSystem we can write like below
            //Jan_File janfile = new Jan_File();
            //Console.WriteLine(janfile.fileName);

            //Feb_File febfile = new Feb_File();
            //Console.WriteLine(febfile.fileName);

            //Mar_File marfile = new Mar_File();
            //Console.WriteLine(marfile.fileName);

            ExcelFileSystem.Jan_File janfile = new ExcelFileSystem.Jan_File();
            Console.WriteLine(janfile.fileName);

            PPTFileSystem.Jan_File janfile1 = new PPTFileSystem.Jan_File();
            Console.WriteLine(janfile1.fileName);

            WordFileSystem.Jan_File janfile2 = new WordFileSystem.Jan_File();
            Console.WriteLine(janfile2.fileName);

        }

    }
}

