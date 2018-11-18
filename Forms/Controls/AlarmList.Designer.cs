namespace MouseNet.TinyAlarm.Forms.Controls
{
    partial class AlarmList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Timers", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Alarms", System.Windows.Forms.HorizontalAlignment.Left);
            this._cListView = new System.Windows.Forms.ListView();
            this.NameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TimeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // _cListView
            // 
            this._cListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameHeader,
            this.TimeHeader});
            this._cListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._cListView.FullRowSelect = true;
            listViewGroup1.Header = "Timers";
            listViewGroup1.Name = "TimersGroup";
            listViewGroup2.Header = "Alarms";
            listViewGroup2.Name = "AlarmsGroup";
            this._cListView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this._cListView.LabelEdit = true;
            this._cListView.Location = new System.Drawing.Point(0, 0);
            this._cListView.MultiSelect = false;
            this._cListView.Name = "_cListView";
            this._cListView.Size = new System.Drawing.Size(225, 200);
            this._cListView.TabIndex = 0;
            this._cListView.UseCompatibleStateImageBehavior = false;
            this._cListView.View = System.Windows.Forms.View.Details;
            this._cListView.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.OnAfterLabelEdit);
            this._cListView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.OnColumnWidthChanging);
            // 
            // NameHeader
            // 
            this.NameHeader.Text = "Name";
            this.NameHeader.Width = 150;
            // 
            // TimeHeader
            // 
            this.TimeHeader.Text = "Time";
            this.TimeHeader.Width = 71;
            // 
            // AlarmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._cListView);
            this.Name = "AlarmList";
            this.Size = new System.Drawing.Size(225, 200);
            this.Resize += new System.EventHandler(this.OnResize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView _cListView;
        private System.Windows.Forms.ColumnHeader NameHeader;
        private System.Windows.Forms.ColumnHeader TimeHeader;
    }
}
