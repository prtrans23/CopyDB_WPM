using CopyDB_WPM.DataBase.Factory;
using CopyDB_WPM.Model.SCHEMA;
using CopyDB_WPM.Util.CheckObj;
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
            ClearAnalizeTextBox();

            // Data Base Exist Check
            if (DataBaseInitCheck() == false)
            {
                return;
            }

            // Table Check
            if (TableNameCheck() == false)
            {
                return;
            }

            // Table Same?
            if (TableStructCheck() == false)
            {
                return;
            }

        }

        private bool DataBaseInitCheck()
        {
            bool isExistOrigin;
            bool isExistCopy;

            isExistOrigin = CheckDataBase.CheckDBExistByRepo(true);
            isExistCopy = CheckDataBase.CheckDBExistByRepo(false);

            if (isExistOrigin == true)
            {
                WriteAnalizeTextBox("Origin DataBase Exist");
            }
            else
            {
                WriteAnalizeTextBox("Origin DataBase Doesn`t Exist");
                return false;
            }

            if (isExistCopy == true)
            {
                WriteAnalizeTextBox("Copy DataBase Exist");
            }
            else
            {
                WriteAnalizeTextBox("Copy DataBase Doesn`t Exist");
            }
            
            return true;
        }

        private bool TableNameCheck()
        {
            bool isMatchTableNames = CheckTable.IsMatchTableData();


            if (isMatchTableNames == true)
            {
                WriteAnalizeTextBox("Tables Name All Matched Data");
            }
            else
            {
                WriteAnalizeTextBox("Tables Name Not Matched");
                ErrorTableUpdate();
                return false;
            }

            return true;
        }

        private void ErrorTableUpdate()
        {
            var list = CheckTable.GetNotMatchTableData();

            foreach (string data in list)
            {
                WriteAnalizeTextBox($"{data} Table Can`t find");
            }
        }



        private bool TableStructCheck()
        {
            List<string> list = CheckTable.CheckTablesStruct();

            if (list.Count <=  0)
            {
                WriteAnalizeTextBox($"All Table Struct Matched");
                return true;
            }
            else
            {
                ErrorTableStructUpdate(list);
                return false;
            }
            
        }

        private void ErrorTableStructUpdate(List<string> list)
        {
            foreach (string data in list)
            {
                WriteAnalizeTextBox($"{data} Table Struct didn`t Match");
            }
        } 



        #endregion


        #region AnalizeBox Text

        public void WriteAnalizeTextBox(string msg)
        {
            view.WriteAnalizeTextBox(msg + Environment.NewLine);
        }

        public void ClearAnalizeTextBox()
        {
            view.ClearAnalizeTextBox();
        }

        #endregion



    }
}
