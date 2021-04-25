using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;


namespace EntityCreateBusinessObjectTest
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDbContext db = new MyDbContext();

            //var newUser = new User(name: new Name("Foo", "Fighter"));
            //db.Users.Add(newUser);
            //db.SaveChanges();


            var u1 = db.Users.Take(1).First();
            PrintResult("Case 1", u1); //output > Could not read Name from database

            var u2 = db.Users.AsNoTracking()
                .Take(1).First();
            PrintResult("Case 2", u2);  //output > Read Name from database success


            Console.Read();


        }

        static void PrintResult(string label, User u)
        {
            Console.WriteLine($"{label} >>>>>");
            if (u.Name == null)
            {
                Console.WriteLine("Could not read Name from database");
            }
            else
            {
                Console.WriteLine("Read Name from database success");
            }
        }
    }
}
