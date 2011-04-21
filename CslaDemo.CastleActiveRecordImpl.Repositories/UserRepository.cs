using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CslaDemo.Common.Interfaces;
using CslaDemo.Entities;
using Castle.ActiveRecord;
using CastleActiveRecordDemo.Models;
using App.Helpers;

namespace CslaDemo.CastleActiveRecordImpl.Repositories
{
    public class UserRepository : IRepository<UserEntity>
    {
        public UserRepository()
        {
            AppRunner.Initialize();
        }

        public void Insert(UserEntity entity)
        {
            User userItem = new User
            {
                Username = entity.Username,
                Password = entity.Password,
                Id = entity.Id,
                Blogs = entity.Blogs.ToBlogs()
            };

            userItem.Blogs.AreCreatedBy(userItem);

            userItem.Save();
            entity.Id = userItem.Id;
        }

        public void Update(UserEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(UserEntity entity)
        {
            User.DeleteAll(new int[] { entity.Id });
        }
    }
}
