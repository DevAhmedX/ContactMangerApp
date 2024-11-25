using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ContactManagerApp
{
  
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Create instances of ContactManager and Users
            Contact contactManager = new Contact();

            // Create some users
            User user1 = new User(1, "John", "Doe", "Male", "New York");
            user1.Addresses.Add(new Address("123 Elm St", "Home", "Primary address"));
            user1.Phones.Add(new Phone("123-456-7890", "Mobile", "Personal phone"));
            user1.Emails.Add(new EMail("john.doe@example.com", "Personal", "Work email"));

            User user2 = new User(2, "Jane", "Doe", "Female", "Los Angeles");
            user2.Addresses.Add(new Address("456 Oak St", "Home", "Primary address"));
            user2.Phones.Add(new Phone("987-654-3210", "Home", "Work phone"));
            user2.Emails.Add(new EMail("jane.doe@example.com", "Work", "Personal email"));

            // Add users to the contact manager
            contactManager.AddUser(user1);
            contactManager.AddUser(user2);

            // Display all users
            Console.WriteLine("All Users:");
            contactManager.ShowAllUsers();
            Console.WriteLine();

            
            // Delete a user by ID
            Console.WriteLine("Deleting User with ID 1:");
            contactManager.DeleteUser(u => u.ID == 1);
            Console.WriteLine();

            // Display all users again
            Console.WriteLine("All Users after deletion:");
            contactManager.ShowAllUsers();
            Console.ReadKey();

        }
    }
}