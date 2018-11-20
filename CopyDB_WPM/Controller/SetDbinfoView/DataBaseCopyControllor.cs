using CopyDB_WPM.DataBase.Factory;
using CopyDB_WPM.Model.SCHEMA;
using CopyDB_WPM.View.Side;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyDB_WPM.Controller.SetDbinfoView
{
    class DataBaseCopyControllor
    {
        DataBaseCopyControl view;

        public DataBaseCopyControllor(DataBaseCopyControl view)
        {
            this.view = view;
        }

        #region Go Analyze

        public void TryAnalyze()
        {
            try
            {
                Analyze();
            }
            catch (Exception e)
            {
                Util.ExceptionHander.ExceptionUserHander.NomalExcetionUserHander(e);
            }
        }

        private void Analyze()
        {
            // Data Base Exist Check
            DataBaseInitCheck();
            // Table Check
            TableCheck();
        }

        private void DataBaseInitCheck()
        {
            DatabasesInfoRepo oriRepo;
            DatabasesInfoRepo cpyRepo;

            DataTable oriDt;
            DataTable cpyDt;

            oriRepo = new DatabasesInfoRepo(true);
            cpyRepo = new DatabasesInfoRepo(false);

            oriDt = oriRepo.getDbListTable();
            cpyDt = cpyRepo.getDbListTable();
        }

        private void TableCheck()
        {
            TableInfoRepo OriTableRepo;
            TableInfoRepo CpyTableRepo;

            OriTableRepo = new TableInfoRepo(ConnetionInfoFactory.GetMsOriginDbInfo());
            CpyTableRepo = new TableInfoRepo(ConnetionInfoFactory.GetMsCopyDbInfo());
        }



        #endregion




    }
}
