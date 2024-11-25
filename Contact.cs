using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ContactManagerApp
{
    internal class Contact
    {
        private List<User> _users = new List<User>();
        public void AddUser(User user)
          //  field → small letter with private
        {
            _users.Add(user);
        }
        public void DeleteUser(Predicate<User> predicate) 
        {
            var userToRemove = _users.Find(predicate);
            if (userToRemove != null)
            {
                _users.Remove(userToRemove);
                Console.WriteLine($"User {userToRemove.FName} {userToRemove.LName} deleted.");
            }
            else
            {
                Console.WriteLine("User not found.");
            }
        }

        public User SearchUser(Predicate<User> predicate)
        {
            return _users.Find(predicate);
        }

        public void ShowAllUsers()
        {
            foreach (var user in _users)
            {
                Console.WriteLine(user);
            }
        }
    }
}
