using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CslaDemo.Common.Interfaces
{
    public interface IContainerService<ContainerType, SubType>
        where ContainerType : class
        where SubType : class
    {
        /// <summary>
        /// Add some objects into a container object
        /// </summary>
        /// <param name="mainObject"></param>
        /// <param name="objects"></param>
        void AddTo(ContainerType mainObject, params SubType[] objects);
    }
}
