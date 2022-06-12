using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Data_Access_Layer
{
    public class UserDAL
    {
        public List<User> GetAllUsers()
        {
            var db = new UserDbContext();
            return db.User.ToList();
        }
        public User GetUser(int id)
        {
            var db = new UserDbContext();
            User u = new User();

            u = db.User.FirstOrDefault(x => x.Id == id);
            Log.Information("User found! - ", u);

            if (u == null)
            {
                Log.Information("User not found!");
                throw new Exception("User not found!");
            }

            Console.WriteLine(u.FirstName + " " + u.LastName + " Searched by id");
            return u;
        }
    }
}
