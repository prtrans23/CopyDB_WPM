using CopyDB_WPM.DataBase;
using CopyDB_WPM.DataBase.Factory;
using CopyDB_WPM.Model.SCHEMA;
using CopyDB_WPM.Util.ExceptionHander;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyDB_WPM.Model.CheckServices
{
    class TableAnalyzeService
    {
        TableInfoRepo oriRepo;
        TableInfoRepo cpyRepo;

        // Results
        List<DataSet> resultTableList;
        List<string> resultNameList; 

        public TableAnalyzeService()
        {
            var oriInfo = ConnetionInfoFactory.GetMsOriginDbInfo();
            oriRepo = new TableInfoRepo(oriInfo);

            var cpyInfo = ConnetionInfoFactory.GetMsCopyDbInfo();
            cpyRepo = new TableInfoRepo(oriInfo);

            resultTableList = new List<DataSet>();
            resultNameList = new List<string>();
        }
        
        // Step 1. Do Task.
        public Task<bool> RunTask()
        {
            bool result = TryTask();
            return Task.FromResult(result);
        }

        // Step 2. Check Has Error
        public bool GetIsHasNotMatchedTable()
        {
            if (resultNameList.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        // Step 3. Get List

        public List<DataSet> Get_DataTable_ErrList()
        {
            return resultTableList;
        }

        public List<string> Get_Name_ErrList()
        {
            return resultNameList;
        }

        #region Task

        private bool TryTask()
        {
            bool result;

            try
            {
                CheckTablesStruct();
                result = true;
            }
            catch (Exception e)
            {
                result = false;
                ExceptionUserHander.NomalExcetionUserHander(e);
            }

            return result;
        }
        

        private void CheckTablesStruct()
        {
            var listOri = oriRepo.GetInformation_Class();
            var listCpy = cpyRepo.GetInformation_Class();

            foreach (TableInfo oInfo in listOri)
            {
                foreach (TableInfo cInfo in listCpy)
                {
                    if (isTableNameMatch(oInfo, cInfo) == true)
                    {
                        AddTableStructNotMatch(oInfo.TABLE_NAME, oriRepo, cpyRepo);
                    }
                }
            }

        }

        private bool isTableNameMatch(TableInfo oInfo, TableInfo cInfo)
        {
            if (oInfo.TABLE_NAME == cInfo.TABLE_NAME)
            {
                return true;
            }

            return false;
        }


        private void AddTableStructNotMatch(string tableName, TableInfoRepo OriTableRepo, TableInfoRepo CpyTableRepo)
        {
            var ori = OriTableRepo.GetStructInfomation_DataTable(tableName);
            var cpy = OriTableRepo.GetStructInfomation_DataTable(tableName);

            if (isTableStructSame(ori, cpy) == false)
            {
                resultNameList.Add(tableName);
                resultTableList.Add(GetTableDataSet(ori, cpy));
            }

        }


        private DataSet GetTableDataSet(DataTable ori, DataTable cpy)
        {
            DataSet ds = new DataSet();

            ori.TableName = "Origin";
            ds.Tables.Add(ori);

            cpy.TableName = "Copy";
            ds.Tables.Add(cpy);

            return ds;
        }


        private bool isTableStructSame(DataTable ori, DataTable cpy)
        {
            for (int i = 0; i < ori.Rows.Count; i++)
            {
                for (int j = 0; j < ori.Columns.Count; j++)
                {
                    if (ori.Rows[i][j].Equals(cpy.Rows[i][j]) == false)
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
