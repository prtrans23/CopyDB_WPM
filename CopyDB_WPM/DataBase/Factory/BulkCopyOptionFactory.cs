using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyDB_WPM.DataBase.Factory
{
    class BulkCopyOptionFactory
    {
        public static SqlBulkCopy Mssql_NomalOption(SqlConnection connection)
        {
            return new SqlBulkCopy
            (
                connection,
                SqlBulkCopyOptions.TableLock |
                SqlBulkCopyOptions.FireTriggers |
                SqlBulkCopyOptions.UseInternalTransaction,
                null
            );
        }

        public static SqlBulkCopy Mssql_NonTrigerOption(SqlConnection connection)
        {
            return new SqlBulkCopy
            (
                connection,
                SqlBulkCopyOptions.TableLock |
                SqlBulkCopyOptions.UseInternalTransaction,
                null
            );
        }

    }
}
