namespace MouseNet.TinyAlarm.Forms.Controls
{
    partial class TimerConfig
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
            this._lblInterval = new System.Windows.Forms.Label();
            this._cInterval = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // _lblInterval
            // 
            this._lblInterval.AutoSize = true;
            this._lblInterval.Location = new System.Drawing.Point(0, 6);
            this._lblInterval.Name = "_lblInterval";
            this._lblInterval.Size = new System.Drawing.Size(45, 13);
            this._lblInterval.TabIndex = 0;
            this._lblInterval.Text = "Interval:";
            // 
            // _cInterval
            // 
            this._cInterval.CustomFormat = "HH:mm:ss";
            this._cInterval.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._cInterval.Location = new System.Drawing.Point(51, 3);
            this._cInterval.Name = "_cInterval";
            this._cInterval.ShowUpDown = true;
            this._cInterval.Size = new System.Drawing.Size(67, 20);
            this._cInterval.TabIndex = 1;
            this._cInterval.Value = new System.DateTime(2018, 11, 10, 0, 0, 0, 0);
            // 
            // TimerConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this._cInterval);
            this.Controls.Add(this._lblInterval);
            this.Name = "TimerConfig";
            this.Size = new System.Drawing.Size(121, 26);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblInterval;
        private System.Windows.Forms.DateTimePicker _cInterval;
    }
}
