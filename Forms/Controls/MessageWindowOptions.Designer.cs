namespace MouseNet.TinyAlarm.Forms.Controls
{
    partial class MessageWindowOptions
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
            this.components = new System.ComponentModel.Container();
            this._cIsModal = new System.Windows.Forms.CheckBox();
            this._cIsSticky = new System.Windows.Forms.CheckBox();
            this._cDuration = new System.Windows.Forms.NumericUpDown();
            this._toolTip = new System.Windows.Forms.ToolTip(this.components);
            this._cAnimationOptions = new MouseNet.TinyAlarm.Forms.Controls.MessageAnimationOptions();
            this._cAppearanceOptions = new MouseNet.TinyAlarm.Forms.Controls.MessageAppearanceOptions();
            this._cSize = new MouseNet.Forms.Controls.SizeControl();
            this._lblDuration = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._cDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // _cIsModal
            // 
            this._cIsModal.AutoSize = true;
            this._cIsModal.Location = new System.Drawing.Point(185, 8);
            this._cIsModal.Name = "_cIsModal";
            this._cIsModal.Size = new System.Drawing.Size(55, 17);
            this._cIsModal.TabIndex = 2;
            this._cIsModal.Text = "Modal";
            this._toolTip.SetToolTip(this._cIsModal, "If checked, the alert dialog will be modal (always on top).");
            this._cIsModal.UseVisualStyleBackColor = true;
            // 
            // _cIsSticky
            // 
            this._cIsSticky.AutoSize = true;
            this._cIsSticky.Location = new System.Drawing.Point(185, 35);
            this._cIsSticky.Name = "_cIsSticky";
            this._cIsSticky.Size = new System.Drawing.Size(55, 17);
            this._cIsSticky.TabIndex = 3;
            this._cIsSticky.Text = "Sticky";
            this._toolTip.SetToolTip(this._cIsSticky, "If checked, the notification will be displayed until clicked.");
            this._cIsSticky.UseVisualStyleBackColor = true;
            // 
            // _cDuration
            // 
            this._cDuration.Location = new System.Drawing.Point(107, 34);
            this._cDuration.Name = "_cDuration";
            this._cDuration.Size = new System.Drawing.Size(64, 20);
            this._cDuration.TabIndex = 5;
            this._toolTip.SetToolTip(this._cDuration, "The duration for which to display the dialog or notification.");
            // 
            // _cAnimationOptions
            // 
            this._cAnimationOptions.FadeIn = false;
            this._cAnimationOptions.Location = new System.Drawing.Point(3, 60);
            this._cAnimationOptions.Name = "_cAnimationOptions";
            this._cAnimationOptions.Size = new System.Drawing.Size(261, 81);
            this._cAnimationOptions.Speed = MouseNet.TinyAlarm.Forms.Controls.AnimationSpeed.Fast;
            this._cAnimationOptions.Style = MouseNet.TinyAlarm.Forms.Controls.AnimationStyle.SlideUp;
            this._cAnimationOptions.TabIndex = 1;
            // 
            // _cAppearanceOptions
            // 
            this._cAppearanceOptions.BackgroundColor = System.Drawing.SystemColors.Window;
            this._cAppearanceOptions.Location = new System.Drawing.Point(3, 147);
            this._cAppearanceOptions.MessageText = "";
            this._cAppearanceOptions.MessageTitle = "";
            this._cAppearanceOptions.Name = "_cAppearanceOptions";
            this._cAppearanceOptions.Opacity = 1D;
            this._cAppearanceOptions.Size = new System.Drawing.Size(261, 239);
            this._cAppearanceOptions.TabIndex = 0;
            this._cAppearanceOptions.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cAppearanceOptions.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // _cSize
            // 
            this._cSize.HeightValue = 100;
            this._cSize.Location = new System.Drawing.Point(26, 3);
            this._cSize.MaximumValue = new System.Drawing.Size(1920, 1050);
            this._cSize.MinimumValue = new System.Drawing.Size(100, 100);
            this._cSize.Name = "_cSize";
            this._cSize.ShowLabel = true;
            this._cSize.Size = new System.Drawing.Size(145, 26);
            this._cSize.TabIndex = 6;
            this._toolTip.SetToolTip(this._cSize, "The size of the message dialog or notification.");
            this._cSize.Value = new System.Drawing.Size(100, 100);
            this._cSize.WidthValue = 100;
            // 
            // _lblDuration
            // 
            this._lblDuration.AutoSize = true;
            this._lblDuration.Location = new System.Drawing.Point(29, 36);
            this._lblDuration.Name = "_lblDuration";
            this._lblDuration.Size = new System.Drawing.Size(50, 13);
            this._lblDuration.TabIndex = 7;
            this._lblDuration.Text = "Duration:";
            // 
            // MessageWindowOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this._lblDuration);
            this.Controls.Add(this._cSize);
            this.Controls.Add(this._cDuration);
            this.Controls.Add(this._cIsSticky);
            this.Controls.Add(this._cIsModal);
            this.Controls.Add(this._cAnimationOptions);
            this.Controls.Add(this._cAppearanceOptions);
            this.Name = "MessageWindowOptions";
            this.Size = new System.Drawing.Size(267, 389);
            ((System.ComponentModel.ISupportInitialize)(this._cDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MessageAppearanceOptions _cAppearanceOptions;
        private MessageAnimationOptions _cAnimationOptions;
        private System.Windows.Forms.CheckBox _cIsModal;
        private System.Windows.Forms.CheckBox _cIsSticky;
        private System.Windows.Forms.NumericUpDown _cDuration;
        private System.Windows.Forms.ToolTip _toolTip;
        private MouseNet.Forms.Controls.SizeControl _cSize;
        private System.Windows.Forms.Label _lblDuration;
    }
}
