namespace GUI.User_Controls
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.homeIcon = new System.Windows.Forms.PictureBox();
            this.homeLabel = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.illustration = new System.Windows.Forms.PictureBox();
            this.bunifuVScrollBar2 = new Bunifu.UI.WinForms.BunifuVScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).BeginInit();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.illustration)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 75;
            this.bunifuElipse1.TargetControl = this;
            // 
            // homeIcon
            // 
            this.homeIcon.BackColor = System.Drawing.Color.Transparent;
            this.homeIcon.Image = ((System.Drawing.Image)(resources.GetObject("homeIcon.Image")));
            this.homeIcon.Location = new System.Drawing.Point(37, 20);
            this.homeIcon.Name = "homeIcon";
            this.homeIcon.Size = new System.Drawing.Size(39, 47);
            this.homeIcon.TabIndex = 0;
            this.homeIcon.TabStop = false;
            // 
            // homeLabel
            // 
            this.homeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.homeLabel.AutoSize = true;
            this.homeLabel.Font = new System.Drawing.Font("Dream Meadow", 42F);
            this.homeLabel.Location = new System.Drawing.Point(408, 0);
            this.homeLabel.Name = "homeLabel";
            this.homeLabel.Size = new System.Drawing.Size(119, 74);
            this.homeLabel.TabIndex = 1;
            this.homeLabel.Text = "Home";
            this.homeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(244, 59);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(446, 15);
            this.bunifuSeparator1.TabIndex = 2;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // contentPanel
            // 
            this.contentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentPanel.Controls.Add(this.illustration);
            this.contentPanel.Location = new System.Drawing.Point(6, 77);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(891, 766);
            this.contentPanel.TabIndex = 3;
            // 
            // illustration
            // 
            this.illustration.Image = ((System.Drawing.Image)(resources.GetObject("illustration.Image")));
            this.illustration.Location = new System.Drawing.Point(3, 3);
            this.illustration.Name = "illustration";
            this.illustration.Size = new System.Drawing.Size(329, 434);
            this.illustration.TabIndex = 6;
            this.illustration.TabStop = false;
            // 
            // bunifuVScrollBar2
            // 
            this.bunifuVScrollBar2.AllowCursorChanges = true;
            this.bunifuVScrollBar2.AllowHomeEndKeysDetection = false;
            this.bunifuVScrollBar2.AllowIncrementalClickMoves = true;
            this.bunifuVScrollBar2.AllowMouseDownEffects = true;
            this.bunifuVScrollBar2.AllowMouseHoverEffects = true;
            this.bunifuVScrollBar2.AllowScrollingAnimations = true;
            this.bunifuVScrollBar2.AllowScrollKeysDetection = true;
            this.bunifuVScrollBar2.AllowScrollOptionsMenu = true;
            this.bunifuVScrollBar2.AllowShrinkingOnFocusLost = false;
            this.bunifuVScrollBar2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuVScrollBar2.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuVScrollBar2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuVScrollBar2.BackgroundImage")));
            this.bunifuVScrollBar2.BindingContainer = this.contentPanel;
            this.bunifuVScrollBar2.BorderColor = System.Drawing.Color.Silver;
            this.bunifuVScrollBar2.BorderRadius = 14;
            this.bunifuVScrollBar2.BorderThickness = 1;
            this.bunifuVScrollBar2.DurationBeforeShrink = 2000;
            this.bunifuVScrollBar2.LargeChange = 10;
            this.bunifuVScrollBar2.Location = new System.Drawing.Point(903, 80);
            this.bunifuVScrollBar2.Maximum = 100;
            this.bunifuVScrollBar2.Minimum = 0;
            this.bunifuVScrollBar2.MinimumThumbLength = 18;
            this.bunifuVScrollBar2.Name = "bunifuVScrollBar2";
            this.bunifuVScrollBar2.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.bunifuVScrollBar2.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.bunifuVScrollBar2.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.bunifuVScrollBar2.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.bunifuVScrollBar2.ScrollBarColor = System.Drawing.Color.Transparent;
            this.bunifuVScrollBar2.ShrinkSizeLimit = 3;
            this.bunifuVScrollBar2.Size = new System.Drawing.Size(17, 383);
            this.bunifuVScrollBar2.SmallChange = 1;
            this.bunifuVScrollBar2.TabIndex = 9;
            this.bunifuVScrollBar2.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.bunifuVScrollBar2.ThumbLength = 37;
            this.bunifuVScrollBar2.ThumbMargin = 1;
            this.bunifuVScrollBar2.ThumbStyle = Bunifu.UI.WinForms.BunifuVScrollBar.ThumbStyles.Inset;
            this.bunifuVScrollBar2.Value = 0;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bunifuVScrollBar2);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.homeLabel);
            this.Controls.Add(this.homeIcon);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(937, 798);
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).EndInit();
            this.contentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.illustration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label homeLabel;
        private System.Windows.Forms.PictureBox homeIcon;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.PictureBox illustration;
        private Bunifu.UI.WinForms.BunifuVScrollBar bunifuVScrollBar2;
    }
}
