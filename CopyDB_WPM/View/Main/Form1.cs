using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using CopyDB_WPM.Controller.Main;

namespace CopyDB_WPM
{
    public partial class Form1 : MetroForm
    {
        MainController controller;

        public Form1()
        {
            controller = new MainController(this);
            InitializeComponent();
            CustomComponent();
        }

        
        private void CustomComponent()
        {
            this.metroTile_Origin.Click += new System.EventHandler(controller.CheckAndSetButtonColor);
            this.metroTile_Target.Click += new System.EventHandler(controller.CheckAndSetButtonColor);
            this.metroTile_CheckServer.Click += new System.EventHandler(controller.CheckAndSetButtonColor);
            this.metroTile_Copy.Click += new System.EventHandler(controller.CheckAndSetButtonColor);
            this.metroTile_CheckData.Click += new System.EventHandler(controller.CheckAndSetButtonColor);
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroTile_Origin_Click(object sender, EventArgs e)
        {
            controller.CheckAndClearView();
            controller.OpenSetDataBase(true);
        }

        private void metroTile_Target_Click(object sender, EventArgs e)
        {
            controller.CheckAndClearView();
            controller.OpenSetDataBase(false);
        }

        private void metroTile_CheckServer_Click(object sender, EventArgs e)
        {

        }

        private void metroTile_Copy_Click(object sender, EventArgs e)
        {

        }

        private void metroTile_CheckData_Click(object sender, EventArgs e)
        {

        }

        private void metroTile_Origin_MouseHover(object sender, EventArgs e)
        {

        }

        private void metroTile_Target_MouseHover(object sender, EventArgs e)
        {

        }

        private void metroTile_CheckServer_MouseHover(object sender, EventArgs e)
        {

        }

        private void metroTile_Copy_MouseHover(object sender, EventArgs e)
        {

        }

        private void metroTile_CheckData_MouseHover(object sender, EventArgs e)
        {

        }
    }
}
