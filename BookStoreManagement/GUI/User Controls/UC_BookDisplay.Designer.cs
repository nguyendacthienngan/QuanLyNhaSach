namespace GUI.User_Controls
{
    partial class UC_BookDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_BookDisplay));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.picCover = new System.Windows.Forms.PictureBox();
            this.btnDelete = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelButton = new System.Windows.Forms.Panel();
            this.btnEdit = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuToolTip1 = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            this.panelButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panelTitle);
            this.panel1.Controls.Add(this.picCover);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 268);
            this.panel1.TabIndex = 0;
            this.bunifuToolTip1.SetToolTip(this.panel1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel1, "");
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.Black;
            this.panelTitle.Controls.Add(this.lbPrice);
            this.panelTitle.Controls.Add(this.lbAuthor);
            this.panelTitle.Controls.Add(this.lbTitle);
            this.panelTitle.Location = new System.Drawing.Point(0, 213);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(178, 55);
            this.panelTitle.TabIndex = 4;
            this.bunifuToolTip1.SetToolTip(this.panelTitle, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panelTitle, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panelTitle, "");
            this.panelTitle.MouseLeave += new System.EventHandler(this.panelTitle_MouseLeave);
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.ForeColor = System.Drawing.Color.White;
            this.lbPrice.Location = new System.Drawing.Point(141, 32);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(34, 13);
            this.lbPrice.TabIndex = 2;
            this.lbPrice.Text = "$9.99";
            this.bunifuToolTip1.SetToolTip(this.lbPrice, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lbPrice, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lbPrice, "");
            // 
            // lbAuthor
            // 
            this.lbAuthor.AutoSize = true;
            this.lbAuthor.ForeColor = System.Drawing.Color.White;
            this.lbAuthor.Location = new System.Drawing.Point(4, 32);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(86, 13);
            this.lbAuthor.TabIndex = 1;
            this.lbAuthor.Text = "by Rachel Sefert";
            this.bunifuToolTip1.SetToolTip(this.lbAuthor, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lbAuthor, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lbAuthor, "");
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(3, 4);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(129, 21);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "A Boy In Winter";
            this.bunifuToolTip1.SetToolTip(this.lbTitle, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lbTitle, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lbTitle, "");
            // 
            // picCover
            // 
            this.picCover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCover.Image = ((System.Drawing.Image)(resources.GetObject("picCover.Image")));
            this.picCover.Location = new System.Drawing.Point(0, 0);
            this.picCover.Margin = new System.Windows.Forms.Padding(18);
            this.picCover.Name = "picCover";
            this.picCover.Size = new System.Drawing.Size(178, 268);
            this.picCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCover.TabIndex = 3;
            this.picCover.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.picCover, "");
            this.bunifuToolTip1.SetToolTipIcon(this.picCover, null);
            this.bunifuToolTip1.SetToolTipTitle(this.picCover, "");
            this.picCover.MouseEnter += new System.EventHandler(this.picCover_MouseEnter);
            this.picCover.MouseLeave += new System.EventHandler(this.picCover_MouseLeave);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageActive = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageActive")));
            this.btnDelete.Location = new System.Drawing.Point(152, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(23, 32);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDelete.TabIndex = 0;
            this.btnDelete.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.btnDelete, "Delete Book");
            this.bunifuToolTip1.SetToolTipIcon(this.btnDelete, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnDelete, "");
            this.btnDelete.Zoom = 10;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseLeave += new System.EventHandler(this.btnDelete_MouseLeave);
            // 
            // panelButton
            // 
            this.panelButton.BackColor = System.Drawing.Color.Black;
            this.panelButton.Controls.Add(this.btnEdit);
            this.panelButton.Controls.Add(this.btnDelete);
            this.panelButton.Location = new System.Drawing.Point(0, 0);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(178, 38);
            this.panelButton.TabIndex = 6;
            this.bunifuToolTip1.SetToolTip(this.panelButton, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panelButton, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panelButton, "");
            this.panelButton.MouseLeave += new System.EventHandler(this.panelButton_MouseLeave);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageActive = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageActive")));
            this.btnEdit.Location = new System.Drawing.Point(7, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(23, 32);
            this.btnEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEdit.TabIndex = 1;
            this.btnEdit.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.btnEdit, "Edit Book");
            this.bunifuToolTip1.SetToolTipIcon(this.btnEdit, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnEdit, "");
            this.btnEdit.Zoom = 10;
            this.btnEdit.MouseLeave += new System.EventHandler(this.btnEdit_MouseLeave);
            // 
            // bunifuToolTip1
            // 
            this.bunifuToolTip1.Active = true;
            this.bunifuToolTip1.AlignTextWithTitle = false;
            this.bunifuToolTip1.AllowAutoClose = false;
            this.bunifuToolTip1.AllowFading = true;
            this.bunifuToolTip1.AutoCloseDuration = 5000;
            this.bunifuToolTip1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuToolTip1.BorderColor = System.Drawing.Color.Gainsboro;
            this.bunifuToolTip1.ClickToShowDisplayControl = false;
            this.bunifuToolTip1.ConvertNewlinesToBreakTags = true;
            this.bunifuToolTip1.DisplayControl = null;
            this.bunifuToolTip1.EntryAnimationSpeed = 350;
            this.bunifuToolTip1.ExitAnimationSpeed = 200;
            this.bunifuToolTip1.GenerateAutoCloseDuration = false;
            this.bunifuToolTip1.IconMargin = 6;
            this.bunifuToolTip1.InitialDelay = 0;
            this.bunifuToolTip1.Name = "bunifuToolTip1";
            this.bunifuToolTip1.Opacity = 1D;
            this.bunifuToolTip1.OverrideToolTipTitles = false;
            this.bunifuToolTip1.Padding = new System.Windows.Forms.Padding(10);
            this.bunifuToolTip1.ReshowDelay = 100;
            this.bunifuToolTip1.ShowAlways = true;
            this.bunifuToolTip1.ShowBorders = false;
            this.bunifuToolTip1.ShowIcons = true;
            this.bunifuToolTip1.ShowShadows = true;
            this.bunifuToolTip1.Tag = null;
            this.bunifuToolTip1.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuToolTip1.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuToolTip1.TextMargin = 2;
            this.bunifuToolTip1.TitleFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.bunifuToolTip1.TitleForeColor = System.Drawing.Color.Black;
            this.bunifuToolTip1.ToolTipPosition = new System.Drawing.Point(0, 0);
            this.bunifuToolTip1.ToolTipTitle = null;
            // 
            // UC_BookDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelButton);
            this.Controls.Add(this.panel1);
            this.Name = "UC_BookDisplay";
            this.Size = new System.Drawing.Size(178, 268);
            this.bunifuToolTip1.SetToolTip(this, "");
            this.bunifuToolTip1.SetToolTipIcon(this, null);
            this.bunifuToolTip1.SetToolTipTitle(this, "");
            this.panel1.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            this.panelButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbAuthor;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.PictureBox picCover;
        private Bunifu.Framework.UI.BunifuImageButton btnDelete;
        private System.Windows.Forms.Panel panelButton;
        private Bunifu.Framework.UI.BunifuImageButton btnEdit;
        private Bunifu.UI.WinForms.BunifuToolTip bunifuToolTip1;
    }
}
