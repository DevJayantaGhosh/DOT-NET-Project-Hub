using Microsoft.Extensions.Logging;
using MySecuredApp.MyUserDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySecuredApp.Services
{
    public class MyUserServices : IMyUserService
    {
        private DB MyDB;
        private ILogger<MyUserServices> Logger;

        public MyUserServices(DB myDB, ILogger<MyUserServices> logger)
        {
            MyDB = myDB;
            Logger = logger;
        }

        public Task<bool> AsyncAddUser(MyUser myUser)
        {
            MyUser u = new MyUser();
            u.UserName = myUser.UserName;
            u.EmailID = myUser.EmailID;
            Console.WriteLine("Before Hashing =>" + myUser.HashPassword);
            u.HashPassword = BCrypt.Net.BCrypt.EnhancedHashPassword(myUser.HashPassword);
            Console.WriteLine("Before Hashing =>" + u.HashPassword);

            try
            {
                MyDB.MyUsers.AddAsync(u);
                var res = MyDB.SaveChangesAsync();

                if (res.IsCompletedSuccessfully)
                {
                    return Task.FromResult(true);
                }
                else
                {
                    return Task.FromResult(false);
                }
            }
            catch (Exception e)
            {

                throw new Exception("Some thing went Wrong" + e.Message.ToString());
            }
        }

        public  bool AddUser(MyUser myUser)
        {
            MyUser u = new MyUser();
            u.UserName = myUser.UserName;
            u.EmailID = myUser.EmailID;
            Console.WriteLine("Before Hashing =>" + myUser.HashPassword) ;
            u.HashPassword = BCrypt.Net.BCrypt.EnhancedHashPassword(myUser.HashPassword);
            Console.WriteLine("Before Hashing =>" + u.HashPassword);

            try
            {
                MyDB.MyUsers.AddAsync(u);
                var res =MyDB.SaveChanges();

                return true;
            }
            catch (Exception e)
            {

                throw new Exception("Some thing went Wrong"+e.Message.ToString());
            }
        }

        public Task<MyUser> AsyncGetUserByName(string userName)
        {
            return Task.FromResult(MyDB.MyUsers.Where(x => x.UserName == userName).FirstOrDefault());
        }

        public async Task<bool> ValidateUser(string username, string password)
        {
            MyUser user = await AsyncGetUserByName(username);
            
            if (user != null)
            {
                string hpwdFromDB = user.HashPassword;
                if(BCrypt.Net.BCrypt.EnhancedVerify(password, hpwdFromDB))
                {
                    return await Task.FromResult(true);
                }
                else
                {
                    return await Task.FromResult(false);
                }

            }
            else
            {
                return false;
            }
        }
    }
}
