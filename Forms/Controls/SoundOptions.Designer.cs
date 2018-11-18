namespace MouseNet.TinyAlarm.Forms.Controls
{
    partial class SoundOptions
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
            this._groupSound = new System.Windows.Forms.GroupBox();
            this._lblVolume = new System.Windows.Forms.Label();
            this._cTestStopBtn = new System.Windows.Forms.Button();
            this._cBrowseBtn = new System.Windows.Forms.Button();
            this._cFileName = new System.Windows.Forms.TextBox();
            this._cPlaySound = new System.Windows.Forms.CheckBox();
            this._cLoop = new System.Windows.Forms.CheckBox();
            this._cVolume = new System.Windows.Forms.TrackBar();
            this._cOpenSoundDialog = new System.Windows.Forms.OpenFileDialog();
            this._groupSound.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._cVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // _groupSound
            // 
            this._groupSound.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._groupSound.Controls.Add(this._cVolume);
            this._groupSound.Controls.Add(this._cLoop);
            this._groupSound.Controls.Add(this._lblVolume);
            this._groupSound.Controls.Add(this._cTestStopBtn);
            this._groupSound.Controls.Add(this._cBrowseBtn);
            this._groupSound.Controls.Add(this._cFileName);
            this._groupSound.Controls.Add(this._cPlaySound);
            this._groupSound.Location = new System.Drawing.Point(3, 3);
            this._groupSound.Name = "_groupSound";
            this._groupSound.Size = new System.Drawing.Size(389, 95);
            this._groupSound.TabIndex = 2;
            this._groupSound.TabStop = false;
            this._groupSound.Text = "Sound";
            // 
            // _lblVolume
            // 
            this._lblVolume.AutoSize = true;
            this._lblVolume.Enabled = false;
            this._lblVolume.Location = new System.Drawing.Point(6, 56);
            this._lblVolume.Name = "_lblVolume";
            this._lblVolume.Size = new System.Drawing.Size(45, 13);
            this._lblVolume.TabIndex = 5;
            this._lblVolume.Text = "Volume:";
            // 
            // _cTestStopBtn
            // 
            this._cTestStopBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._cTestStopBtn.Enabled = false;
            this._cTestStopBtn.Location = new System.Drawing.Point(331, 65);
            this._cTestStopBtn.Name = "_cTestStopBtn";
            this._cTestStopBtn.Size = new System.Drawing.Size(52, 23);
            this._cTestStopBtn.TabIndex = 4;
            this._cTestStopBtn.Text = "Test";
            this._cTestStopBtn.UseVisualStyleBackColor = true;
            this._cTestStopBtn.Click += new System.EventHandler(this.OnTestStopClicked);
            // 
            // _cBrowseBtn
            // 
            this._cBrowseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._cBrowseBtn.AutoSize = true;
            this._cBrowseBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._cBrowseBtn.Enabled = false;
            this._cBrowseBtn.Location = new System.Drawing.Point(331, 15);
            this._cBrowseBtn.Name = "_cBrowseBtn";
            this._cBrowseBtn.Size = new System.Drawing.Size(52, 23);
            this._cBrowseBtn.TabIndex = 3;
            this._cBrowseBtn.Text = "Browse";
            this._cBrowseBtn.UseVisualStyleBackColor = true;
            this._cBrowseBtn.Click += new System.EventHandler(this.OnBrowseClicked);
            // 
            // _cFileName
            // 
            this._cFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cFileName.Enabled = false;
            this._cFileName.Location = new System.Drawing.Point(94, 17);
            this._cFileName.Name = "_cFileName";
            this._cFileName.Size = new System.Drawing.Size(231, 20);
            this._cFileName.TabIndex = 1;
            // 
            // _cPlaySound
            // 
            this._cPlaySound.AutoSize = true;
            this._cPlaySound.Location = new System.Drawing.Point(7, 20);
            this._cPlaySound.Name = "_cPlaySound";
            this._cPlaySound.Size = new System.Drawing.Size(81, 17);
            this._cPlaySound.TabIndex = 0;
            this._cPlaySound.Text = "Play sound:";
            this._cPlaySound.UseVisualStyleBackColor = true;
            this._cPlaySound.Click += new System.EventHandler(this.OnPlaySoundCheckedChanged);
            // 
            // _cLoop
            // 
            this._cLoop.AutoSize = true;
            this._cLoop.Enabled = false;
            this._cLoop.Location = new System.Drawing.Point(331, 44);
            this._cLoop.Name = "_cLoop";
            this._cLoop.Size = new System.Drawing.Size(50, 17);
            this._cLoop.TabIndex = 3;
            this._cLoop.Text = "Loop";
            this._cLoop.UseVisualStyleBackColor = true;
            // 
            // _cVolume
            // 
            this._cVolume.Enabled = false;
            this._cVolume.Location = new System.Drawing.Point(57, 43);
            this._cVolume.Maximum = 100;
            this._cVolume.Minimum = 1;
            this._cVolume.Name = "_cVolume";
            this._cVolume.Size = new System.Drawing.Size(268, 45);
            this._cVolume.TabIndex = 6;
            this._cVolume.TickFrequency = 5;
            this._cVolume.TickStyle = System.Windows.Forms.TickStyle.Both;
            this._cVolume.Value = 100;
            this._cVolume.ValueChanged += new System.EventHandler(this.OnVolumeChanged);
            // 
            // _cOpenSoundDialog
            // 
            this._cOpenSoundDialog.Filter = "Audio files|*.mp3;*.wav;*.mp4;*.wma;*.aiff;*.aac";
            this._cOpenSoundDialog.Title = "Open sound file";
            // 
            // SoundOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._groupSound);
            this.Name = "SoundOptions";
            this.Size = new System.Drawing.Size(395, 101);
            this._groupSound.ResumeLayout(false);
            this._groupSound.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._cVolume)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox _groupSound;
        private System.Windows.Forms.Label _lblVolume;
        private System.Windows.Forms.Button _cTestStopBtn;
        private System.Windows.Forms.Button _cBrowseBtn;
        private System.Windows.Forms.TextBox _cFileName;
        private System.Windows.Forms.CheckBox _cPlaySound;
        private System.Windows.Forms.CheckBox _cLoop;
        private System.Windows.Forms.TrackBar _cVolume;
        private System.Windows.Forms.OpenFileDialog _cOpenSoundDialog;
    }
}
