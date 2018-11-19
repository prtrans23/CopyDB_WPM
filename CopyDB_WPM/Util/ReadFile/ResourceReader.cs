using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CopyDB_WPM.Util.ReadFile
{
    class ResourceReader
    {
        public static string ReadSqlFileToStr(string fileName)
        {
            //var value = Properties.Resources.ResourceManager.GetObject(fileName, Properties.Resources.Culture);

            var type = typeof(Properties.Resources);
            var property = type.GetProperty(fileName, BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);
            var value = property.GetValue(null, null);

            return (string)value;
        }
    }
}
