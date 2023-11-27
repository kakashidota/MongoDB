using MongoDBtutorial2.Data;
using MongoDBtutorial2.Models;

namespace MongoDBtutorial2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MongoCRUD db = new MongoCRUD("AdressBook");

            //var person = new PersonModel
            //{
            //    FirstName = "Simon",
            //    LastName = "Arvidsson",
            //    Adress = new AdressModel
            //    {
            //        City = "Los Angeles",
            //        Street = "Palo Alto Street 123",
            //        State = "California",
            //    }
            //};


            ////Create
            //db.InsertRecord("Users", person);


            //read
            var records = db.LoadRecords<PersonModel>("Users");

            foreach(var rec  in records)
            {
                Console.Write($"{rec.FirstName} {rec.LastName}");

                if (rec.Adress != null)
                {
                    Console.Write($"{rec.Adress.City}");
                }
            }

            Console.ReadLine();
        }
    }
}