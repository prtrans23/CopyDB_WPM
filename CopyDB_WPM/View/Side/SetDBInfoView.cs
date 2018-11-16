using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyDB_WPM.View.Side
{
    public partial class SetDBInfoView : MetroFramework.Controls.MetroUserControl
    {
        Controller.SetDbinfoView.SetDbinfoViewController controller;


        public SetDBInfoView(bool isOrigin)
        {
            InitializeComponent();
            controller = new Controller.SetDbinfoView.SetDbinfoViewController(this, isOrigin);
            controller.LoadProp();
        }

        private void SetDBInfoView_Load(object sender, EventArgs e)
        {

        }

        private void metroButton_Save_Click(object sender, EventArgs e)
        {
            controller.SaveData();
        }

        private void metroButton_Clear_Click(object sender, EventArgs e)
        {
            controller.ClearData();
        }

        private void metroTextBox_Server_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
