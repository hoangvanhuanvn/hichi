using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CslaDemo.CastleActiveRecordImpl.Services;
using CslaDemo.Common.Interfaces;
using CslaDemo.Entities;

namespace CslaDemo.CastleActiveRecordImpl.TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(IContainerService<UserEntity, PostEntity>);
        }
    }
}
