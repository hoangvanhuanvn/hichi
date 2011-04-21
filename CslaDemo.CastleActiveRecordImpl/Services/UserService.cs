using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CslaDemo.Common.Interfaces;
using CslaDemo.Entities;

using Castle.ActiveRecord;
using CastleActiveRecordDemo.Models;
using Castle.Windsor;
using App.Helpers;

namespace CslaDemo.CastleActiveRecordImpl.Services
{
    public class UserService : IBusinessService<UserEntity>
    {
        private IWindsorContainer container = null;
        private IRepository<UserEntity> userRepository = null;

        public void Initialize(IWindsorContainer container)
        {
            this.container = container;
            this.userRepository = container.Resolve<IRepository<UserEntity>>();
        }

        /// <summary>
        /// Insert/Delete/Update object and related information
        /// </summary>
        /// <param name="userEntity"></param>
        /// <returns></returns>
        public bool Save(UserEntity userEntity)
        {
            bool result = false;

            using (var ts = new TransactionScope(OnDispose.Commit))
            {
                // Save user
                if (userEntity.Id > 0)
                {
                    userRepository.Update(userEntity);
                }
                else
                {
                    userRepository.Insert(userEntity);
                }

                ts.Flush();
                result = true;
            }

            return result;
        }
    }
}
