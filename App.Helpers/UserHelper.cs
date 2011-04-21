using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CastleActiveRecordDemo.Models;
using CslaDemo.Entities;

namespace App.Helpers
{
    public static class UserHelper
    {
        public static User ToUser(this UserEntity userEntity)
        {
            User userItem = new User
            {
                Username = userEntity.Username,
                Password = userEntity.Password,
                Id = userEntity.Id
            };

            return userItem;
        }
    }
}
