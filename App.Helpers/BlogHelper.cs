using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using CastleActiveRecordDemo.Models;
using CslaDemo.Entities;
using App.Helpers;

namespace App.Helpers
{
    public static class BlogHelper
    {
        public static IList<Blog> ToBlogs(this IList<BlogEntity> blogEntities)
        {
            List<Blog> blogs = new List<Blog>();
            foreach (BlogEntity blogEntityItem in blogEntities)
            {
                blogs.Add(blogEntityItem.ToBlog());
            }

            return blogs;
        }

        public static Blog ToBlog(this BlogEntity blogEntity)
        {
            Blog blogItem = new Blog
            {
                Author = blogEntity.Author,
                Id = blogEntity.Id,
                Name = blogEntity.Name,
                Posts = blogEntity.Posts.ToPosts()
            };

            return blogItem;
        }

        public static void AreCreatedBy(this IList<Blog> blogs, User creator)
        {
            foreach (Blog blogItem in blogs)
            {
                blogItem.IsCreatedBy(creator);
                blogItem.Posts.AreCreatedBy(creator);
            }
        }

        public static void IsCreatedBy(this Blog blog, User creator)
        {
            blog.CreatedBy = creator;
            if (blog.Posts != null)
            {
                blog.Posts.BelongTo(blog);
            }
        }
    }
}
