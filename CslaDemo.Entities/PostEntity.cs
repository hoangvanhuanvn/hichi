using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CslaDemo.Entities
{
    [Serializable]
    public class PostEntity
    {
        private int _id;

        private string _title;

        private string _contents;

        private string _category;

        private System.DateTime _createdDate;

        private BlogEntity _blog;

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

        public virtual string Title
        {
            get
            {
                return this._title;
            }
            set
            {
                this._title = value;
            }
        }

        public virtual string Contents
        {
            get
            {
                return this._contents;
            }
            set
            {
                this._contents = value;
            }
        }

        public virtual string Category
        {
            get
            {
                return this._category;
            }
            set
            {
                this._category = value;
            }
        }

        public virtual System.DateTime CreatedDate
        {
            get
            {
                return this._createdDate;
            }
            set
            {
                this._createdDate = value;
            }
        }

        public virtual BlogEntity Blog
        {
            get
            {
                return this._blog;
            }
            set
            {
                this._blog = value;
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
