/* Jessica Oriondo
 * net ID: jeko@uw.edu
 * Homework 2
 * working with LIST<T>
 * creates and manipulates List<T> of Users
 */

using System;
using System.Linq;
using System.Collections.Generic;

namespace ListHomework2
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new List<Models.User>();

            users.Add(new Models.User { Name = "Dave", Password = "hello" });
            users.Add(new Models.User { Name = "Steve", Password = "steve" });
            users.Add(new Models.User { Name = "Lisa", Password = "hello" });


            //all users with password "hello" assuming its case sensitive
            var helloPasswords = users.Where(x => x.Password == "hello");
            Console.WriteLine("Users with password: hello");
            foreach (var person in helloPasswords)
                Console.WriteLine(person.Name);

            users.RemoveAll(person => person.Name.ToLower() == person.Password);
            //Console.WriteLine("\nall users after deleting users with lowercased password of their name");
            //foreach (var person in users)
            //    Console.WriteLine(person.Name);


           // Console.WriteLine("\nFirst user with hello password is removed");
            users.Remove(users.First(person => person.Password == "hello"));
            //foreach (var person in users)
            //    Console.WriteLine(person.Name);

            Console.WriteLine("\nRemaining users:");
            foreach (var person in users)
                Console.WriteLine("name: " + person.Name+ "    password:" + person.Password );
        }
    }
}
