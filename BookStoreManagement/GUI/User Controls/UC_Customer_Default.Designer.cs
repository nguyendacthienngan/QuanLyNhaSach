namespace GUI.User_Controls
{
    partial class UC_Customer_Default
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.contentPanel = new System.Windows.Forms.Panel();
            this.dgvCustomer = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txtFilter = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbFilter = new System.Windows.Forms.Label();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 75;
            this.bunifuElipse1.TargetControl = this;
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.dgvCustomer);
            this.contentPanel.Controls.Add(this.txtFilter);
            this.contentPanel.Controls.Add(this.lbFilter);
            this.contentPanel.Location = new System.Drawing.Point(3, 19);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(931, 651);
            this.contentPanel.TabIndex = 8;
            // 
            // dgvCustomer
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvCustomer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomer.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(193)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomer.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCustomer.DoubleBuffered = true;
            this.dgvCustomer.EnableHeadersVisualStyles = false;
            this.dgvCustomer.HeaderBgColor = System.Drawing.Color.Black;
            this.dgvCustomer.HeaderForeColor = System.Drawing.Color.White;
            this.dgvCustomer.Location = new System.Drawing.Point(72, 84);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(193)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomer.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCustomer.Size = new System.Drawing.Size(842, 564);
            this.dgvCustomer.TabIndex = 6;
            // 
            // txtFilter
            // 
            this.txtFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtFilter.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtFilter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilter.Font = new System.Drawing.Font("Futura Lt BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFilter.HintForeColor = System.Drawing.Color.Empty;
            this.txtFilter.HintText = "";
            this.txtFilter.isPassword = false;
            this.txtFilter.LineFocusedColor = System.Drawing.Color.Black;
            this.txtFilter.LineIdleColor = System.Drawing.Color.Black;
            this.txtFilter.LineMouseHoverColor = System.Drawing.Color.Black;
            this.txtFilter.LineThickness = 4;
            this.txtFilter.Location = new System.Drawing.Point(171, 19);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtFilter.MaxLength = 32767;
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(249, 39);
            this.txtFilter.TabIndex = 5;
            this.txtFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFilter.OnValueChanged += new System.EventHandler(this.txtFilter_OnValueChanged);
            // 
            // lbFilter
            // 
            this.lbFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbFilter.AutoSize = true;
            this.lbFilter.Font = new System.Drawing.Font("Ink Free", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilter.Location = new System.Drawing.Point(87, 28);
            this.lbFilter.Name = "lbFilter";
            this.lbFilter.Size = new System.Drawing.Size(76, 30);
            this.lbFilter.TabIndex = 3;
            this.lbFilter.Text = "Filter";
            // 
            // UC_Customer_Default
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.contentPanel);
            this.Name = "UC_Customer_Default";
            this.Size = new System.Drawing.Size(937, 798);
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Label lbFilter;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtFilter;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvCustomer;
    }
}
