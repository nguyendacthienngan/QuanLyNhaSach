namespace GUI.User_Controls
{
    partial class UC_Customer
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
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation2 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Customer));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.uC_Customer_Detail1 = new GUI.User_Controls.UC_Customer_Detail();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.uC_Customer_Default1 = new GUI.User_Controls.UC_Customer_Default();
            this.bunifuPages1 = new Bunifu.UI.WinForms.BunifuPages();
            this.btnAdd = new Bunifu.UI.WinForms.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lbCustomer = new System.Windows.Forms.Label();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.bunifuPages1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 75;
            this.bunifuElipse1.TargetControl = this;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.uC_Customer_Detail1);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1047, 651);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CustomerDetails";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // uC_Customer_Detail1
            // 
            this.uC_Customer_Detail1.AutoScroll = true;
            this.uC_Customer_Detail1.BackColor = System.Drawing.Color.White;
            this.uC_Customer_Detail1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Customer_Detail1.Location = new System.Drawing.Point(3, 3);
            this.uC_Customer_Detail1.Margin = new System.Windows.Forms.Padding(2);
            this.uC_Customer_Detail1.Name = "uC_Customer_Detail1";
            this.uC_Customer_Detail1.Size = new System.Drawing.Size(1041, 645);
            this.uC_Customer_Detail1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.uC_Customer_Default1);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1047, 651);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CustomerDefault";
            // 
            // uC_Customer_Default1
            // 
            this.uC_Customer_Default1.BackColor = System.Drawing.Color.White;
            this.uC_Customer_Default1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Customer_Default1.Location = new System.Drawing.Point(3, 3);
            this.uC_Customer_Default1.Name = "uC_Customer_Default1";
            this.uC_Customer_Default1.Size = new System.Drawing.Size(1041, 645);
            this.uC_Customer_Default1.TabIndex = 0;
            // 
            // bunifuPages1
            // 
            this.bunifuPages1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.bunifuPages1.AllowTransitions = true;
            this.bunifuPages1.Controls.Add(this.tabPage1);
            this.bunifuPages1.Controls.Add(this.tabPage2);
            this.bunifuPages1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPages1.Location = new System.Drawing.Point(0, 79);
            this.bunifuPages1.Multiline = true;
            this.bunifuPages1.Name = "bunifuPages1";
            this.bunifuPages1.Page = this.tabPage1;
            this.bunifuPages1.PageIndex = 0;
            this.bunifuPages1.PageName = "tabPage1";
            this.bunifuPages1.PageTitle = "CustomerDefault";
            this.bunifuPages1.SelectedIndex = 0;
            this.bunifuPages1.Size = new System.Drawing.Size(1055, 677);
            this.bunifuPages1.TabIndex = 10;
            animation2.AnimateOnlyDifferences = false;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.bunifuPages1.Transition = animation2;
            this.bunifuPages1.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // btnAdd
            // 
            this.btnAdd.ActiveImage = null;
            this.btnAdd.AllowAnimations = true;
            this.btnAdd.AllowBuffering = false;
            this.btnAdd.AllowZooming = true;
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.ErrorImage")));
            this.btnAdd.FadeWhenInactive = false;
            this.btnAdd.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageActive = null;
            this.btnAdd.ImageLocation = null;
            this.btnAdd.ImageMargin = 40;
            this.btnAdd.ImageSize = new System.Drawing.Size(32, 37);
            this.btnAdd.ImageZoomSize = new System.Drawing.Size(72, 77);
            this.btnAdd.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.InitialImage")));
            this.btnAdd.Location = new System.Drawing.Point(884, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Rotation = 0;
            this.btnAdd.ShowActiveImage = true;
            this.btnAdd.ShowCursorChanges = true;
            this.btnAdd.ShowImageBorders = true;
            this.btnAdd.ShowSizeMarkers = false;
            this.btnAdd.Size = new System.Drawing.Size(72, 77);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.ToolTipText = "";
            this.btnAdd.WaitOnLoad = false;
            this.btnAdd.Zoom = 40;
            this.btnAdd.ZoomSpeed = 10;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.bunifuSeparator1);
            this.panel1.Controls.Add(this.lbCustomer);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1055, 79);
            this.panel1.TabIndex = 9;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(308, 57);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(446, 15);
            this.bunifuSeparator1.TabIndex = 14;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // lbCustomer
            // 
            this.lbCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCustomer.AutoSize = true;
            this.lbCustomer.Font = new System.Drawing.Font("Dream Meadow", 42F);
            this.lbCustomer.Location = new System.Drawing.Point(438, 2);
            this.lbCustomer.Name = "lbCustomer";
            this.lbCustomer.Size = new System.Drawing.Size(178, 74);
            this.lbCustomer.TabIndex = 13;
            this.lbCustomer.Text = "Customer";
            this.lbCustomer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UC_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuPages1);
            this.Controls.Add(this.panel1);
            this.Name = "UC_Customer";
            this.Size = new System.Drawing.Size(1055, 756);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.bunifuPages1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuPages bunifuPages1;
        private System.Windows.Forms.TabPage tabPage1;
        private UC_Customer_Default uC_Customer_Default1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuImageButton btnAdd;
        private UC_Customer_Detail uC_Customer_Detail1;
        private System.Windows.Forms.Label lbCustomer;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
    }
}
