using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

using Castle.Windsor;
using Castle.Windsor.Installer;
using System.Configuration;
using CslaDemo.Common.Interfaces;
using Castle.MicroKernel.Registration;
using Castle.Windsor.Configuration.Interpreters;
using CslaDemo.Entities;
using Castle.Core.Resource;

namespace CslaDemo.App
{
    class Program
    {
        static void Main(string[] args)
        {
            IResource resource = new AssemblyResource("assembly://CslaDemo.App/Configs/CastleActiveRecordImpl.config");
            //IResource resource = new AssemblyResource("assembly://CslaDemo.App/Configs/DefaultImpl.config");
            IWindsorContainer container = new WindsorContainer(new XmlInterpreter(resource));

            IRepository<UserEntity> userRepository = container.Resolve<IRepository<UserEntity>>();

            IContainerService<UserEntity, PostEntity> userPostContainer = container.Resolve<IContainerService<UserEntity, PostEntity>>();
            IContainerService<UserEntity, BlogEntity> userBlogContainer = container.Resolve<IContainerService<UserEntity, BlogEntity>>();

            IBusinessService<UserEntity> userService = container.Resolve<IBusinessService<UserEntity>>();
            userService.Initialize(container);

            UserEntity localUser = new UserEntity();
            localUser.Username = Guid.NewGuid().ToString();
            localUser.Password = "abc";

            PostEntity p1 = new PostEntity
            {
                Category = "C1",
                Contents = "This is post 1",
                CreatedDate = DateTime.Now,
                Title = "Post1",
            };
            PostEntity p2 = new PostEntity
            {
                Category = "C2",
                Contents = "This is post 2",
                CreatedDate = DateTime.Now,
                Title = "Post2"
            };

            BlogEntity b1 = new BlogEntity
            {
                Author = "Huan",
                Name = "B1"
            };
            BlogEntity b2 = new BlogEntity
            {
                Author = "Huan",
                Name = "B2"
            };

            b1.Posts.Add(p1);
            b2.Posts.Add(p2);

            userBlogContainer.AddTo(localUser, b1, b2);

            userService.Save(localUser);
            Console.WriteLine("Insert... done");
            Console.ReadKey();

            userRepository.Delete(localUser);
            Console.WriteLine("Delete... done");
            Console.ReadKey();
        }
    }
}
