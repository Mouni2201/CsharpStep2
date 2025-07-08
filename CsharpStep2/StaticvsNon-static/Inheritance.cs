using System;

namespace Family

{
    class Father
    {
        public string Name { get; set; }

        //public Father(string name)  //constructor
        //{
        //    Name = name;
        //    Console.WriteLine($"From father Parameter name is {name}");

        //}

        //parameter less constructor
        public Father()  //constructor
        {
            Name = "Alice";
            Console.WriteLine($"From father Parameter name is {Name}");

        }

        public Father(string name) 
        {
            Console.WriteLine($"Hello my kid name is {name}");
        }
        public void showMessage()
        {
            Console.WriteLine($"Hi My Name is {Name} and iam Father");
        }
      

    }

    class Mother
    {
        //
    }
    //class Child : Father, Mother // can't give multiple parents for child refernce either give father or mother

    class Child : Father
    {
        //public Child(string name) : base(name) //calling the base class constructor with a parameter
        //{
        //    Console.WriteLine($"Child class constructor name is {name} {Name}");
        //}

        public Child()
        {
            Console.WriteLine($"Child class constructor from father class{Name}");
            //it goes to paramerter costructor of Father class
        }

        public Child(string kidname) : base(kidname)  //calling from father class constructor with a parameter
        {
            Console.WriteLine($"Child class constructor my father is {kidname}");
        }

        public string[] myClassFriend()
        {
            return new string[] { "Mouni", "Sravani" };
        }

    }

    class program
    {
        static void Main()
        {
            //Father father = new Father("Alice");
            //father.showMessage();

            //Father father = new Father(); //using parameter less constructor
            //father.showMessage();

            //Child child = new Child();    //using parameter less constructor of Father class
            //child.showMessage();  //Child class inherits the showMessage method from Father class

            //Child child = new Child();

            Child child = new Child("Junior Alice");
            child.myClassFriend();


            //Father father = new Father();
            //father.myClassFriend(); //can't write like this because tclassfriends is from child class.

        }
    }
}