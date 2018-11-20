using CopyDB_WPM.DataBase;
using CopyDB_WPM.DataBase.Model;
using CopyDB_WPM.Util.ReadFile;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyDB_WPM.Model.SCHEMA
{
    class DatabasesInfoRepo
    {
        MsManger db;
        
        public DatabasesInfoRepo(bool isOrigin)
        {
            MsConnetionInfo connInfo;

            connInfo = GetDBInfo(isOrigin);
            db = new MsManger(connInfo);
        }

        private MsConnetionInfo GetDBInfo(bool isOrigin)
        {
            if (isOrigin == true)
                return DataBase.Factory.ConnetionInfoFactory.GetMsOrginMasterDB();
            else
                return DataBase.Factory.ConnetionInfoFactory.GetMsCopyMasterDB();
        }
        
        public DataTable getDbListTable()
        {
            string query = Util.ReadFile.ResourceReader.GetTsqlQueryFile("System", "INformationDblist.sql");
            return db.Read_DataTable(query);
        }

        public List<DataBaseInfo> GetInfomation_ClassList()
        {
            string query = ResourceReader.GetTsqlQueryFile("System", "INformationDblist.sql");
            return db.Read_Class<DataBaseInfo>(query) as List<DataBaseInfo>;
        }

    }
}
