using CopyDB_WPM.Model.SCHEMA;
using CopyDB_WPM.Util.InfoRam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyDB_WPM.Util.CheckObj
{
    static class CheckDataBase
    {
        public static bool CheckDBExistByRepo(bool isOrigin)
        {
            DatabasesInfoRepo repo = new DatabasesInfoRepo(isOrigin);
            var list = repo.GetInfomation_ClassList();
            string dbName = ConnetionInfo.GetDataBaseName(isOrigin);
            return CheckDBExist(list, dbName);
        }

        public static bool CheckDBExist(List<DataBaseInfo> infoList, string target)
        {
            foreach (DataBaseInfo info in infoList)
            {
                if (CheckDBinfoCorret(info, target) == true)
                {
                    return true;
                }
            }

            return false;
        }

        private static bool CheckDBinfoCorret(DataBaseInfo info, string target)
        {
            return (info.name == target);   
        }


    }
}
