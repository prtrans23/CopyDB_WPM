using CopyDB_WPM.DataBase;
using CopyDB_WPM.DataBase.Factory;
using CopyDB_WPM.Util.ExceptionHander;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyDB_WPM.Model.CopyServices
{
    class DataBaseCopyService
    {
        /*
            Use Only Create Database.
        */

        MsManger db;
        string targetDataBase;

        public DataBaseCopyService()
        {
            var model = ConnetionInfoFactory.GetMsCopyMasterDB();
            db = new MsManger(model);
            targetDataBase = model.initialCatalog;
        }

        public Task<bool> CopyDataBaseTask()
        {
            bool result = TryCopyDataBase();
            return Task.FromResult(result);
        }

        private bool TryCopyDataBase()
        {
            bool result = false;

            try
            {
                CopyDataBase();
                result = true;
            }
            catch (Exception e)
            {
                ExceptionUserHander.SqlExcetionUserHander(e);
            }

            return result;
        }

        private void CopyDataBase()
        {
            string query = Util.ReadFile.ResourceReader.GetTsqlQueryFile("System", "CreateDataBase.sql");
            query = query.Replace("{dbName}", targetDataBase);
            db.Write_CUD(query);
        }
        


    }
}
