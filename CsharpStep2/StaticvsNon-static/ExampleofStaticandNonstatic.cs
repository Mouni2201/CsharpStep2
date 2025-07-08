using System;

namespace MovieNews
{
    //Note: you cannot call the static members by using this keyword
    //because this keyword refers to the instance of the class, not the class itself.this.
    public class movieDirector
    {
        //static members
        //static constructor you can create only once in the static class
        public static string LeadActor = "Harry";
        public static string Cinematographer = "Ron";

        public static void callLeadActor()
        {
            //Console.WriteLine($"Lead Actor is: {this.LeadActor}"); //you cannot call the static members by using this keyword

            Console.WriteLine($"Lead Actor is: {movieDirector.LeadActor}");
        }

        
        
        
        //non-static members

        public string JuniorTechnician { get; set; }
        public string LightingAssistant { get; set; }

        public movieDirector (string JuniorTechnician, string LightingAssistant) //constructor
        {
            this.JuniorTechnician = JuniorTechnician;
            this.LightingAssistant = LightingAssistant;
        }

        public void callJuniorTechnician()
        {
            Console.WriteLine($"Junior Technician is: {this.JuniorTechnician}");
            //Console.WriteLine($"Junior Technician is: {movieDirector.JuniorTechnician}"); //can't call like this
            //either you can call like JuniorTechnician or you can call by using this.JuniorTechnician (this keyword).
        }

        public void callLightingAssistant()
        {
            Console.WriteLine($"Lighting Assistant is: {this.LightingAssistant}");


        }

    }

    public class  program
    {
        static void Main()
        {
            Console.WriteLine($"Static Members(direct call:)");
            movieDirector.callLeadActor(); //calling Method
            string name = movieDirector.Cinematographer;
            Console.WriteLine($"the cinematorapher is: {name}");


            Console.WriteLine($"Non-Static Members(Indirect call:)");
            movieDirector director = new movieDirector("Hermoinie", "Arnab");
            director.callJuniorTechnician();
            director.callLightingAssistant();


        }
    }
}
