using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyDB_WPM.Util.InfoRam
{
    static class ConnetionInfo
    {
        private static Properties.Settings prop = Properties.Settings.Default;

        public static string GetDataBaseName(bool isOrigrin)
        {
            if (isOrigrin == true)
            {
                return prop.origin_InitialCatalog;
            }
            else
            {
                return prop.copy_InitialCatalog;
            }
        }


    }
}
