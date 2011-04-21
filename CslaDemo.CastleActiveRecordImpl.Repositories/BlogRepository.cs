using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CslaDemo.Common.Interfaces;
using CslaDemo.Entities;
using CastleActiveRecordDemo.Models;
using App.Helpers;

namespace CslaDemo.CastleActiveRecordImpl.Repositories
{
    public class BlogRepository : IRepository<BlogEntity>
    {
        public BlogRepository()
        {
            AppRunner.Initialize();
        }

        public void Insert(BlogEntity entity)
        {
            Blog blogItem = new Blog
            {
                Author = entity.Author,
                Id = entity.Id,
                Name = entity.Name,
                CreatedBy = User.Find(entity.CreatedBy.Id)
            };
            blogItem.Save();

            entity.Id = blogItem.Id;
        }

        public void Update(BlogEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(BlogEntity entity)
        {
            Blog.DeleteAll(new int[] { entity.Id });
        }
    }
}
