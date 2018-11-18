using MouseNet.TinyAlarm.Forms.Controls;

namespace MouseNet.TinyAlarm.Forms
{
    partial class NewAlarmForm
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
            this._lblType = new System.Windows.Forms.Label();
            this._cRepeatCheckbox = new System.Windows.Forms.CheckBox();
            this._lblName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this._cTimerConfig = new MouseNet.TinyAlarm.Forms.Controls.TimerConfig();
            this._cAlarmConfig = new MouseNet.TinyAlarm.Forms.Controls.AlarmConfig();
            this._cType = new MouseNet.Forms.Controls.RadioButtonGroup();
            this.alertOptions1 = new MouseNet.TinyAlarm.Forms.Controls.AlertOptions();
            this.SuspendLayout();
            // 
            // _lblType
            // 
            this._lblType.AutoSize = true;
            this._lblType.Location = new System.Drawing.Point(209, 9);
            this._lblType.Name = "_lblType";
            this._lblType.Size = new System.Drawing.Size(34, 13);
            this._lblType.TabIndex = 1;
            this._lblType.Text = "Type:";
            // 
            // _cRepeatCheckbox
            // 
            this._cRepeatCheckbox.AutoSize = true;
            this._cRepeatCheckbox.Location = new System.Drawing.Point(142, 39);
            this._cRepeatCheckbox.Name = "_cRepeatCheckbox";
            this._cRepeatCheckbox.Size = new System.Drawing.Size(61, 17);
            this._cRepeatCheckbox.TabIndex = 2;
            this._cRepeatCheckbox.Text = "Repeat";
            this._cRepeatCheckbox.UseVisualStyleBackColor = true;
            // 
            // _lblName
            // 
            this._lblName.AutoSize = true;
            this._lblName.Location = new System.Drawing.Point(12, 9);
            this._lblName.Name = "_lblName";
            this._lblName.Size = new System.Drawing.Size(38, 13);
            this._lblName.TabIndex = 7;
            this._lblName.Text = "Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 20);
            this.textBox1.TabIndex = 8;
            // 
            // _cTimerConfig
            // 
            this._cTimerConfig.AutoSize = true;
            this._cTimerConfig.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._cTimerConfig.Interval = System.TimeSpan.Parse("00:00:00");
            this._cTimerConfig.Location = new System.Drawing.Point(15, 34);
            this._cTimerConfig.Name = "_cTimerConfig";
            this._cTimerConfig.Size = new System.Drawing.Size(121, 26);
            this._cTimerConfig.TabIndex = 6;
            // 
            // _cAlarmConfig
            // 
            this._cAlarmConfig.AutoSize = true;
            this._cAlarmConfig.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._cAlarmConfig.Enabled = false;
            this._cAlarmConfig.Location = new System.Drawing.Point(15, 34);
            this._cAlarmConfig.Name = "_cAlarmConfig";
            this._cAlarmConfig.Size = new System.Drawing.Size(111, 26);
            this._cAlarmConfig.TabIndex = 5;
            this._cAlarmConfig.Time = new System.DateTime(2018, 11, 10, 0, 0, 0, 0);
            this._cAlarmConfig.Visible = false;
            // 
            // _cType
            // 
            this._cType.ButtonLayout = MouseNet.Forms.Controls.RadioButtonLayout.Horizontal;
            this._cType.ButtonMargin = new System.Windows.Forms.Padding(4, 3, 4, 4);
            this._cType.CheckedItemIndex = 0;
            this._cType.Items.AddRange(new object[] {
            "Timer",
            "Alarm"});
            this._cType.Location = new System.Drawing.Point(249, 4);
            this._cType.Name = "_cType";
            this._cType.Padding = new System.Windows.Forms.Padding(4, 3, 4, 4);
            this._cType.Size = new System.Drawing.Size(118, 24);
            this._cType.TabIndex = 4;
            this._cType.CheckedItemChanged += new System.EventHandler(this.OnTypeChanged);
            // 
            // alertOptions1
            // 
            this.alertOptions1.Location = new System.Drawing.Point(12, 66);
            this.alertOptions1.Message = null;
            this.alertOptions1.Name = "alertOptions1";
            this.alertOptions1.Size = new System.Drawing.Size(417, 176);
            this.alertOptions1.TabIndex = 9;
            // 
            // NewAlarmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 248);
            this.Controls.Add(this.alertOptions1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this._lblName);
            this.Controls.Add(this._cTimerConfig);
            this.Controls.Add(this._cAlarmConfig);
            this.Controls.Add(this._cType);
            this.Controls.Add(this._cRepeatCheckbox);
            this.Controls.Add(this._lblType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewAlarmForm";
            this.ShowInTaskbar = false;
            this.Text = "New Alarm";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label _lblType;
        private System.Windows.Forms.CheckBox _cRepeatCheckbox;
        private MouseNet.Forms.Controls.RadioButtonGroup _cType;
        private AlarmConfig _cAlarmConfig;
        private TimerConfig _cTimerConfig;
        private System.Windows.Forms.Label _lblName;
        private System.Windows.Forms.TextBox textBox1;
        private AlertOptions alertOptions1;
    }
}