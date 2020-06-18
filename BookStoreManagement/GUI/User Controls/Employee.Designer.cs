namespace GUI.User_Controls
{
    partial class Employee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dgvEmployee = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.lbFilter = new System.Windows.Forms.Label();
            this.txtFilter = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbEmployee = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.UI.WinForms.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 75;
            this.bunifuElipse1.TargetControl = this;
            // 
            // dgvEmployee
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvEmployee.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmployee.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvEmployee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmployee.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.DoubleBuffered = true;
            this.dgvEmployee.EnableHeadersVisualStyles = false;
            this.dgvEmployee.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgvEmployee.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgvEmployee.Location = new System.Drawing.Point(61, 160);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEmployee.Size = new System.Drawing.Size(812, 537);
            this.dgvEmployee.TabIndex = 0;
            // 
            // cbFilter
            // 
            this.cbFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFilter.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Location = new System.Drawing.Point(163, 97);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(138, 30);
            this.cbFilter.TabIndex = 1;
            this.cbFilter.Text = "Choose one";
            // 
            // lbFilter
            // 
            this.lbFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbFilter.AutoSize = true;
            this.lbFilter.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilter.Location = new System.Drawing.Point(88, 99);
            this.lbFilter.Name = "lbFilter";
            this.lbFilter.Size = new System.Drawing.Size(53, 23);
            this.lbFilter.TabIndex = 2;
            this.lbFilter.Text = "Filter";
            // 
            // txtFilter
            // 
            this.txtFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtFilter.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtFilter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilter.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFilter.HintForeColor = System.Drawing.Color.Empty;
            this.txtFilter.HintText = "";
            this.txtFilter.isPassword = false;
            this.txtFilter.LineFocusedColor = System.Drawing.Color.LightSteelBlue;
            this.txtFilter.LineIdleColor = System.Drawing.Color.Thistle;
            this.txtFilter.LineMouseHoverColor = System.Drawing.Color.LightSteelBlue;
            this.txtFilter.LineThickness = 4;
            this.txtFilter.Location = new System.Drawing.Point(326, 97);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtFilter.MaxLength = 32767;
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(290, 43);
            this.txtFilter.TabIndex = 4;
            this.txtFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbEmployee
            // 
            this.lbEmployee.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbEmployee.AutoSize = true;
            this.lbEmployee.Font = new System.Drawing.Font("Dream Meadow", 42F);
            this.lbEmployee.Location = new System.Drawing.Point(374, 0);
            this.lbEmployee.Name = "lbEmployee";
            this.lbEmployee.Size = new System.Drawing.Size(181, 74);
            this.lbEmployee.TabIndex = 5;
            this.lbEmployee.Text = "Employee";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.ActiveImage = null;
            this.bunifuImageButton1.AllowAnimations = true;
            this.bunifuImageButton1.AllowBuffering = false;
            this.bunifuImageButton1.AllowZooming = true;
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ErrorImage")));
            this.bunifuImageButton1.FadeWhenInactive = false;
            this.bunifuImageButton1.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.ImageLocation = null;
            this.bunifuImageButton1.ImageMargin = 40;
            this.bunifuImageButton1.ImageSize = new System.Drawing.Size(50, 50);
            this.bunifuImageButton1.ImageZoomSize = new System.Drawing.Size(90, 90);
            this.bunifuImageButton1.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.InitialImage")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(792, 64);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Rotation = 0;
            this.bunifuImageButton1.ShowActiveImage = true;
            this.bunifuImageButton1.ShowCursorChanges = true;
            this.bunifuImageButton1.ShowImageBorders = true;
            this.bunifuImageButton1.ShowSizeMarkers = false;
            this.bunifuImageButton1.Size = new System.Drawing.Size(90, 90);
            this.bunifuImageButton1.TabIndex = 6;
            this.bunifuImageButton1.ToolTipText = "";
            this.bunifuImageButton1.WaitOnLoad = false;
            this.bunifuImageButton1.Zoom = 40;
            this.bunifuImageButton1.ZoomSpeed = 10;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.lbEmployee);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.lbFilter);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.dgvEmployee);
            this.Name = "Employee";
            this.Size = new System.Drawing.Size(937, 798);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvEmployee;
        private System.Windows.Forms.Label lbFilter;
        private System.Windows.Forms.ComboBox cbFilter;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtFilter;
        private System.Windows.Forms.Label lbEmployee;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
    }
}
