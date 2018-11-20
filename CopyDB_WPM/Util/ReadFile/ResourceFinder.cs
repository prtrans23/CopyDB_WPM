using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyDB_WPM.Util.ReadFile
{
    class ResourceFinder
    {
        const string mssql = "TSQL";
        const string mysql = "YSQL";

        public static string Get_TSQL_Path(string section, string FileName)
        {
            return $"{GetResourceDir(mssql)}\\{section}\\{FileName}";
        }

        public static string Get_YSQL_Path(string section, string FileName)
        {
            return $"{GetResourceDir(mysql)}\\{section}\\{FileName}";
        }

        public static string GetResourceDir(string targetDocument)
        {
            string folderPath = AppDomain.CurrentDomain.BaseDirectory;

            switch (targetDocument)
            {
                case mssql: // mssql
                    folderPath += "\\Resources\\Script\\TSQL\\";
                    break;
                case mysql: // mysql
                    folderPath += "\\Resources\\Script\\YSQL\\";
                    break;
            }

            return folderPath;
        }


    }
}
