using CopyDB_WPM.DataBase;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyDB_WPM.Controller.SetDbinfoView
{
    class ShowDBStatusController
    {
        private View.Side.ShowDBStatusControl view;
        private Properties.Settings prop;


        public ShowDBStatusController(View.Side.ShowDBStatusControl view)
        {
            this.view = view;
            this.prop = Properties.Settings.Default;
            
        }

        public void Show_Status()
        {
            SetStatusByLable(view.metroLabel_Origin, view.metroTextBox_Origin, GetOriDB());
            SetStatusByLable(view.metroLabel_Copy, view.metroTextBox_Copy, GetCopyDB());
        }

        private void SetStatusByLable(MetroLabel label, MetroTextBox textBox, MsManger db)
        {
            var status = db.CheckConnetion();
            label.Text = status.ToString();
            label.BackColor = GetStatusByColor(status);
            textBox.Text = db.GetConnetionString();
        }

        private Color GetStatusByColor(ConnectionState status)
        {
            Color c;

            switch (status)
            {
                case ConnectionState.Open:
                    c = Color.Green;
                    break;
                default:
                    c = Color.Red;
                    break;
            }

            return c;
        }

        private DataBase.MsManger GetOriDB()
        {
            DataBase.Model.MsConnetionInfo Info = DataBase.Factory.ConnetionInfoFactory.GetMsOriginDbInfo();
            return  new DataBase.MsManger(Info);
        }

        private DataBase.MsManger GetCopyDB()
        {
            DataBase.Model.MsConnetionInfo Info = DataBase.Factory.ConnetionInfoFactory.GetMsCopyDbInfo();
            return new DataBase.MsManger(Info);
        }


    }
}
