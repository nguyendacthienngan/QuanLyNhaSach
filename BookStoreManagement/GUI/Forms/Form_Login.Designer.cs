namespace GUI.Forms
{
    partial class Form_Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.gradientBackground1 = new GUI.GradientBackground();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.slideUp_Login1 = new GUI.User_Controls.SlideUp_Login();
            this.Shadow = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.gradientBackground1.SuspendLayout();
            this.loginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Shadow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientBackground1
            // 
            this.gradientBackground1.Angle = 29F;
            this.gradientBackground1.Color0 = System.Drawing.Color.DarkViolet;
            this.gradientBackground1.Color1 = System.Drawing.Color.Orange;
            this.gradientBackground1.Controls.Add(this.loginPanel);
            this.gradientBackground1.Controls.Add(this.Shadow);
            this.gradientBackground1.Controls.Add(this.bunifuImageButton1);
            this.gradientBackground1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientBackground1.Location = new System.Drawing.Point(0, 0);
            this.gradientBackground1.Margin = new System.Windows.Forms.Padding(2);
            this.gradientBackground1.Name = "gradientBackground1";
            this.gradientBackground1.Size = new System.Drawing.Size(548, 621);
            this.gradientBackground1.TabIndex = 0;
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.Color.Black;
            this.loginPanel.Controls.Add(this.slideUp_Login1);
            this.loginPanel.Location = new System.Drawing.Point(83, 57);
            this.loginPanel.Margin = new System.Windows.Forms.Padding(2);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(386, 519);
            this.loginPanel.TabIndex = 12;
            // 
            // slideUp_Login1
            // 
            this.slideUp_Login1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slideUp_Login1.Location = new System.Drawing.Point(0, 0);
            this.slideUp_Login1.Name = "slideUp_Login1";
            this.slideUp_Login1.Size = new System.Drawing.Size(386, 519);
            this.slideUp_Login1.TabIndex = 0;
            // 
            // Shadow
            // 
            this.Shadow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Shadow.BackColor = System.Drawing.Color.Transparent;
            this.Shadow.Enabled = false;
            this.Shadow.Image = ((System.Drawing.Image)(resources.GetObject("Shadow.Image")));
            this.Shadow.Location = new System.Drawing.Point(68, 44);
            this.Shadow.Name = "Shadow";
            this.Shadow.Size = new System.Drawing.Size(430, 556);
            this.Shadow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Shadow.TabIndex = 11;
            this.Shadow.TabStop = false;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(499, 2);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(38, 46);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 7;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.gradientBackground1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this.loginPanel;
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 621);
            this.Controls.Add(this.gradientBackground1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Login";
            this.gradientBackground1.ResumeLayout(false);
            this.loginPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Shadow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private GradientBackground gradientBackground1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox Shadow;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel loginPanel;
        private User_Controls.SlideUp_Login slideUp_Login1;
    }
}