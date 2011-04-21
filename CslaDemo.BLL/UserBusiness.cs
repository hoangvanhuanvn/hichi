using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Csla;
using CslaDemo.Common.Interfaces;
using CslaDemo.Entities;
using CastleActiveRecordDemo.Models;

namespace CslaDemo.BLL
{
    [Serializable]
    public class UserBusiness : BusinessBase<UserBusiness>
    {
        private UserEntity userEntity = null;
        private IRepository<UserEntity> userRepository = null;

        public UserBusiness(IRepository<UserEntity> userRepository)
        {
            this.userRepository = userRepository;
        }

        public virtual UserEntity UserEntity
        {
            get { return userEntity; }
            set { userEntity = value; }
        }

        protected override void DataPortal_Insert()
        {
            this.userRepository.Insert(userEntity);
        }

        protected override void DataPortal_Update()
        {
        }
    }
}
