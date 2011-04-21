using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.Windsor;

namespace CslaDemo.Common.Interfaces
{
    public interface IBusinessService<T>
        where T : class
    {
        void Initialize(IWindsorContainer container);
        bool Save(T objT);
    }
}
