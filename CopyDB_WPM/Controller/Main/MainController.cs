using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyDB_WPM.Controller.Main
{
    class MainController
    {
        // init 
        Form1 form;

        public MainController(Form1 form)
        {
            this.form = form;
        }
        
        public void OpenSetDataBase(bool isOrigin) // -- Origin / Copy
        {
            var myControl = new View.Side.SetDBInfoView(isOrigin);
            form.metroPanel_Target.Controls.Add(myControl);
        }

        public void CheckAndClearView()
        {
            int viewCount = form.metroPanel_Target.Controls.Count;

            if (viewCount >= 1)
            {
                form.metroPanel_Target.Controls.Clear();
            }
        }
        
        public void CheckAndSetButtonColor(object sender, EventArgs e)
        {

            string[] value = sender.ToString().Split(':');
            string text = value[1];

            SetBackColorGrayAll();
            SetOnclickColorChange(text);
        }

        private void SetBackColorGrayAll()
        {
            var color = System.Drawing.Color.DarkGray;

            form.metroTile_Origin.BackColor = color;
            form.metroTile_Target.BackColor = color;
            form.metroTile_Copy.BackColor = color;
            form.metroTile_CheckData.BackColor = color;
            form.metroTile_CheckServer.BackColor = color;
        }

        private void SetOnclickColorChange(string sender)
        {
            var color = System.Drawing.Color.Orange;

            switch (sender)
            {
                case " Set Origin DB":
                    form.metroTile_Origin.BackColor = color;
                    break;
                case " Set Target DB":
                    form.metroTile_Target.BackColor = color;
                    break;
                case " Server Status":
                    form.metroTile_CheckServer.BackColor = color;
                    break;
                case " Copy DB":
                    form.metroTile_Copy.BackColor = color;
                    break;
                case " CheckData":
                    form.metroTile_CheckData.BackColor = color;
                    break;
            }

        }

    }
}
