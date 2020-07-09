using System;
using System.Collections.Generic;



namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<string> people = StringGetPeople();
            foreach (string item in people)
            {
                Console.WriteLine(item);
            }
                Console.ReadLine();

            List<PersonModel> personModels = ModelGetPerson();
            foreach (PersonModel item in personModels)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}");
            }
        }
            private static List<PersonModel> ModelGetPerson(){
            List<PersonModel> output = new List<PersonModel>();
            output.Add(new PersonModel {FirstName = "Milan", LastName = "Milivojevic"});
            output.Add(new PersonModel {FirstName = "Milan", LastName = "Josipovic"});
            return output;
            }
        private static  List<string> StringGetPeople(){
            List<string> output = new List<string>();
            output.Add("Borivoje");
            output.Add("Ivan");
            output.Add("Gradimir");
            output.Add("Milan");
            output.Add("Milan");
            output.Add("Predrag");
            output.Add("Dusan");
            return output;

            }
        
    }
}
