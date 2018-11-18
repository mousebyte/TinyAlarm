namespace MouseNet.TinyAlarm.Forms.Controls
{
    partial class MessageAppearanceOptions
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
            this._grpAppearance = new System.Windows.Forms.GroupBox();
            this._lblBackgroundColor = new System.Windows.Forms.Label();
            this._cBackgroundColor = new MouseNet.Forms.Controls.ColorPicker();
            this._lblOpacity = new System.Windows.Forms.Label();
            this._cOpacityUpDown = new System.Windows.Forms.NumericUpDown();
            this._cOpacitySlider = new System.Windows.Forms.TrackBar();
            this._cText = new MouseNet.Forms.Controls.FontTextBox();
            this._lblText = new System.Windows.Forms.Label();
            this._lblTitle = new System.Windows.Forms.Label();
            this._cTitle = new MouseNet.Forms.Controls.FontTextBox();
            this._grpAppearance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._cOpacityUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cOpacitySlider)).BeginInit();
            this.SuspendLayout();
            // 
            // _grpAppearance
            // 
            this._grpAppearance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._grpAppearance.Controls.Add(this._lblBackgroundColor);
            this._grpAppearance.Controls.Add(this._cBackgroundColor);
            this._grpAppearance.Controls.Add(this._lblOpacity);
            this._grpAppearance.Controls.Add(this._cOpacityUpDown);
            this._grpAppearance.Controls.Add(this._cOpacitySlider);
            this._grpAppearance.Controls.Add(this._cText);
            this._grpAppearance.Controls.Add(this._lblText);
            this._grpAppearance.Controls.Add(this._lblTitle);
            this._grpAppearance.Controls.Add(this._cTitle);
            this._grpAppearance.Location = new System.Drawing.Point(3, 3);
            this._grpAppearance.Name = "_grpAppearance";
            this._grpAppearance.Size = new System.Drawing.Size(293, 233);
            this._grpAppearance.TabIndex = 0;
            this._grpAppearance.TabStop = false;
            this._grpAppearance.Text = "Appearance";
            // 
            // _lblBackgroundColor
            // 
            this._lblBackgroundColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._lblBackgroundColor.AutoSize = true;
            this._lblBackgroundColor.Location = new System.Drawing.Point(6, 208);
            this._lblBackgroundColor.Name = "_lblBackgroundColor";
            this._lblBackgroundColor.Size = new System.Drawing.Size(94, 13);
            this._lblBackgroundColor.TabIndex = 8;
            this._lblBackgroundColor.Text = "Background color:";
            // 
            // _cBackgroundColor
            // 
            this._cBackgroundColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._cBackgroundColor.Color = System.Drawing.SystemColors.Window;
            this._cBackgroundColor.ForeColor = System.Drawing.SystemColors.Control;
            this._cBackgroundColor.Location = new System.Drawing.Point(107, 204);
            this._cBackgroundColor.Margin = new System.Windows.Forms.Padding(4);
            this._cBackgroundColor.MaximumSize = new System.Drawing.Size(28, 28);
            this._cBackgroundColor.MinimumSize = new System.Drawing.Size(22, 22);
            this._cBackgroundColor.Name = "_cBackgroundColor";
            this._cBackgroundColor.Size = new System.Drawing.Size(22, 22);
            this._cBackgroundColor.TabIndex = 7;
            // 
            // _lblOpacity
            // 
            this._lblOpacity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._lblOpacity.AutoSize = true;
            this._lblOpacity.Location = new System.Drawing.Point(6, 155);
            this._lblOpacity.Name = "_lblOpacity";
            this._lblOpacity.Size = new System.Drawing.Size(46, 13);
            this._lblOpacity.TabIndex = 6;
            this._lblOpacity.Text = "Opacity:";
            // 
            // _cOpacityUpDown
            // 
            this._cOpacityUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._cOpacityUpDown.Location = new System.Drawing.Point(248, 171);
            this._cOpacityUpDown.Name = "_cOpacityUpDown";
            this._cOpacityUpDown.Size = new System.Drawing.Size(39, 20);
            this._cOpacityUpDown.TabIndex = 5;
            this._cOpacityUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this._cOpacityUpDown.ValueChanged += new System.EventHandler(this.OnOpacityUpDownValueChanged);
            // 
            // _cOpacitySlider
            // 
            this._cOpacitySlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cOpacitySlider.Location = new System.Drawing.Point(6, 171);
            this._cOpacitySlider.Maximum = 100;
            this._cOpacitySlider.Minimum = 1;
            this._cOpacitySlider.Name = "_cOpacitySlider";
            this._cOpacitySlider.Size = new System.Drawing.Size(236, 45);
            this._cOpacitySlider.TabIndex = 4;
            this._cOpacitySlider.TickFrequency = 5;
            this._cOpacitySlider.Value = 100;
            this._cOpacitySlider.ValueChanged += new System.EventHandler(this.OnOpacitySliderValueChanged);
            // 
            // _cText
            // 
            this._cText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cText.FontButtonImage = global::MouseNet.TinyAlarm.Resources.fontSmall;
            this._cText.Location = new System.Drawing.Point(6, 76);
            this._cText.MinimumSize = new System.Drawing.Size(150, 24);
            this._cText.Multiline = true;
            this._cText.Name = "_cText";
            this._cText.PreviewFont = true;
            this._cText.ShowFontSelect = true;
            this._cText.Size = new System.Drawing.Size(281, 76);
            this._cText.TabIndex = 3;
            // 
            // _lblText
            // 
            this._lblText.AutoSize = true;
            this._lblText.Location = new System.Drawing.Point(6, 59);
            this._lblText.Name = "_lblText";
            this._lblText.Size = new System.Drawing.Size(31, 13);
            this._lblText.TabIndex = 2;
            this._lblText.Text = "Text:";
            // 
            // _lblTitle
            // 
            this._lblTitle.AutoSize = true;
            this._lblTitle.Location = new System.Drawing.Point(6, 16);
            this._lblTitle.Name = "_lblTitle";
            this._lblTitle.Size = new System.Drawing.Size(30, 13);
            this._lblTitle.TabIndex = 1;
            this._lblTitle.Text = "Title:";
            // 
            // _cTitle
            // 
            this._cTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cTitle.FontButtonImage = global::MouseNet.TinyAlarm.Resources.fontSmall;
            this._cTitle.Location = new System.Drawing.Point(6, 32);
            this._cTitle.MinimumSize = new System.Drawing.Size(150, 24);
            this._cTitle.Multiline = false;
            this._cTitle.Name = "_cTitle";
            this._cTitle.PreviewFont = true;
            this._cTitle.ShowFontSelect = true;
            this._cTitle.Size = new System.Drawing.Size(281, 24);
            this._cTitle.TabIndex = 0;
            // 
            // MessageAppearanceOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._grpAppearance);
            this.Name = "MessageAppearanceOptions";
            this.Size = new System.Drawing.Size(299, 239);
            this._grpAppearance.ResumeLayout(false);
            this._grpAppearance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._cOpacityUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cOpacitySlider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox _grpAppearance;
        private MouseNet.Forms.Controls.FontTextBox _cTitle;
        private System.Windows.Forms.Label _lblText;
        private System.Windows.Forms.Label _lblTitle;
        private System.Windows.Forms.TrackBar _cOpacitySlider;
        private MouseNet.Forms.Controls.FontTextBox _cText;
        private System.Windows.Forms.Label _lblBackgroundColor;
        private MouseNet.Forms.Controls.ColorPicker _cBackgroundColor;
        private System.Windows.Forms.Label _lblOpacity;
        private System.Windows.Forms.NumericUpDown _cOpacityUpDown;
    }
}
