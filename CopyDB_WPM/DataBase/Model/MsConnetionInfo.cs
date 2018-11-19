using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyDB_WPM.DataBase.Model
{
    class MsConnetionInfo
    {

        public string serverName { get; set; }
        public string initialCatalog { get; set; }
        public string identification { get; set; }
        public string password { get; set; }

        
        public string GetConnetionString()
        {
            string buffer;

            buffer =
                $"Data Source = {this.serverName} ;" +
                $"Initial Catalog = {this.initialCatalog} ;" +
                $"User ID =  {this.identification} ;" +
                $"Password = {this.password} ;";

            return buffer;
        }

        private bool CheckInternalDataEmpry()
        {
            bool check =
                string.IsNullOrEmpty(serverName) == true &&
                string.IsNullOrEmpty(initialCatalog) == true &&
                string.IsNullOrEmpty(identification) == true &&
                string.IsNullOrEmpty(password) == true;

            return check;
        }
    }
}
