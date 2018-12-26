using System;
using System.Linq;
using NGitLab.Models;
using NUnit.Framework;

namespace NGitLab.Tests
{
    public class UsersTests
    {
        private readonly IUserClient _users;

        public UsersTests()
        {
            _users = Config.Connect().Users;
        }

        [Test]
        [Category("Server_Required")]
        public void Current()
        {
            var session = _users.Current;

            Assert.AreNotEqual(default(DateTime), session.CreatedAt);
            Assert.NotNull(session.Email);
            Assert.NotNull(session.Name);
            Assert.NotNull(session.PrivateToken);
            Assert.NotNull(session.PrivateToken);
        }

        [Test]
        [Category("Server_Required")]
        public void GetUsers()
        {
            var users = _users.All.ToArray();

            CollectionAssert.IsNotEmpty(users);
        }

        [Test]
        [Category("Server_Required")]
        public void GetUser()
        {
            var user = _users[3];

            Assert.AreEqual("dev", user.Username);
            Assert.AreEqual(false, user.CanCreateGroup);
        }

        [Test]
        [Category("Server_Required")]
        public void CreateUpdateDelete()
        {
            var u = new UserUpsert
            {
                Email = "test1@organization1.net",
                CanCreateGroup = true,
                IsAdmin = true,
                Name = "sadfasdf",
                Password = "!@#$QWDRQW@",
                ProjectsLimit = 1000,
                Organization = "organization1.net"
            };

            var addedUser = _users.Create(u);
            Assert.AreEqual(u.Organization, addedUser.Organization);

            u.Organization = "organization1.com";
            u.Email = "test1@organization1.net";

            var updatedUser = _users.Update(addedUser.Id, u);
            Assert.AreEqual(u.Organization, updatedUser.Organization);

            _users.Delete(addedUser.Id);
        }
    }
}