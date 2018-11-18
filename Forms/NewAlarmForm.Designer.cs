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
            this._cRepeat = new System.Windows.Forms.CheckBox();
            this._lblName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this._cType = new MouseNet.Forms.Controls.RadioButtonGroup();
            this._cTimeInterval = new System.Windows.Forms.DateTimePicker();
            this._lblTimeInterval = new System.Windows.Forms.Label();
            this._cSoundOptions = new MouseNet.TinyAlarm.Forms.Controls.SoundOptions();
            this._btnCancel = new System.Windows.Forms.Button();
            this._btnOk = new System.Windows.Forms.Button();
            this._grpMessage = new System.Windows.Forms.GroupBox();
            this._cShowMessage = new System.Windows.Forms.CheckBox();
            this._cMessageType = new MouseNet.Forms.Controls.RadioButtonGroup();
            this._cConfigureBtn = new System.Windows.Forms.Button();
            this._grpMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // _lblType
            // 
            this._lblType.AutoSize = true;
            this._lblType.Location = new System.Drawing.Point(12, 17);
            this._lblType.Name = "_lblType";
            this._lblType.Size = new System.Drawing.Size(34, 13);
            this._lblType.TabIndex = 1;
            this._lblType.Text = "Type:";
            // 
            // _cRepeat
            // 
            this._cRepeat.AutoSize = true;
            this._cRepeat.Location = new System.Drawing.Point(142, 92);
            this._cRepeat.Name = "_cRepeat";
            this._cRepeat.Size = new System.Drawing.Size(61, 17);
            this._cRepeat.TabIndex = 3;
            this._cRepeat.Text = "Repeat";
            this._cRepeat.UseVisualStyleBackColor = true;
            // 
            // _lblName
            // 
            this._lblName.AutoSize = true;
            this._lblName.Location = new System.Drawing.Point(12, 54);
            this._lblName.Name = "_lblName";
            this._lblName.Size = new System.Drawing.Size(38, 13);
            this._lblName.TabIndex = 7;
            this._lblName.Text = "Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 20);
            this.textBox1.TabIndex = 1;
            // 
            // _cType
            // 
            this._cType.ButtonLayout = MouseNet.Forms.Controls.RadioButtonLayout.Horizontal;
            this._cType.ButtonMargin = new System.Windows.Forms.Padding(4, 3, 4, 4);
            this._cType.CheckedItemIndex = 0;
            this._cType.Items.AddRange(new object[] {
            "Timer",
            "Alarm"});
            this._cType.Location = new System.Drawing.Point(52, 12);
            this._cType.Name = "_cType";
            this._cType.Padding = new System.Windows.Forms.Padding(4, 3, 4, 4);
            this._cType.Size = new System.Drawing.Size(118, 24);
            this._cType.TabIndex = 0;
            this._cType.CheckedItemChanged += new System.EventHandler(this.OnTypeChanged);
            // 
            // _cTimeInterval
            // 
            this._cTimeInterval.CustomFormat = "HH:mm:ss";
            this._cTimeInterval.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._cTimeInterval.Location = new System.Drawing.Point(63, 90);
            this._cTimeInterval.Name = "_cTimeInterval";
            this._cTimeInterval.ShowUpDown = true;
            this._cTimeInterval.Size = new System.Drawing.Size(65, 20);
            this._cTimeInterval.TabIndex = 2;
            this._cTimeInterval.Value = new System.DateTime(2018, 11, 18, 0, 0, 0, 0);
            this._cTimeInterval.ValueChanged += new System.EventHandler(this.OnTimeChanged);
            // 
            // _lblTimeInterval
            // 
            this._lblTimeInterval.AutoSize = true;
            this._lblTimeInterval.Location = new System.Drawing.Point(12, 93);
            this._lblTimeInterval.Name = "_lblTimeInterval";
            this._lblTimeInterval.Size = new System.Drawing.Size(45, 13);
            this._lblTimeInterval.TabIndex = 11;
            this._lblTimeInterval.Text = "Interval:";
            // 
            // _cSoundOptions
            // 
            this._cSoundOptions.Location = new System.Drawing.Point(12, 125);
            this._cSoundOptions.Loop = false;
            this._cSoundOptions.Name = "_cSoundOptions";
            this._cSoundOptions.PlaySound = false;
            this._cSoundOptions.Size = new System.Drawing.Size(396, 101);
            this._cSoundOptions.SoundFileName = null;
            this._cSoundOptions.TabIndex = 5;
            this._cSoundOptions.Volume = 1F;
            // 
            // _btnCancel
            // 
            this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnCancel.Location = new System.Drawing.Point(333, 232);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(75, 23);
            this._btnCancel.TabIndex = 7;
            this._btnCancel.Text = "&Cancel";
            this._btnCancel.UseVisualStyleBackColor = true;
            // 
            // _btnOk
            // 
            this._btnOk.Location = new System.Drawing.Point(252, 232);
            this._btnOk.Name = "_btnOk";
            this._btnOk.Size = new System.Drawing.Size(75, 23);
            this._btnOk.TabIndex = 6;
            this._btnOk.Text = "&Ok";
            this._btnOk.UseVisualStyleBackColor = true;
            // 
            // _grpMessage
            // 
            this._grpMessage.AutoSize = true;
            this._grpMessage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._grpMessage.Controls.Add(this._cConfigureBtn);
            this._grpMessage.Controls.Add(this._cMessageType);
            this._grpMessage.Controls.Add(this._cShowMessage);
            this._grpMessage.Location = new System.Drawing.Point(209, 13);
            this._grpMessage.Name = "_grpMessage";
            this._grpMessage.Size = new System.Drawing.Size(199, 106);
            this._grpMessage.TabIndex = 12;
            this._grpMessage.TabStop = false;
            this._grpMessage.Text = "Message";
            // 
            // _cShowMessage
            // 
            this._cShowMessage.AutoSize = true;
            this._cShowMessage.Location = new System.Drawing.Point(6, 19);
            this._cShowMessage.Name = "_cShowMessage";
            this._cShowMessage.Size = new System.Drawing.Size(101, 17);
            this._cShowMessage.TabIndex = 0;
            this._cShowMessage.Text = "Show message:";
            this._cShowMessage.UseVisualStyleBackColor = true;
            this._cShowMessage.CheckedChanged += new System.EventHandler(this.OnShowMessageCheckedChanged);
            // 
            // _cMessageType
            // 
            this._cMessageType.ButtonLayout = MouseNet.Forms.Controls.RadioButtonLayout.Vertical;
            this._cMessageType.ButtonMargin = new System.Windows.Forms.Padding(4, 3, 4, 4);
            this._cMessageType.CheckedItemIndex = 0;
            this._cMessageType.Enabled = false;
            this._cMessageType.Items.AddRange(new object[] {
            "Dialog",
            "Balloon",
            "Notification"});
            this._cMessageType.Location = new System.Drawing.Point(107, 15);
            this._cMessageType.Name = "_cMessageType";
            this._cMessageType.Padding = new System.Windows.Forms.Padding(4, 3, 4, 4);
            this._cMessageType.Size = new System.Drawing.Size(86, 72);
            this._cMessageType.TabIndex = 1;
            // 
            // _cConfigureBtn
            // 
            this._cConfigureBtn.AutoSize = true;
            this._cConfigureBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._cConfigureBtn.Enabled = false;
            this._cConfigureBtn.Location = new System.Drawing.Point(6, 63);
            this._cConfigureBtn.Name = "_cConfigureBtn";
            this._cConfigureBtn.Size = new System.Drawing.Size(71, 23);
            this._cConfigureBtn.TabIndex = 2;
            this._cConfigureBtn.Text = "Configure...";
            this._cConfigureBtn.UseVisualStyleBackColor = true;
            this._cConfigureBtn.Click += new System.EventHandler(this.OnConfigureMessageClicked);
            // 
            // NewAlarmForm
            // 
            this.AcceptButton = this._btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this._btnCancel;
            this.ClientSize = new System.Drawing.Size(420, 264);
            this.Controls.Add(this._grpMessage);
            this.Controls.Add(this._btnOk);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._cSoundOptions);
            this.Controls.Add(this._lblTimeInterval);
            this.Controls.Add(this._cTimeInterval);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this._lblName);
            this.Controls.Add(this._cType);
            this.Controls.Add(this._cRepeat);
            this.Controls.Add(this._lblType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewAlarmForm";
            this.ShowInTaskbar = false;
            this.Text = "New Alarm";
            this.TopMost = true;
            this._grpMessage.ResumeLayout(false);
            this._grpMessage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label _lblType;
        private System.Windows.Forms.CheckBox _cRepeat;
        private MouseNet.Forms.Controls.RadioButtonGroup _cType;
        private System.Windows.Forms.Label _lblName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker _cTimeInterval;
        private System.Windows.Forms.Label _lblTimeInterval;
        private SoundOptions _cSoundOptions;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.Button _btnOk;
        private System.Windows.Forms.GroupBox _grpMessage;
        private MouseNet.Forms.Controls.RadioButtonGroup _cMessageType;
        private System.Windows.Forms.CheckBox _cShowMessage;
        private System.Windows.Forms.Button _cConfigureBtn;
    }
}