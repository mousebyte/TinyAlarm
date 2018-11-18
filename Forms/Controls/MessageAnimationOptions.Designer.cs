namespace MouseNet.TinyAlarm.Forms.Controls
{
    partial class MessageAnimationOptions
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
            this._grpAnimation = new System.Windows.Forms.GroupBox();
            this._cFadeIn = new System.Windows.Forms.CheckBox();
            this._lblSpeed = new System.Windows.Forms.Label();
            this._cSpeed = new System.Windows.Forms.ComboBox();
            this._lblStyle = new System.Windows.Forms.Label();
            this._cStyle = new MouseNet.Forms.Controls.RadioButtonGroup();
            this._grpAnimation.SuspendLayout();
            this.SuspendLayout();
            // 
            // _grpAnimation
            // 
            this._grpAnimation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._grpAnimation.Controls.Add(this._cFadeIn);
            this._grpAnimation.Controls.Add(this._lblSpeed);
            this._grpAnimation.Controls.Add(this._cSpeed);
            this._grpAnimation.Controls.Add(this._lblStyle);
            this._grpAnimation.Controls.Add(this._cStyle);
            this._grpAnimation.Location = new System.Drawing.Point(3, 3);
            this._grpAnimation.Name = "_grpAnimation";
            this._grpAnimation.Size = new System.Drawing.Size(204, 75);
            this._grpAnimation.TabIndex = 0;
            this._grpAnimation.TabStop = false;
            this._grpAnimation.Text = "Animation";
            // 
            // _cFadeIn
            // 
            this._cFadeIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._cFadeIn.AutoSize = true;
            this._cFadeIn.Location = new System.Drawing.Point(133, 48);
            this._cFadeIn.Name = "_cFadeIn";
            this._cFadeIn.Size = new System.Drawing.Size(62, 17);
            this._cFadeIn.TabIndex = 4;
            this._cFadeIn.Text = "Fade In";
            this._cFadeIn.UseVisualStyleBackColor = true;
            // 
            // _lblSpeed
            // 
            this._lblSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._lblSpeed.AutoSize = true;
            this._lblSpeed.Location = new System.Drawing.Point(2, 49);
            this._lblSpeed.Name = "_lblSpeed";
            this._lblSpeed.Size = new System.Drawing.Size(41, 13);
            this._lblSpeed.TabIndex = 3;
            this._lblSpeed.Text = "Speed:";
            // 
            // _cSpeed
            // 
            this._cSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cSpeed.FormattingEnabled = true;
            this._cSpeed.Items.AddRange(new object[] {
            "Slow",
            "Fast",
            "Very Fast"});
            this._cSpeed.Location = new System.Drawing.Point(49, 46);
            this._cSpeed.Name = "_cSpeed";
            this._cSpeed.Size = new System.Drawing.Size(73, 21);
            this._cSpeed.TabIndex = 2;
            // 
            // _lblStyle
            // 
            this._lblStyle.AutoSize = true;
            this._lblStyle.Location = new System.Drawing.Point(6, 24);
            this._lblStyle.Name = "_lblStyle";
            this._lblStyle.Size = new System.Drawing.Size(33, 13);
            this._lblStyle.TabIndex = 1;
            this._lblStyle.Text = "Style:";
            // 
            // _cStyle
            // 
            this._cStyle.ButtonLayout = MouseNet.Forms.Controls.RadioButtonLayout.Horizontal;
            this._cStyle.ButtonMargin = new System.Windows.Forms.Padding(4, 3, 4, 4);
            this._cStyle.Items.AddRange(new object[] {
            "Slide Up",
            "Slide Left"});
            this._cStyle.Location = new System.Drawing.Point(45, 19);
            this._cStyle.Name = "_cStyle";
            this._cStyle.Padding = new System.Windows.Forms.Padding(4, 3, 4, 4);
            this._cStyle.Size = new System.Drawing.Size(150, 24);
            this._cStyle.TabIndex = 0;
            // 
            // MessageAnimationOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._grpAnimation);
            this.Name = "MessageAnimationOptions";
            this.Size = new System.Drawing.Size(210, 81);
            this._grpAnimation.ResumeLayout(false);
            this._grpAnimation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox _grpAnimation;
        private MouseNet.Forms.Controls.RadioButtonGroup _cStyle;
        private System.Windows.Forms.Label _lblStyle;
        private System.Windows.Forms.Label _lblSpeed;
        private System.Windows.Forms.ComboBox _cSpeed;
        private System.Windows.Forms.CheckBox _cFadeIn;
    }
}
