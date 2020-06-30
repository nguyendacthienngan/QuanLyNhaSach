namespace GUI.User_Controls
{
    partial class UC_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Home));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.homeIcon = new System.Windows.Forms.PictureBox();
            this.homeLabel = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.illustration = new System.Windows.Forms.PictureBox();
            this.label23 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbBestSeller = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lbProfits = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lbTotalOrders = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).BeginInit();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.illustration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
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
            this.homeLabel.Font = new System.Drawing.Font("Dream Meadow", 51.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.homeLabel.Location = new System.Drawing.Point(451, 0);
            this.homeLabel.Name = "homeLabel";
            this.homeLabel.Size = new System.Drawing.Size(147, 92);
            this.homeLabel.TabIndex = 1;
            this.homeLabel.Text = "Home";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(287, 79);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4);
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
            this.contentPanel.AutoScroll = true;
            this.contentPanel.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.contentPanel.Controls.Add(this.lbTotalOrders);
            this.contentPanel.Controls.Add(this.pictureBox5);
            this.contentPanel.Controls.Add(this.lbProfits);
            this.contentPanel.Controls.Add(this.pictureBox4);
            this.contentPanel.Controls.Add(this.lbBestSeller);
            this.contentPanel.Controls.Add(this.pictureBox3);
            this.contentPanel.Controls.Add(this.richTextBox1);
            this.contentPanel.Controls.Add(this.label23);
            this.contentPanel.Controls.Add(this.pictureBox1);
            this.contentPanel.Controls.Add(this.illustration);
            this.contentPanel.Location = new System.Drawing.Point(21, 95);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(968, 474);
            this.contentPanel.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 522);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(353, 462);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // illustration
            // 
            this.illustration.Image = ((System.Drawing.Image)(resources.GetObject("illustration.Image")));
            this.illustration.Location = new System.Drawing.Point(0, 20);
            this.illustration.Name = "illustration";
            this.illustration.Size = new System.Drawing.Size(329, 436);
            this.illustration.TabIndex = 6;
            this.illustration.TabStop = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Futura Lt BT", 38F);
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(375, 20);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(226, 61);
            this.label23.TabIndex = 17;
            this.label23.Text = "Welcome";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Futura Bk BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Gray;
            this.richTextBox1.Location = new System.Drawing.Point(386, 107);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(523, 185);
            this.richTextBox1.TabIndex = 30;
            this.richTextBox1.Text = "With the Bookshop Management System, we hope to help managing your store as simpl" +
    "e and efficient as possible. Let\'s begin.\n\n\nHere\'s an overview of the shop activ" +
    "ities this month:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(386, 252);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 32;
            this.pictureBox3.TabStop = false;
            // 
            // lbBestSeller
            // 
            this.lbBestSeller.AutoSize = true;
            this.lbBestSeller.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBestSeller.ForeColor = System.Drawing.Color.DimGray;
            this.lbBestSeller.Location = new System.Drawing.Point(432, 261);
            this.lbBestSeller.Name = "lbBestSeller";
            this.lbBestSeller.Size = new System.Drawing.Size(178, 19);
            this.lbBestSeller.TabIndex = 33;
            this.lbBestSeller.Text = "This month best seller is";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(386, 324);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 37;
            this.pictureBox4.TabStop = false;
            // 
            // lbProfits
            // 
            this.lbProfits.AutoSize = true;
            this.lbProfits.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProfits.ForeColor = System.Drawing.Color.DimGray;
            this.lbProfits.Location = new System.Drawing.Point(432, 333);
            this.lbProfits.Name = "lbProfits";
            this.lbProfits.Size = new System.Drawing.Size(274, 19);
            this.lbProfits.TabIndex = 38;
            this.lbProfits.Text = "This month profits curently is S100.00";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(386, 391);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(40, 40);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 39;
            this.pictureBox5.TabStop = false;
            // 
            // lbTotalOrders
            // 
            this.lbTotalOrders.AutoSize = true;
            this.lbTotalOrders.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalOrders.ForeColor = System.Drawing.Color.DimGray;
            this.lbTotalOrders.Location = new System.Drawing.Point(432, 400);
            this.lbTotalOrders.Name = "lbTotalOrders";
            this.lbTotalOrders.Size = new System.Drawing.Size(362, 19);
            this.lbTotalOrders.TabIndex = 40;
            this.lbTotalOrders.Text = "There have been 100 confirmed orders this month";
            // 
            // UC_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.homeLabel);
            this.Controls.Add(this.homeIcon);
            this.Name = "UC_Home";
            this.Size = new System.Drawing.Size(1012, 617);
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).EndInit();
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.illustration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label homeLabel;
        private System.Windows.Forms.PictureBox homeIcon;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox illustration;
        private System.Windows.Forms.Label lbTotalOrders;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lbProfits;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lbBestSeller;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label23;
    }
}
