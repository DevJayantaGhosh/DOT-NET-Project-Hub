using MySecuredApp.MyUserDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySecuredApp.Services
{
    public interface IMyUserService
    {
        bool AddUser(MyUser myUser);
        Task<bool> AsyncAddUser(MyUser myUser);
        Task<MyUser> AsyncGetUserByName(string userName);
        Task<bool> ValidateUser(string username, string password);
    }
}
