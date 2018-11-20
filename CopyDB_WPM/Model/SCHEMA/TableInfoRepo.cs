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
    class TableInfoRepo
    {
        MsManger db;

        public TableInfoRepo(MsConnetionInfo connInfo)
        {
            db = new MsManger(connInfo);
        }

        public DataTable GetInformationDataTable()
        {
           string query = ResourceReader.GetTsqlQueryFile("System", "InformationSchemaTable.sql");
           return db.Read_DataTable(query);
        }

        public List<TableInfo> GetInformation_Class()
        {
            string query = ResourceReader.GetTsqlQueryFile("System", "InformationSchemaTable.sql");
            return db.Read_Class<TableInfo>(query) as List<TableInfo>;
        }

        public DataTable GetStructInfomation_DataTable(string targetTable)
        {
            string query = ResourceReader.GetTsqlQueryFile("System", "InformationTableStruct.sql");
            query = query.Replace("{targetTable}", targetTable);
            return db.Read_DataTable(query);
        }









    }
}
