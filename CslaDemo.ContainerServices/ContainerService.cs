using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CslaDemo.Entities;
using CslaDemo.Common.Interfaces;

namespace CslaDemo.ContainerServices
{
    public class ContainerService : IContainerService<UserEntity, PostEntity>, IContainerService<UserEntity, BlogEntity>
    {
        public void AddTo(UserEntity user, params PostEntity[] posts)
        {
            if (posts != null)
            {
                foreach (PostEntity postEntity in posts)
                {
                    postEntity.CreatedBy = user;
                    user.Posts.Add(postEntity);
                }
            }
        }

        public void AddTo(UserEntity user, params BlogEntity[] blogs)
        {
            if (blogs != null)
            {
                foreach (BlogEntity blogEntity in blogs)
                {
                    blogEntity.CreatedBy = user;
                    user.Blogs.Add(blogEntity);
                }
            }
        }
    }
}
