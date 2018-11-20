using CopyDB_WPM.DataBase.Factory;
using CopyDB_WPM.Model.SCHEMA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyDB_WPM.Util.CheckObj
{
    static class CheckTable
    {

        public static bool IsMatchTableData()
        {
            List<string> data = GetNotMatchTableData();

            if (data.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static List<string> GetNotMatchTableData()
        {
            TableInfoRepo OriTableRepo = new TableInfoRepo(ConnetionInfoFactory.GetMsOriginDbInfo());
            TableInfoRepo CpyTableRepo = new TableInfoRepo(ConnetionInfoFactory.GetMsCopyDbInfo());
            
            var listOri = OriTableRepo.GetInformation_Class();
            var listCpy = CpyTableRepo.GetInformation_Class();
            
            return GetErrorList(listOri, listCpy);
        }

        private static List<string> GetErrorList(List<TableInfo> oriList, List<TableInfo> cpyList)
        {
            List<string> tmp = new List<string>();

            foreach(TableInfo info in oriList)
            {
                if (IsExistTable(info, cpyList) == false)
                {
                    tmp.Add(info.TABLE_NAME);
                }
            }

            return tmp;
        }

        private static bool IsExistTable(TableInfo origin , List<TableInfo> cpyList)
        {
            foreach(TableInfo info in cpyList)
            {
                if (origin.TABLE_NAME == info.TABLE_NAME)
                {
                    return true;
                }
                else if (origin.TABLE_NAME == "sysdiagrams")
                {
                    return true;
                }
            }

            return false;
        }



        #region CheckTablesStruct
        
        
        public static List<string> CheckTablesStruct()
        {
            TableInfoRepo OriTableRepo = new TableInfoRepo(ConnetionInfoFactory.GetMsOriginDbInfo());
            TableInfoRepo CpyTableRepo = new TableInfoRepo(ConnetionInfoFactory.GetMsCopyDbInfo());
            List<string> list = new List<string>();

            var listOri = OriTableRepo.GetInformation_Class();
            var listCpy = CpyTableRepo.GetInformation_Class();

            foreach (TableInfo oInfo in listOri)
            {
                foreach (TableInfo cInfo in listCpy)
                {
                    if (oInfo.TABLE_NAME == cInfo.TABLE_NAME)
                    {
                        bool  x = CheckTableStruct(oInfo.TABLE_NAME, OriTableRepo, CpyTableRepo);

                        if (x == false)
                        {
                            list.Add(oInfo.TABLE_NAME);
                        }
                    }
                }
            }

            return list;
        }

        private static bool CheckTableStruct(
            string tableName, TableInfoRepo OriTableRepo, TableInfoRepo CpyTableRepo)
        {
            DataTable oriInfo = OriTableRepo.GetStructInfomation_DataTable(tableName);
            DataTable cpyInfo = CpyTableRepo.GetStructInfomation_DataTable(tableName);

            return TryIsTableSame(oriInfo, cpyInfo);
        }

        private static bool TryIsTableSame(DataTable oriInfo, DataTable cpyInfo)
        {
            bool value = true;

            try
            {
                value = IsTableSame(oriInfo, cpyInfo);
            }
            catch
            {
                return false;
            }

            return value;
        }

        private static bool IsTableSame(DataTable oriInfo, DataTable cpyInfo)
        {
            for (int i = 0; i < oriInfo.Rows.Count; i++)
            {
                for (int j = 0; j < oriInfo.Columns.Count; j++)
                {
                    if (oriInfo.Rows[i][j].Equals(cpyInfo.Rows[i][j]) == false)
                    {
                        return false;
                    }
                }
            }

            return true;
        }



        #endregion






    }
}
