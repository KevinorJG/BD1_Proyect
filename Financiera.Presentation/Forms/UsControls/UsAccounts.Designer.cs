namespace Financiera.Presentation.Forms.UsControls
{
    partial class UsAccounts
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtAmount = new RJCodeAdvance.RJControls.RJTextBox();
            this.cbTypeCoin = new RJCodeAdvance.RJControls.RJComboBox();
            this.cbTyCount = new RJCodeAdvance.RJControls.RJComboBox();
            this.lbCounts = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAccounts = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtDniClient = new RJCodeAdvance.RJControls.RJTextBox();
            this.pbxPhoto = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.pickerDate = new RJCodeAdvance.RJControls.RJDatePicker();
            this.txtSearch = new RJCodeAdvance.RJControls.RJTextBox();
            this.btSearchAcc = new RJCodeAdvance.RJControls.RJButton();
            this.btDeleteAcc = new RJCodeAdvance.RJControls.RJButton();
            this.btAgg = new RJCodeAdvance.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.SystemColors.Window;
            this.txtAmount.BorderColor = System.Drawing.Color.Silver;
            this.txtAmount.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtAmount.BorderRadius = 0;
            this.txtAmount.BorderSize = 2;
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAmount.Location = new System.Drawing.Point(197, 50);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtAmount.Multiline = false;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtAmount.PasswordChar = false;
            this.txtAmount.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAmount.PlaceholderText = "Monto inicial";
            this.txtAmount.Size = new System.Drawing.Size(239, 31);
            this.txtAmount.TabIndex = 11;
            this.txtAmount.Texts = "";
            this.txtAmount.UnderlinedStyle = false;
            // 
            // cbTypeCoin
            // 
            this.cbTypeCoin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbTypeCoin.BorderColor = System.Drawing.Color.DarkGray;
            this.cbTypeCoin.BorderSize = 1;
            this.cbTypeCoin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbTypeCoin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbTypeCoin.ForeColor = System.Drawing.Color.DimGray;
            this.cbTypeCoin.IconColor = System.Drawing.Color.RoyalBlue;
            this.cbTypeCoin.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbTypeCoin.ListTextColor = System.Drawing.Color.DimGray;
            this.cbTypeCoin.Location = new System.Drawing.Point(724, 51);
            this.cbTypeCoin.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbTypeCoin.Name = "cbTypeCoin";
            this.cbTypeCoin.Padding = new System.Windows.Forms.Padding(1);
            this.cbTypeCoin.Size = new System.Drawing.Size(200, 30);
            this.cbTypeCoin.TabIndex = 17;
            this.cbTypeCoin.Texts = "";
            // 
            // cbTyCount
            // 
            this.cbTyCount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbTyCount.BorderColor = System.Drawing.Color.DarkGray;
            this.cbTyCount.BorderSize = 1;
            this.cbTyCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbTyCount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbTyCount.ForeColor = System.Drawing.Color.DimGray;
            this.cbTyCount.IconColor = System.Drawing.Color.RoyalBlue;
            this.cbTyCount.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbTyCount.ListTextColor = System.Drawing.Color.DimGray;
            this.cbTyCount.Location = new System.Drawing.Point(482, 50);
            this.cbTyCount.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbTyCount.Name = "cbTyCount";
            this.cbTyCount.Padding = new System.Windows.Forms.Padding(1);
            this.cbTyCount.Size = new System.Drawing.Size(200, 30);
            this.cbTyCount.TabIndex = 18;
            this.cbTyCount.Texts = "";
            // 
            // lbCounts
            // 
            this.lbCounts.AutoSize = true;
            this.lbCounts.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCounts.Location = new System.Drawing.Point(794, 28);
            this.lbCounts.Name = "lbCounts";
            this.lbCounts.Size = new System.Drawing.Size(64, 20);
            this.lbCounts.TabIndex = 20;
            this.lbCounts.Text = "Moneda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(530, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Tipo de cuenta";
            // 
            // dgvAccounts
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvAccounts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAccounts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAccounts.ColumnHeadersHeight = 4;
            this.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAccounts.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAccounts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAccounts.Location = new System.Drawing.Point(44, 273);
            this.dgvAccounts.Name = "dgvAccounts";
            this.dgvAccounts.RowHeadersVisible = false;
            this.dgvAccounts.RowTemplate.Height = 25;
            this.dgvAccounts.Size = new System.Drawing.Size(953, 150);
            this.dgvAccounts.TabIndex = 24;
            this.dgvAccounts.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAccounts.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvAccounts.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvAccounts.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvAccounts.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvAccounts.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvAccounts.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAccounts.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvAccounts.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAccounts.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvAccounts.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAccounts.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvAccounts.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvAccounts.ThemeStyle.ReadOnly = false;
            this.dgvAccounts.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAccounts.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAccounts.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvAccounts.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvAccounts.ThemeStyle.RowsStyle.Height = 25;
            this.dgvAccounts.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAccounts.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // txtDniClient
            // 
            this.txtDniClient.BackColor = System.Drawing.SystemColors.Window;
            this.txtDniClient.BorderColor = System.Drawing.Color.Silver;
            this.txtDniClient.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDniClient.BorderRadius = 0;
            this.txtDniClient.BorderSize = 2;
            this.txtDniClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDniClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDniClient.Location = new System.Drawing.Point(197, 111);
            this.txtDniClient.Margin = new System.Windows.Forms.Padding(4);
            this.txtDniClient.Multiline = false;
            this.txtDniClient.Name = "txtDniClient";
            this.txtDniClient.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDniClient.PasswordChar = false;
            this.txtDniClient.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDniClient.PlaceholderText = "Cédula del cliente";
            this.txtDniClient.Size = new System.Drawing.Size(239, 31);
            this.txtDniClient.TabIndex = 25;
            this.txtDniClient.Texts = "";
            this.txtDniClient.UnderlinedStyle = false;
            this.txtDniClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDniClient_KeyPress);
            // 
            // pbxPhoto
            // 
            this.pbxPhoto.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pbxPhoto.BorderColor = System.Drawing.Color.Violet;
            this.pbxPhoto.BorderColor2 = System.Drawing.Color.Yellow;
            this.pbxPhoto.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pbxPhoto.BorderSize = 2;
            this.pbxPhoto.GradientAngle = 50F;
            this.pbxPhoto.Image = global::Financiera.Presentation.Properties.Resources.value;
            this.pbxPhoto.Location = new System.Drawing.Point(27, 23);
            this.pbxPhoto.Name = "pbxPhoto";
            this.pbxPhoto.Size = new System.Drawing.Size(100, 100);
            this.pbxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPhoto.TabIndex = 26;
            this.pbxPhoto.TabStop = false;
            // 
            // pickerDate
            // 
            this.pickerDate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.pickerDate.BorderSize = 0;
            this.pickerDate.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pickerDate.Location = new System.Drawing.Point(482, 111);
            this.pickerDate.MinimumSize = new System.Drawing.Size(4, 35);
            this.pickerDate.Name = "pickerDate";
            this.pickerDate.Size = new System.Drawing.Size(233, 35);
            this.pickerDate.SkinColor = System.Drawing.Color.Silver;
            this.pickerDate.TabIndex = 27;
            this.pickerDate.TextColor = System.Drawing.Color.White;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.txtSearch.BorderColor = System.Drawing.Color.Silver;
            this.txtSearch.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSearch.BorderRadius = 0;
            this.txtSearch.BorderSize = 2;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearch.Location = new System.Drawing.Point(44, 217);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSearch.PasswordChar = false;
            this.txtSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSearch.PlaceholderText = "Cédula del cliente";
            this.txtSearch.Size = new System.Drawing.Size(398, 31);
            this.txtSearch.TabIndex = 32;
            this.txtSearch.Texts = "";
            this.txtSearch.UnderlinedStyle = false;
            // 
            // btSearchAcc
            // 
            this.btSearchAcc.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btSearchAcc.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btSearchAcc.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btSearchAcc.BorderRadius = 5;
            this.btSearchAcc.BorderSize = 0;
            this.btSearchAcc.FlatAppearance.BorderSize = 0;
            this.btSearchAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSearchAcc.ForeColor = System.Drawing.Color.White;
            this.btSearchAcc.Location = new System.Drawing.Point(466, 217);
            this.btSearchAcc.Name = "btSearchAcc";
            this.btSearchAcc.Size = new System.Drawing.Size(110, 31);
            this.btSearchAcc.TabIndex = 31;
            this.btSearchAcc.Text = "Buscar";
            this.btSearchAcc.TextColor = System.Drawing.Color.White;
            this.btSearchAcc.UseVisualStyleBackColor = false;
            // 
            // btDeleteAcc
            // 
            this.btDeleteAcc.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btDeleteAcc.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btDeleteAcc.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btDeleteAcc.BorderRadius = 5;
            this.btDeleteAcc.BorderSize = 0;
            this.btDeleteAcc.FlatAppearance.BorderSize = 0;
            this.btDeleteAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDeleteAcc.ForeColor = System.Drawing.Color.White;
            this.btDeleteAcc.Location = new System.Drawing.Point(759, 217);
            this.btDeleteAcc.Name = "btDeleteAcc";
            this.btDeleteAcc.Size = new System.Drawing.Size(110, 31);
            this.btDeleteAcc.TabIndex = 29;
            this.btDeleteAcc.Text = "Eliminar";
            this.btDeleteAcc.TextColor = System.Drawing.Color.White;
            this.btDeleteAcc.UseVisualStyleBackColor = false;
            // 
            // btAgg
            // 
            this.btAgg.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btAgg.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btAgg.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btAgg.BorderRadius = 5;
            this.btAgg.BorderSize = 0;
            this.btAgg.FlatAppearance.BorderSize = 0;
            this.btAgg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAgg.ForeColor = System.Drawing.Color.White;
            this.btAgg.Location = new System.Drawing.Point(602, 217);
            this.btAgg.Name = "btAgg";
            this.btAgg.Size = new System.Drawing.Size(110, 31);
            this.btAgg.TabIndex = 28;
            this.btAgg.Text = "Registrar";
            this.btAgg.TextColor = System.Drawing.Color.White;
            this.btAgg.UseVisualStyleBackColor = false;
            this.btAgg.Click += new System.EventHandler(this.btAgg_Click);
            // 
            // UsCounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btSearchAcc);
            this.Controls.Add(this.btDeleteAcc);
            this.Controls.Add(this.btAgg);
            this.Controls.Add(this.pickerDate);
            this.Controls.Add(this.pbxPhoto);
            this.Controls.Add(this.txtDniClient);
            this.Controls.Add(this.dgvAccounts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCounts);
            this.Controls.Add(this.cbTyCount);
            this.Controls.Add(this.cbTypeCoin);
            this.Controls.Add(this.txtAmount);
            this.Name = "UsCounts";
            this.Size = new System.Drawing.Size(1036, 462);
            this.Load += new System.EventHandler(this.UsCounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RJCodeAdvance.RJControls.RJTextBox txtAmount;
        private RJCodeAdvance.RJControls.RJComboBox cbTypeCoin;
        private RJCodeAdvance.RJControls.RJComboBox cbTyCount;
        private System.Windows.Forms.Label lbCounts;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvAccounts;
        private RJCodeAdvance.RJControls.RJTextBox txtDniClient;
        private RJCodeAdvance.RJControls.RJCircularPictureBox pbxPhoto;
        private RJCodeAdvance.RJControls.RJDatePicker pickerDate;
        private RJCodeAdvance.RJControls.RJTextBox txtSearch;
        private RJCodeAdvance.RJControls.RJButton btSearchAcc;
        private RJCodeAdvance.RJControls.RJButton btDeleteAcc;
        private RJCodeAdvance.RJControls.RJButton btAgg;
    }
}
