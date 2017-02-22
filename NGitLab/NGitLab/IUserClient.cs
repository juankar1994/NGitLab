using System.Collections.Generic;
using NGitLab.Models;

namespace NGitLab
{
    public interface IUserClient
    {
        IEnumerable<User> All { get; }
        User this[int id] { get; }
        User Create(UserUpsert user);
        User Update(int id, UserUpsert user);
        void Delete(int id);
        void ChangePassword(UserChangePassword user);
        void Block(int userId);
        void UnBlock(int userId);
        int GetUserId(string email);
        Session Current { get; }
    }
}