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
    public partial class ShowDBStatusControl : UserControl
    {
        Controller.SetDbinfoView.ShowDBStatusController controller;

        public ShowDBStatusControl()
        {
            controller = new Controller.SetDbinfoView.ShowDBStatusController(this);
            InitializeComponent();
            controller.Show_Status();
        }


    }
}
