namespace MouseNet.TinyAlarm.Forms.Controls
{
    partial class MessageOptions
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
            this._groupMessage = new System.Windows.Forms.GroupBox();
            this._cMessageType = new MouseNet.Forms.Controls.RadioButtonGroup();
            this._cShowMessage = new System.Windows.Forms.CheckBox();
            this._cConfigureBtn = new System.Windows.Forms.Button();
            this._groupMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // _groupMessage
            // 
            this._groupMessage.Controls.Add(this._cConfigureBtn);
            this._groupMessage.Controls.Add(this._cMessageType);
            this._groupMessage.Controls.Add(this._cShowMessage);
            this._groupMessage.Location = new System.Drawing.Point(3, 3);
            this._groupMessage.Name = "_groupMessage";
            this._groupMessage.Size = new System.Drawing.Size(401, 165);
            this._groupMessage.TabIndex = 1;
            this._groupMessage.TabStop = false;
            this._groupMessage.Text = "Message";
            // 
            // _cMessageType
            // 
            this._cMessageType.ButtonLayout = MouseNet.Forms.Controls.RadioButtonLayout.Horizontal;
            this._cMessageType.ButtonMargin = new System.Windows.Forms.Padding(1, 3, 1, 4);
            this._cMessageType.CheckedItemIndex = -1;
            this._cMessageType.Enabled = false;
            this._cMessageType.Items.AddRange(new object[] {
            "Dialog",
            "Balloon",
            "Notification"});
            this._cMessageType.Location = new System.Drawing.Point(106, 16);
            this._cMessageType.Name = "_cMessageType";
            this._cMessageType.Padding = new System.Windows.Forms.Padding(4, 3, 4, 4);
            this._cMessageType.Size = new System.Drawing.Size(205, 24);
            this._cMessageType.TabIndex = 3;
            // 
            // _cShowMessage
            // 
            this._cShowMessage.AutoSize = true;
            this._cShowMessage.Location = new System.Drawing.Point(6, 20);
            this._cShowMessage.Name = "_cShowMessage";
            this._cShowMessage.Size = new System.Drawing.Size(101, 17);
            this._cShowMessage.TabIndex = 0;
            this._cShowMessage.Text = "Show message:";
            this._cShowMessage.UseVisualStyleBackColor = true;
            // 
            // _cConfigureBtn
            // 
            this._cConfigureBtn.Location = new System.Drawing.Point(317, 16);
            this._cConfigureBtn.Name = "_cConfigureBtn";
            this._cConfigureBtn.Size = new System.Drawing.Size(69, 23);
            this._cConfigureBtn.TabIndex = 4;
            this._cConfigureBtn.Text = "Configure...";
            this._cConfigureBtn.UseVisualStyleBackColor = true;
            // 
            // MessageOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this._groupMessage);
            this.Name = "MessageOptions";
            this.Size = new System.Drawing.Size(407, 171);
            this._groupMessage.ResumeLayout(false);
            this._groupMessage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox _groupMessage;
        private MouseNet.Forms.Controls.RadioButtonGroup _cMessageType;
        private System.Windows.Forms.CheckBox _cShowMessage;
        private System.Windows.Forms.Button _cConfigureBtn;
    }
}
