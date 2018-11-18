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
            this._cSoundConfig = new SoundOptions();
            this.SuspendLayout();
            // 
            // _cOpenSoundDialog
            // 
            this._cOpenSoundDialog.Filter = "Audio files|*.mp3;*.wav;*.mp4;*.wma;*.aiff;*.aac";
            this._cOpenSoundDialog.Title = "Open audio file";
            // 
            // _cSoundConfig
            // 
            this._cSoundConfig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cSoundConfig.Location = new System.Drawing.Point(3, 72);
            this._cSoundConfig.Loop = false;
            this._cSoundConfig.Name = "_cSoundConfig";
            this._cSoundConfig.PlaySound = false;
            this._cSoundConfig.Size = new System.Drawing.Size(396, 101);
            this._cSoundConfig.SoundFileName = null;
            this._cSoundConfig.TabIndex = 0;
            this._cSoundConfig.Volume = 1F;
            // 
            // AlertOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._cSoundConfig);
            this.Name = "AlertOptions";
            this.Size = new System.Drawing.Size(402, 176);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog _cOpenSoundDialog;
        private SoundOptions soundOptions1;
        private SoundOptions _cSoundConfig;
    }
}
