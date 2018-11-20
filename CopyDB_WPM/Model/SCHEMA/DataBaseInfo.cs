using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyDB_WPM.Model.SCHEMA
{
    class DataBaseInfo
    {
        public string name { get; set; }
        public int database_id { get; set; }
        public DateTime create_date { get; set; }
        public string state_desc { get; set; }
    }
}
