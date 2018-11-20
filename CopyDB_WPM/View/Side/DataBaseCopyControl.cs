using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CopyDB_WPM.Controller.SetDbinfoView;
using MetroFramework.Controls;
namespace CopyDB_WPM.View.Side
{
    public partial class DataBaseCopyControl : MetroFramework.Controls.MetroUserControl
    {
        DataBaseCopyControllor controller;

        public DataBaseCopyControl()
        {
            controller = new DataBaseCopyControllor(this);
            InitializeComponent();
            MouseHoverEvent();
            MouseLeaveEvent();
        }

        #region Mouse Event

        private void MouseHoverEvent()
        {
            metroTile_CopyOnlyData.MouseHover += CopyButtonMouseHover;
        }

        private void MouseLeaveEvent()
        {
            metroTile_CopyOnlyData.MouseLeave += CopyButtonMouseLeaveEvent;
        }

        private void CopyButtonMouseHover(object sender, EventArgs e)
        {
            MetroTile tile = sender as MetroTile;
            tile.BackColor = Color.Beige;
        }

        private void CopyButtonMouseLeaveEvent(object sender, EventArgs e)
        {
            MetroTile tile = sender as MetroTile;
            tile.BackColor = Color.SeaGreen;
        }

        #endregion

        private void metroTile_GoAnalyze_Click(object sender, EventArgs e)
        {
            controller.TryAnalyze();
        }
    }
}
