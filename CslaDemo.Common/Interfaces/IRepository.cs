using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CslaDemo.Common.Interfaces
{
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// Insert object
        /// </summary>
        /// <param name="objT"></param>
        void Insert(T objT);

        /// <summary>
        /// Update object
        /// </summary>
        /// <param name="objT"></param>
        void Update(T objT);

        /// <summary>
        /// Delete object
        /// </summary>
        /// <param name="objT"></param>
        void Delete(T objT);
    }
}
