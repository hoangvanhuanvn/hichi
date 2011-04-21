using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CslaDemo.Common.Interfaces;
using CastleActiveRecordDemo.Models;

using Castle.ActiveRecord;
using Castle.ActiveRecord.Framework.Config;
using System.IO;
using System.Reflection;
using System.Diagnostics;

namespace CslaDemo.CastleActiveRecordImpl.Repositories
{
    public class AppRunner
    {
        private static bool isInitialize = false;

        /// <summary>
        /// Initliaizes resources
        /// </summary>
        public static bool Initialize()
        {
            try
            {
                if (isInitialize == false)
                {
                    XmlConfigurationSource source = new XmlConfigurationSource("Data/AppConfig.xml");
                    ActiveRecordStarter.Initialize(source, typeof(Blog), typeof(Post), typeof(User));
                    isInitialize = true;
                }

                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return false;
            }
        }
    }
}
