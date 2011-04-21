using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CslaDemo.BLL;
using CslaDemo.Common.Interfaces;
using CslaDemo.Entities;

namespace CslaDemo.DefaultImpl.Repositories
{
    public class UserRepository : IRepository<UserEntity>
    {
        private UserBusiness userBusiness = null;

        public UserRepository()
        {
            this.userBusiness = new UserBusiness();
            AppRunner.Initialize();
        }

        public void Insert(UserEntity user)
        {
            this.userBusiness.UserEntity = user;
            this.userBusiness.Save();
        }

        public void Update(UserEntity user)
        {
            this.userBusiness.UserEntity = user;
            this.userBusiness.Save();
        }

        public void Delete(UserEntity user)
        {
            this.userBusiness.UserEntity = user;
            this.userBusiness.Delete();
        }
    }
}
