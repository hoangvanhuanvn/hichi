using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CslaDemo.Common.Interfaces;
using CslaDemo.Entities;
using Castle.Windsor;
using CslaDemo.BLL;

namespace CslaDemo.DefaultImpl.Services
{
    public class UserService : IBusinessService<UserEntity>
    {
        private IWindsorContainer container = null;

        public void Initialize(IWindsorContainer container)
        {
            this.container = container;
        }

        /// <summary>
        /// Insert/Delete/Update object and related information
        /// </summary>
        /// <param name="userEntity"></param>
        /// <returns></returns>
        public bool Save(UserEntity userEntity)
        {
            IRepository<UserEntity> userRepository = this.container.Resolve<IRepository<UserEntity>>();

            UserBusiness userBusiness = new UserBusiness(userRepository);
            userBusiness.UserEntity = userEntity;
            userBusiness.Save();

            return true;
        }
    }
}
