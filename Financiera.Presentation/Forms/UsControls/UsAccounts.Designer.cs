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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.tgStatus = new RJCodeAdvance.RJControls.RJToggleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).BeginInit();
            this.SuspendLayout();
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
            this.label1.Location = new System.Drawing.Point(482, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Estado de cuenta:";
            // 
            // dgvAccounts
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvAccounts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAccounts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAccounts.ColumnHeadersHeight = 30;
            this.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAccounts.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAccounts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAccounts.Location = new System.Drawing.Point(44, 273);
            this.dgvAccounts.Name = "dgvAccounts";
            this.dgvAccounts.ReadOnly = true;
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
            this.dgvAccounts.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvAccounts.ThemeStyle.ReadOnly = true;
            this.dgvAccounts.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAccounts.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAccounts.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvAccounts.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvAccounts.ThemeStyle.RowsStyle.Height = 25;
            this.dgvAccounts.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAccounts.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvAccounts.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccounts_CellContentDoubleClick);
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
            this.txtDniClient.Location = new System.Drawing.Point(203, 50);
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
            this.pbxPhoto.Location = new System.Drawing.Point(44, 28);
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
            this.pickerDate.Location = new System.Drawing.Point(203, 121);
            this.pickerDate.MinimumSize = new System.Drawing.Size(4, 35);
            this.pickerDate.Name = "pickerDate";
            this.pickerDate.Size = new System.Drawing.Size(241, 35);
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
            this.btSearchAcc.Click += new System.EventHandler(this.btSearchAcc_Click);
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
            this.btAgg.Location = new System.Drawing.Point(613, 217);
            this.btAgg.Name = "btAgg";
            this.btAgg.Size = new System.Drawing.Size(110, 31);
            this.btAgg.TabIndex = 28;
            this.btAgg.Text = "Registrar";
            this.btAgg.TextColor = System.Drawing.Color.White;
            this.btAgg.UseVisualStyleBackColor = false;
            this.btAgg.Click += new System.EventHandler(this.btAgg_Click);
            // 
            // tgStatus
            // 
            this.tgStatus.AutoSize = true;
            this.tgStatus.Location = new System.Drawing.Point(614, 136);
            this.tgStatus.MinimumSize = new System.Drawing.Size(45, 22);
            this.tgStatus.Name = "tgStatus";
            this.tgStatus.OffBackColor = System.Drawing.Color.Salmon;
            this.tgStatus.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tgStatus.OnBackColor = System.Drawing.Color.LimeGreen;
            this.tgStatus.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tgStatus.Size = new System.Drawing.Size(45, 22);
            this.tgStatus.TabIndex = 33;
            this.tgStatus.UseVisualStyleBackColor = true;
            this.tgStatus.CheckedChanged += new System.EventHandler(this.tgStatus_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(528, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Tipo de cuenta";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbStatus.Location = new System.Drawing.Point(684, 136);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(0, 20);
            this.lbStatus.TabIndex = 35;
            // 
            // UsAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tgStatus);
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
            this.Name = "UsAccounts";
            this.Size = new System.Drawing.Size(1036, 462);
            this.Load += new System.EventHandler(this.UsCounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private RJCodeAdvance.RJControls.RJToggleButton tgStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbStatus;
    }
}
