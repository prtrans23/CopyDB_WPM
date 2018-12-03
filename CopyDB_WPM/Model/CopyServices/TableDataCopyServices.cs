using CopyDB_WPM.DataBase;
using CopyDB_WPM.Model.SCHEMA;
using CopyDB_WPM.Util.ReadFile;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyDB_WPM.Model.CopyServices
{
    class TableDataCopyServices
    {
        /*
            Copy All 
             
        */

        MsManger oriDb;
        MsManger cpyDb;

        public TableDataCopyServices()
        {
            oriDb = new MsManger(DataBase.Factory.ConnetionInfoFactory.GetMsOriginDbInfo());
            cpyDb = new MsManger(DataBase.Factory.ConnetionInfoFactory.GetMsCopyDbInfo());
        }

        public Task<bool> RunTask()
        {
            bool result = TryUpdateData();
            return Task.FromResult(result);
        }

        private bool TryUpdateData()
        {
            bool result;
            
            try
            {
                UpdateTables();
                result = true;
            }
            catch(Exception e)
            {
                result = false;
                Util.ExceptionHander.ExceptionUserHander.NomalExcetionUserHander(e);
            }

            return result;
        }

        private void UpdateTables()
        {
            List<TableInfo> TableList = GetTableList();

            foreach (TableInfo info in TableList)
            {
                if (info.TABLE_NAME != "sysdiagrams") // todo : 필요없는 테이블 리스트와 비교하는 방식으로 갈것.
                {
                    UpdateTable(info);
                }
            }
        }


        private List<TableInfo> GetTableList()
        {
            string query = ResourceReader.GetTsqlQueryFile("System", "InformationSchemaTable.sql");
            return oriDb.Read_Class<TableInfo>(query) as List<TableInfo>;
        }

        private void UpdateTable(TableInfo info)
        {
            DataTable dt = GetOriginData(info.TABLE_NAME);
            TruncateCopyTable(info.TABLE_NAME);
            UpdateCopyTable(dt, info.TABLE_NAME);
        }

        private DataTable GetOriginData(string tableName)
        {
            string query = $"SELECT * FROM {tableName}";
            return oriDb.Read_DataTable(query);
        }

        private void TruncateCopyTable(string tableName)
        {
            string query = $"TRUNCATE TABLE {tableName}";

            if (cpyDb.Try_Write_CUD(query) == false)
            {
                Debug.WriteLine($"Fail TRUNCATE :  {tableName} ");
            }
        }
        
        private void UpdateCopyTable(DataTable dt, string tableName)
        {
            if (cpyDb.Try_Write_Bulk(dt, tableName) == false)
            {
                Debug.WriteLine($"Fail Write_Bulk :  {tableName} ");
            }
        }
        

    }
}
