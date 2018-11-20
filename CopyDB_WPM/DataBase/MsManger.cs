using CopyDB_WPM.DataBase.Factory;
using CopyDB_WPM.Util.ExceptionHander;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyDB_WPM.DataBase
{
    class MsManger
    {
        Model.MsConnetionInfo connetionInfo;
        string connetionString;

        public MsManger(Model.MsConnetionInfo connetionInfo)
        {
            this.connetionInfo = connetionInfo;
            this.connetionString = connetionInfo.GetConnetionString();
        }

        public string GetConnetionString()
        {
            return connetionString;
        }

       

        public ConnectionState CheckConnetion()
        {
            ConnectionState state;

            using (SqlConnection connection = new SqlConnection(connetionString))
            {
                connection.Open();
                state = connection.State;
            }

            return state;
        }



        // Nomal Option (Non Try)

        #region Create Update Delete

        public void Write_CUD(string query) 
        {
            using (SqlConnection connection = new SqlConnection(connetionString))
            {
                connection.Open();
                ExcuteNonQuery(query, connection);
            }
        }
        
        private void ExcuteNonQuery(string query, SqlConnection connection)
        {
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        #endregion


        #region Read DataTable
        public DataTable Read_DataTable(string query)
        {
            DataTable dataTable = null;

            using (SqlConnection connection = new SqlConnection(connetionString))
            {
                connection.Open();
                dataTable = ExcuteDataTableCmd(query, connection);
            }

            return dataTable;
        }

        private DataTable ExcuteDataTableCmd(string query, SqlConnection connection)
        {
            DataTable dataTable = null;

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                dataTable = GetDataTable(command);
            }

            return dataTable;
        }

        private DataTable GetDataTable(SqlCommand command)
        {
            DataTable dataTable = new DataTable();

            using (SqlDataAdapter da = new SqlDataAdapter(command))
            {
                dataTable.BeginLoadData();
                da.Fill(dataTable);
                dataTable.EndLoadData();
            }

            return dataTable;
        }
        #endregion


        #region Read Scalar
        public object Read_Scalar(string query)
        {
            object obj = null;

            using (SqlConnection connection = new SqlConnection(connetionString))
            {
                connection.Open();
                obj = ExcuteObjectCmd(query, connection);
            }

            return obj;
        }

        private object ExcuteObjectCmd(string query, SqlConnection connection)
        {
            object obj = null;

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                obj = command.ExecuteScalar();
            }

            return obj;
        }

        #endregion


        #region Bulk Upload

        public void Write_Bulk(DataTable dt, string targetTable)
        {
            using (SqlConnection connection = new SqlConnection(connetionString))
            {
                connection.Open();
                BulkCopy(dt, targetTable, connection);
            }
        }

        private void BulkCopy(DataTable dt, string targetTable, SqlConnection connection)
        {
            SqlBulkCopy bulkCopy = BulkCopyOptionFactory.Mssql_NomalOption(connection);
            bulkCopy.DestinationTableName = targetTable;
            bulkCopy.WriteToServer(dt);
        }

        #endregion

        
        #region Dapper
        public object Read_Class<T>(string query)
        {
            SqlConnection connection = new SqlConnection(connetionString);
            return connection.Query<T>(query).ToList();
        }
        #endregion


        #region Try Catch Option
        public bool Try_Write_CUD(string query)
        {
            try
            {
                Write_CUD(query);
            }
            catch (Exception e)
            {
                SqlExcetionUserHander(e);
                return false;
            }

            return true;
        }

        public bool Try_Write_Bulk(DataTable dt, string targetTable)
        {
            try
            {
                Write_Bulk(dt, targetTable);
            }
            catch (Exception e)
            {
                SqlExcetionUserHander(e);
                return false;
            }

            return true;
        }


        public bool Try_Read_DataTable(string query, DataTable dataTable)
        {
            try
            {
                dataTable = Read_DataTable(query);
            }
            catch (Exception e)
            {
                SqlExcetionUserHander(e);
                return false;
            }

            return true;
        }

        public bool Try_Read_Scalar(string query, object obj)
        {
            try
            {
                obj = Read_Scalar(query);
            }
            catch(Exception e)
            {
                SqlExcetionUserHander(e);
                return false;
            }

            return true;
        }

        public bool Try_Read_Class<T>(string query, List<T> obj)
        {
            try
            {
                obj = Read_Class<T>(query) as List<T>;
            }
            catch (Exception e)
            {
                SqlExcetionUserHander(e);
                return false;
            }

            return false;
        }


        #endregion

        public void SqlExcetionUserHander(Exception e)
        {
            ExceptionUserHander.SqlExcetionUserHander(e);
        }
    }
}
