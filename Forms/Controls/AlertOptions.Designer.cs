namespace MouseNet.TinyAlarm.Forms.Controls
{
    partial class AlertOptions
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
            this._cOpenSoundDialog = new System.Windows.Forms.OpenFileDialog();
            this.messageOptions1 = new MouseNet.TinyAlarm.Forms.Controls.MessageOptions();
            this._cSoundConfig = new MouseNet.TinyAlarm.Forms.Controls.SoundOptions();
            this.SuspendLayout();
            // 
            // _cOpenSoundDialog
            // 
            this._cOpenSoundDialog.Filter = "Audio files|*.mp3;*.wav;*.mp4;*.wma;*.aiff;*.aac";
            this._cOpenSoundDialog.Title = "Open audio file";
            // 
            // messageOptions1
            // 
            this.messageOptions1.AutoSize = true;
            this.messageOptions1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.messageOptions1.Location = new System.Drawing.Point(3, 3);
            this.messageOptions1.MessageType = MouseNet.TinyAlarm.Forms.Controls.AlertMessageType.Dialog;
            this.messageOptions1.Name = "messageOptions1";
            this.messageOptions1.ShowMessage = false;
            this.messageOptions1.Size = new System.Drawing.Size(410, 54);
            this.messageOptions1.TabIndex = 1;
            this.messageOptions1.Window = null;
            // 
            // _cSoundConfig
            // 
            this._cSoundConfig.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._cSoundConfig.Location = new System.Drawing.Point(3, 63);
            this._cSoundConfig.Loop = false;
            this._cSoundConfig.Name = "_cSoundConfig";
            this._cSoundConfig.PlaySound = false;
            this._cSoundConfig.Size = new System.Drawing.Size(410, 110);
            this._cSoundConfig.SoundFileName = null;
            this._cSoundConfig.TabIndex = 0;
            this._cSoundConfig.Volume = 1F;
            // 
            // AlertOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.messageOptions1);
            this.Controls.Add(this._cSoundConfig);
            this.Name = "AlertOptions";
            this.Size = new System.Drawing.Size(416, 176);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog _cOpenSoundDialog;
        private SoundOptions _cSoundConfig;
        private MessageOptions messageOptions1;
    }
}
