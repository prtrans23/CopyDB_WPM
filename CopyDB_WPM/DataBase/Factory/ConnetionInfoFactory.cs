using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyDB_WPM.DataBase.Factory
{
    class ConnetionInfoFactory
    {
        private Properties.Settings prop;

        public ConnetionInfoFactory()
        {
            this.prop = Properties.Settings.Default;
        }


        public Model.MsConnetionInfo GetMsOriginDbInfo()
        {
            Model.MsConnetionInfo model = new Model.MsConnetionInfo();

            model.serverName = prop.origin_DataSource;
            model.initialCatalog = prop.origin_InitialCatalog;
            model.identification = prop.origin_UserID;
            model.password = prop.origin_Password;
            
            return model;
        }

        public Model.MsConnetionInfo GetMsCopyDbInfo()
        {
            Model.MsConnetionInfo model = new Model.MsConnetionInfo();

            model.serverName = prop.copy_DataSource;
            model.initialCatalog = prop.copy_InitialCatalog;
            model.identification = prop.copy_UserID;
            model.password = prop.copy_Password;

            return model;
        }


    }
}
