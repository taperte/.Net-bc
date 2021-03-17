using NewsLogic.DB;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace NewsLogic.Managers
{
    public class UsersManager
    {
        //Implement user registration:
        //4. Create UserController with action Register and implement Register form(similar to sample above)
        //4.1. Implemenet HttpPost method which calls UserManager -> Register
        public void Register(string username, string email, string password)
        {
            using (var db = new NewsDb())
            {
                //Checks for empty fields.
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                {
                    throw new LogicException("None of the fields can be empty!");
                }
                //Check if there isn't a user with the same username already.
                var user = db.Users.FirstOrDefault(u => u.Username.ToLower() == username.ToLower());
                if (user != null)
                {
                    throw new LogicException("User with this username is registered already!");
                }

                //Check if there isn't a user with the same e-mail already
                user = db.Users.FirstOrDefault(u => u.Email.ToLower() == email.ToLower());
                if (user != null)
                {
                    throw new LogicException("User with this email is registered already!");
                }

                //(Optional) Check if password is at least 6 symbols.
                if (password.Length < 6)
                {
                    throw new LogicException("Password must contain at least 6 characters!");
                }

                //Add user if all OK.
                user = new Users {
                    Username = username,
                    Email = email,
                    Password = password
                };
                db.Users.Add(user);
                db.SaveChanges();
            }
        }

        //1. Add GetUser(string email, string password) to the UserManager
        //2. Add Login to the UserController
        //3. Add LoginUserModel with Username, Password
        //4. Add Login view
        public Users GetUser(string username, string password)
        {
            using (var db = new NewsDb())
            {
                return db.Users.FirstOrDefault(u => u.Username.ToLower() == username.ToLower() && u.Password == password);
            }
        }
    }
}
