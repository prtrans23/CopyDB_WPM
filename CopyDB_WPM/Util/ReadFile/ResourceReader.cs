using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CopyDB_WPM.Util.ReadFile
{
    public static class ResourceReader
    {
        public static string GetTsqlQueryFile(string section, string fileName)
        {
            string path = ResourceFinder.Get_TSQL_Path(section, fileName);
            return System.IO.File.ReadAllText(path);
        }
    }
}
