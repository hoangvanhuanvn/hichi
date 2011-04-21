using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CslaDemo.Entities
{
    [Serializable]
    public class BlogEntity
    {
        private int _id;

        private string _name;

        private string _author;

        private IList<PostEntity> _posts = new List<PostEntity>();

        private UserEntity _createdBy;

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

        public virtual string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }

        public virtual string Author
        {
            get
            {
                return this._author;
            }
            set
            {
                this._author = value;
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

        public virtual UserEntity CreatedBy
        {
            get
            {
                return this._createdBy;
            }
            set
            {
                this._createdBy = value;
            }
        }
    }
}
