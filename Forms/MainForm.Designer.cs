using MouseNet.TinyAlarm.Forms.Controls;

namespace MouseNet.TinyAlarm.Forms
{
    partial class MainForm
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
            this._cAddButton = new System.Windows.Forms.Button();
            this._cRemoveButton = new System.Windows.Forms.Button();
            this._cAlarmList = new AlarmList();
            this.SuspendLayout();
            // 
            // _cAddButton
            // 
            this._cAddButton.Location = new System.Drawing.Point(262, 12);
            this._cAddButton.Name = "_cAddButton";
            this._cAddButton.Size = new System.Drawing.Size(75, 23);
            this._cAddButton.TabIndex = 1;
            this._cAddButton.Text = "Add";
            this._cAddButton.UseVisualStyleBackColor = true;
            this._cAddButton.Click += new System.EventHandler(this.OnAdd);
            // 
            // _cRemoveButton
            // 
            this._cRemoveButton.Location = new System.Drawing.Point(263, 42);
            this._cRemoveButton.Name = "_cRemoveButton";
            this._cRemoveButton.Size = new System.Drawing.Size(75, 23);
            this._cRemoveButton.TabIndex = 2;
            this._cRemoveButton.Text = "Remove";
            this._cRemoveButton.UseVisualStyleBackColor = true;
            this._cRemoveButton.Click += new System.EventHandler(this.OnRemove);
            // 
            // _cAlarmList
            // 
            this._cAlarmList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cAlarmList.Location = new System.Drawing.Point(12, 12);
            this._cAlarmList.Name = "_cAlarmList";
            this._cAlarmList.Size = new System.Drawing.Size(232, 169);
            this._cAlarmList.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 311);
            this.Controls.Add(this._cRemoveButton);
            this.Controls.Add(this._cAddButton);
            this.Controls.Add(this._cAlarmList);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private AlarmList _cAlarmList;
        private System.Windows.Forms.Button _cAddButton;
        private System.Windows.Forms.Button _cRemoveButton;
    }
}

