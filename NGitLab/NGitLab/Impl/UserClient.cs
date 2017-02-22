using System.Collections.Generic;
using NGitLab.Models;
using System.Linq;

namespace NGitLab.Impl
{
    public class UserClient : IUserClient
    {
        private readonly API _api;

        public UserClient(API api)
        {
            _api = api;
        }

        public IEnumerable<User> All
        {
            get
            {
                return _api.Get().GetAll<User>(User.Url);
            }
        }

        public User this[int id]
        {
            get
            {
                return _api.Get().To<User>(User.Url + "/" + id);
            }
        }

        public User Create(UserUpsert user)
        {
            return _api.Post().With(user).To<User>(User.Url);
        }

        public User Update(int id, UserUpsert user)
        {
            return _api.Put().With(user).To<User>(User.Url + "/" + id);
        }


        public void ChangePassword(UserChangePassword user)
        {
            var userUpdate = All.Where(u => u.Id == user.Id).First();
            Update(userUpdate.Id, new UserUpsert { Email = userUpdate.Email, Password = user.Password, Username = userUpdate.Username, Name = userUpdate.Name });
        }

        public void Block(int userId)
        {
            _api.Put().With(new UserBlock { Id = userId }).To<bool>(User.Url + "/" + userId + "/block");
        }

        public void UnBlock(int userId)
        {
            _api.Put().With(new UserBlock { Id = userId }).To<bool>(User.Url + "/" + userId + "/unblock");
        }

        public void Delete(int userId)
        {
            _api.Delete().To<User>(User.Url + "/" + userId);
        }

        public int GetUserId(string email)
        {
            return this.All.FirstOrDefault(u => u.Email == email).Id;
        }

        public Session Current
        {
            get
            {
                return _api.Get().To<Session>("/user");
            }
        }
    }
}