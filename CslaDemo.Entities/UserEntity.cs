using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CslaDemo.Entities
{
    [Serializable]
    public class UserEntity
    {
        private int _id;

        private string _username;

        private string _password;

        private IList<BlogEntity> _blogs = new List<BlogEntity>();

        private IList<PostEntity> _posts = new List<PostEntity>();

        public virtual int Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }

        public virtual string Username
        {
            get
            {
                return this._username;
            }
            set
            {
                this._username = value;
            }
        }

        public virtual string Password
        {
            get
            {
                return this._password;
            }
            set
            {
                this._password = value;
            }
        }

        public virtual IList<BlogEntity> Blogs
        {
            get
            {
                return this._blogs;
            }
            set
            {
                this._blogs = value;
            }
        }

        public virtual IList<PostEntity> Posts
        {
            get
            {
                return this._posts;
            }
            set
            {
                this._posts = value;
            }
        }
    }
}
