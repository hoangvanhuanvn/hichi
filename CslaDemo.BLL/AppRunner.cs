using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CslaDemo.Common.Interfaces;
using CastleActiveRecordDemo.Models;

using Castle.ActiveRecord;
using Castle.ActiveRecord.Framework.Config;
using System.Diagnostics;
using System.Reflection;
using System.IO;

namespace CslaDemo.BLL
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
                    Stream appConfigStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("CslaDemo.BLL.Data.appconfig.xml");
                    XmlConfigurationSource source = new XmlConfigurationSource(appConfigStream);
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
