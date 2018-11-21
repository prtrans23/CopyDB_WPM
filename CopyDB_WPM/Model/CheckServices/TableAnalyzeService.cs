using CopyDB_WPM.DataBase;
using CopyDB_WPM.DataBase.Factory;
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

        MsManger oriDb;
        MsManger cpyDb;

        public TableAnalyzeService()
        {
            var modelA = ConnetionInfoFactory.GetMsOriginDbInfo();
            oriDb = new MsManger(modelA);

            var modelB = ConnetionInfoFactory.GetMsCopyDbInfo();
            cpyDb = new MsManger(modelB);
        }
        
        public Task<List<string>> RunTask()
        {
            List<string> resultList = GetErrList();
            return Task.FromResult(resultList);
        }

        private List<string> GetErrList()
        {

            return null;
        }


        private DataTable GetTable(bool isOrigin)
        {
            string query = ""
        }


      
    }
}
