namespace CopyDB_WPM
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroPanel_Target = new MetroFramework.Controls.MetroPanel();
            this.metroTile_Target = new MetroFramework.Controls.MetroTile();
            this.metroTile_CheckData = new MetroFramework.Controls.MetroTile();
            this.metroTile_CheckServer = new MetroFramework.Controls.MetroTile();
            this.metroTile_Copy = new MetroFramework.Controls.MetroTile();
            this.metroTile_Origin = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroPanel_Target
            // 
            this.metroPanel_Target.HorizontalScrollbarBarColor = true;
            this.metroPanel_Target.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel_Target.HorizontalScrollbarSize = 10;
            this.metroPanel_Target.Location = new System.Drawing.Point(39, 143);
            this.metroPanel_Target.Name = "metroPanel_Target";
            this.metroPanel_Target.Size = new System.Drawing.Size(600, 350);
            this.metroPanel_Target.TabIndex = 1;
            this.metroPanel_Target.VerticalScrollbarBarColor = true;
            this.metroPanel_Target.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel_Target.VerticalScrollbarSize = 10;
            // 
            // metroTile_Target
            // 
            this.metroTile_Target.ActiveControl = null;
            this.metroTile_Target.BackColor = System.Drawing.Color.DarkGray;
            this.metroTile_Target.Location = new System.Drawing.Point(189, 63);
            this.metroTile_Target.Name = "metroTile_Target";
            this.metroTile_Target.Size = new System.Drawing.Size(95, 74);
            this.metroTile_Target.TabIndex = 0;
            this.metroTile_Target.TabStop = false;
            this.metroTile_Target.Text = "Set Target DB";
            this.metroTile_Target.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile_Target.TileImage = global::CopyDB_WPM.Properties.Resources.icons8_add_database_26;
            this.metroTile_Target.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile_Target.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroTile_Target.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile_Target.UseCustomBackColor = true;
            this.metroTile_Target.UseCustomForeColor = true;
            this.metroTile_Target.UseSelectable = true;
            this.metroTile_Target.UseTileImage = true;
            this.metroTile_Target.Click += new System.EventHandler(this.metroTile_Target_Click);
            this.metroTile_Target.MouseHover += new System.EventHandler(this.metroTile_Target_MouseHover);
            // 
            // metroTile_CheckData
            // 
            this.metroTile_CheckData.ActiveControl = null;
            this.metroTile_CheckData.BackColor = System.Drawing.Color.DarkGray;
            this.metroTile_CheckData.Location = new System.Drawing.Point(492, 63);
            this.metroTile_CheckData.Name = "metroTile_CheckData";
            this.metroTile_CheckData.Size = new System.Drawing.Size(95, 74);
            this.metroTile_CheckData.TabIndex = 0;
            this.metroTile_CheckData.TabStop = false;
            this.metroTile_CheckData.Text = "CheckData";
            this.metroTile_CheckData.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile_CheckData.TileImage = global::CopyDB_WPM.Properties.Resources.icons8_database_view_26;
            this.metroTile_CheckData.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile_CheckData.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroTile_CheckData.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile_CheckData.UseCustomBackColor = true;
            this.metroTile_CheckData.UseCustomForeColor = true;
            this.metroTile_CheckData.UseSelectable = true;
            this.metroTile_CheckData.UseTileImage = true;
            this.metroTile_CheckData.Click += new System.EventHandler(this.metroTile_CheckData_Click);
            this.metroTile_CheckData.MouseHover += new System.EventHandler(this.metroTile_CheckData_MouseHover);
            // 
            // metroTile_CheckServer
            // 
            this.metroTile_CheckServer.ActiveControl = null;
            this.metroTile_CheckServer.BackColor = System.Drawing.Color.DarkGray;
            this.metroTile_CheckServer.Location = new System.Drawing.Point(290, 63);
            this.metroTile_CheckServer.Name = "metroTile_CheckServer";
            this.metroTile_CheckServer.Size = new System.Drawing.Size(95, 74);
            this.metroTile_CheckServer.TabIndex = 0;
            this.metroTile_CheckServer.TabStop = false;
            this.metroTile_CheckServer.Text = "Server Status";
            this.metroTile_CheckServer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile_CheckServer.TileImage = global::CopyDB_WPM.Properties.Resources.icons8_server_26;
            this.metroTile_CheckServer.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile_CheckServer.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroTile_CheckServer.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile_CheckServer.UseCustomBackColor = true;
            this.metroTile_CheckServer.UseCustomForeColor = true;
            this.metroTile_CheckServer.UseSelectable = true;
            this.metroTile_CheckServer.UseTileImage = true;
            this.metroTile_CheckServer.Click += new System.EventHandler(this.metroTile_CheckServer_Click);
            this.metroTile_CheckServer.MouseHover += new System.EventHandler(this.metroTile_CheckServer_MouseHover);
            // 
            // metroTile_Copy
            // 
            this.metroTile_Copy.ActiveControl = null;
            this.metroTile_Copy.BackColor = System.Drawing.Color.DarkGray;
            this.metroTile_Copy.Location = new System.Drawing.Point(391, 63);
            this.metroTile_Copy.Name = "metroTile_Copy";
            this.metroTile_Copy.Size = new System.Drawing.Size(95, 74);
            this.metroTile_Copy.TabIndex = 0;
            this.metroTile_Copy.TabStop = false;
            this.metroTile_Copy.Text = "Copy DB";
            this.metroTile_Copy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile_Copy.TileImage = global::CopyDB_WPM.Properties.Resources.icons8_data_recovery_26;
            this.metroTile_Copy.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile_Copy.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile_Copy.UseCustomBackColor = true;
            this.metroTile_Copy.UseCustomForeColor = true;
            this.metroTile_Copy.UseSelectable = true;
            this.metroTile_Copy.UseTileImage = true;
            this.metroTile_Copy.Click += new System.EventHandler(this.metroTile_Copy_Click);
            this.metroTile_Copy.MouseHover += new System.EventHandler(this.metroTile_Copy_MouseHover);
            // 
            // metroTile_Origin
            // 
            this.metroTile_Origin.ActiveControl = null;
            this.metroTile_Origin.BackColor = System.Drawing.Color.DarkGray;
            this.metroTile_Origin.Location = new System.Drawing.Point(88, 63);
            this.metroTile_Origin.Name = "metroTile_Origin";
            this.metroTile_Origin.Size = new System.Drawing.Size(95, 74);
            this.metroTile_Origin.TabIndex = 0;
            this.metroTile_Origin.TabStop = false;
            this.metroTile_Origin.Text = "Set Origin DB";
            this.metroTile_Origin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile_Origin.TileImage = global::CopyDB_WPM.Properties.Resources.icons8_database_administrator_26;
            this.metroTile_Origin.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile_Origin.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroTile_Origin.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile_Origin.UseCustomBackColor = true;
            this.metroTile_Origin.UseCustomForeColor = true;
            this.metroTile_Origin.UseSelectable = true;
            this.metroTile_Origin.UseTileImage = true;
            this.metroTile_Origin.Click += new System.EventHandler(this.metroTile_Origin_Click);
            this.metroTile_Origin.MouseHover += new System.EventHandler(this.metroTile_Origin_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 517);
            this.Controls.Add(this.metroPanel_Target);
            this.Controls.Add(this.metroTile_Copy);
            this.Controls.Add(this.metroTile_CheckServer);
            this.Controls.Add(this.metroTile_CheckData);
            this.Controls.Add(this.metroTile_Target);
            this.Controls.Add(this.metroTile_Origin);
            this.Name = "Form1";
            this.Text = "DB Copy Service";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        internal MetroFramework.Controls.MetroPanel metroPanel_Target;
        internal MetroFramework.Controls.MetroTile metroTile_Origin;
        internal MetroFramework.Controls.MetroTile metroTile_Target;
        internal MetroFramework.Controls.MetroTile metroTile_CheckData;
        internal MetroFramework.Controls.MetroTile metroTile_CheckServer;
        internal MetroFramework.Controls.MetroTile metroTile_Copy;
    }
}

