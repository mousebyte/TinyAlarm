namespace MouseNet.TinyAlarm.Forms.Controls
{
    partial class AlarmConfig
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
            this._cTime = new System.Windows.Forms.DateTimePicker();
            this._lblTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _cTime
            // 
            this._cTime.CustomFormat = "hh:mm tt";
            this._cTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._cTime.Location = new System.Drawing.Point(39, 3);
            this._cTime.Name = "_cTime";
            this._cTime.ShowUpDown = true;
            this._cTime.Size = new System.Drawing.Size(69, 20);
            this._cTime.TabIndex = 0;
            this._cTime.Value = new System.DateTime(2018, 11, 10, 0, 0, 0, 0);
            this._cTime.ValueChanged += new System.EventHandler(this.OnTimeChanged);
            // 
            // _lblTime
            // 
            this._lblTime.AutoSize = true;
            this._lblTime.Location = new System.Drawing.Point(0, 6);
            this._lblTime.Name = "_lblTime";
            this._lblTime.Size = new System.Drawing.Size(33, 13);
            this._lblTime.TabIndex = 1;
            this._lblTime.Text = "Time:";
            // 
            // AlarmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this._lblTime);
            this.Controls.Add(this._cTime);
            this.Name = "AlarmConfig";
            this.Size = new System.Drawing.Size(111, 26);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker _cTime;
        private System.Windows.Forms.Label _lblTime;
    }
}
