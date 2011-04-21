using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CastleActiveRecordDemo.Models;
using CslaDemo.Entities;

namespace App.Helpers
{
    public static class PostHelper
    {
        public static IList<Post> ToPosts(this IList<PostEntity> postEntities)
        {
            List<Post> posts = new List<Post>();
            foreach (PostEntity postEntityItem in postEntities)
            {
                posts.Add(postEntityItem.ToPost());
            }

            return posts;
        }

        public static Post ToPost(this PostEntity postEntity)
        {
            Post postItem = new Post
            {
                Category = postEntity.Category,
                Contents = postEntity.Contents,
                CreatedDate = postEntity.CreatedDate,
                Id = postEntity.Id,
                Title = postEntity.Title
            };

            return postItem;
        }

        public static void AreCreatedBy(this IList<Post> posts, User creator)
        {
            foreach (Post postItem in posts)
            {
                postItem.CreatedBy = creator;
            }
        }

        public static void BelongTo(this IList<Post> posts, Blog blog)
        {
            foreach (Post postItem in posts)
            {
                postItem.Blog = blog;
            }
        }
    }
}
