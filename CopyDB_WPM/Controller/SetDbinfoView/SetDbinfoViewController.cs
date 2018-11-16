using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyDB_WPM.Controller.SetDbinfoView
{
    class SetDbinfoViewController
    {
        private View.Side.SetDBInfoView view;
        private Properties.Settings prop;
        private bool isOriginDataBase;

        public SetDbinfoViewController(View.Side.SetDBInfoView view , bool isOrigin)
        {
            this.isOriginDataBase = isOrigin;
            this.view = view;
            this.prop = Properties.Settings.Default;
        }

        
        public void LoadProp()
        {
            if (isOriginDataBase == true)
            {
                LoadOriginProp();
            }
            else
            {
                LoadCopyProp();
            }
        }

        private void LoadOriginProp()
        {
            view.metroLabel_NowPage.Text = "Origin DB Setting";
            view.metroTextBox_Server.Text = prop.origin_DataSource;
            view.metroTextBox_DBname.Text = prop.origin_InitialCatalog;
            view.metroTextBox_id.Text     = prop.origin_UserID;
            view.metroTextBox_PW.Text     = prop.origin_Password;
        }

        private void LoadCopyProp()
        {
            view.metroLabel_NowPage.Text = "Copy DB Setting";
            view.metroTextBox_Server.Text = prop.copy_DataSource;
            view.metroTextBox_DBname.Text = prop.copy_InitialCatalog;
            view.metroTextBox_id.Text     = prop.copy_UserID;
            view.metroTextBox_PW.Text     = prop.copy_Password;
        }



        public void SaveData()
        {
            if (isOriginDataBase == true)
            {
                SaveOrigrin();
            }
            else
            {
                SaveCopyTarget();
            }

            prop.Save();
        }

        private void SaveOrigrin()
        {
            prop.origin_DataSource     = view.metroTextBox_Server.Text;
            prop.origin_InitialCatalog = view.metroTextBox_DBname.Text;
            prop.origin_UserID         = view.metroTextBox_id.Text;
            prop.origin_Password       = view.metroTextBox_PW.Text;
        }

        private void SaveCopyTarget()
        {
            prop.copy_DataSource     = view.metroTextBox_Server.Text;
            prop.copy_InitialCatalog = view.metroTextBox_DBname.Text;
            prop.copy_UserID         = view.metroTextBox_id.Text;
            prop.copy_Password       = view.metroTextBox_PW.Text;
        }




        public void ClearData()
        {
            view.metroTextBox_Server.Text = "";
            view.metroTextBox_DBname.Text = "";
            view.metroTextBox_id.Text = "";
            view.metroTextBox_PW.Text = "";
        }


       

    }
}
