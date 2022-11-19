namespace Financiera.Presentation.Forms.UsControls
{
    partial class UsClients
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
            this.pbxPhoto = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btAgg = new RJCodeAdvance.RJControls.RJButton();
            this.panelPrinc = new System.Windows.Forms.Panel();
            this.dvgClients = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtDirection = new System.Windows.Forms.TextBox();
            this.txtNationality = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtSurnames = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtNames = new System.Windows.Forms.TextBox();
            this.txtSearch = new RJCodeAdvance.RJControls.RJTextBox();
            this.btSearchClient = new RJCodeAdvance.RJControls.RJButton();
            this.btUpdate = new RJCodeAdvance.RJControls.RJButton();
            this.btDeleteClient = new RJCodeAdvance.RJControls.RJButton();
            this.pickerDate = new RJCodeAdvance.RJControls.RJDatePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).BeginInit();
            this.panelPrinc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgClients)).BeginInit();
            this.SuspendLayout();
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
            this.pbxPhoto.TabIndex = 0;
            this.pbxPhoto.TabStop = false;
            // 
            // btAgg
            // 
            this.btAgg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAgg.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btAgg.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btAgg.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btAgg.BorderRadius = 5;
            this.btAgg.BorderSize = 0;
            this.btAgg.FlatAppearance.BorderSize = 0;
            this.btAgg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAgg.ForeColor = System.Drawing.Color.White;
            this.btAgg.Location = new System.Drawing.Point(600, 207);
            this.btAgg.Name = "btAgg";
            this.btAgg.Size = new System.Drawing.Size(110, 31);
            this.btAgg.TabIndex = 9;
            this.btAgg.Text = "Registrar";
            this.btAgg.TextColor = System.Drawing.Color.White;
            this.btAgg.UseVisualStyleBackColor = false;
            this.btAgg.Click += new System.EventHandler(this.btAgg_Click);
            // 
            // panelPrinc
            // 
            this.panelPrinc.Controls.Add(this.dvgClients);
            this.panelPrinc.Controls.Add(this.txtDirection);
            this.panelPrinc.Controls.Add(this.txtNationality);
            this.panelPrinc.Controls.Add(this.txtDni);
            this.panelPrinc.Controls.Add(this.txtSurnames);
            this.panelPrinc.Controls.Add(this.txtPhone);
            this.panelPrinc.Controls.Add(this.txtNames);
            this.panelPrinc.Controls.Add(this.txtSearch);
            this.panelPrinc.Controls.Add(this.btSearchClient);
            this.panelPrinc.Controls.Add(this.btUpdate);
            this.panelPrinc.Controls.Add(this.btDeleteClient);
            this.panelPrinc.Controls.Add(this.pickerDate);
            this.panelPrinc.Controls.Add(this.btAgg);
            this.panelPrinc.Controls.Add(this.pbxPhoto);
            this.panelPrinc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrinc.Location = new System.Drawing.Point(0, 0);
            this.panelPrinc.Name = "panelPrinc";
            this.panelPrinc.Size = new System.Drawing.Size(1036, 462);
            this.panelPrinc.TabIndex = 10;
            // 
            // dvgClients
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dvgClients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dvgClients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dvgClients.ColumnHeadersHeight = 30;
            this.dvgClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgClients.DefaultCellStyle = dataGridViewCellStyle6;
            this.dvgClients.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dvgClients.Location = new System.Drawing.Point(42, 277);
            this.dvgClients.Name = "dvgClients";
            this.dvgClients.RowHeadersVisible = false;
            this.dvgClients.RowTemplate.Height = 25;
            this.dvgClients.Size = new System.Drawing.Size(953, 150);
            this.dvgClients.TabIndex = 26;
            this.dvgClients.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dvgClients.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dvgClients.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dvgClients.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dvgClients.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dvgClients.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dvgClients.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dvgClients.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dvgClients.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dvgClients.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dvgClients.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dvgClients.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dvgClients.ThemeStyle.HeaderStyle.Height = 30;
            this.dvgClients.ThemeStyle.ReadOnly = false;
            this.dvgClients.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dvgClients.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dvgClients.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dvgClients.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dvgClients.ThemeStyle.RowsStyle.Height = 25;
            this.dvgClients.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dvgClients.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dvgClients.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgClients_CellContentDoubleClick);
            // 
            // txtDirection
            // 
            this.txtDirection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDirection.Location = new System.Drawing.Point(740, 46);
            this.txtDirection.Multiline = true;
            this.txtDirection.Name = "txtDirection";
            this.txtDirection.PlaceholderText = "Domicilio";
            this.txtDirection.Size = new System.Drawing.Size(228, 107);
            this.txtDirection.TabIndex = 25;
            // 
            // txtNationality
            // 
            this.txtNationality.Location = new System.Drawing.Point(440, 157);
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.PlaceholderText = "Nacionalidad";
            this.txtNationality.Size = new System.Drawing.Size(188, 23);
            this.txtNationality.TabIndex = 24;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(440, 100);
            this.txtDni.Name = "txtDni";
            this.txtDni.PlaceholderText = "Identificacion";
            this.txtDni.Size = new System.Drawing.Size(239, 23);
            this.txtDni.TabIndex = 23;
            // 
            // txtSurnames
            // 
            this.txtSurnames.Location = new System.Drawing.Point(440, 48);
            this.txtSurnames.Name = "txtSurnames";
            this.txtSurnames.PlaceholderText = "Apellidos";
            this.txtSurnames.Size = new System.Drawing.Size(239, 23);
            this.txtSurnames.TabIndex = 22;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(159, 100);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PlaceholderText = "Numero telefonico";
            this.txtPhone.Size = new System.Drawing.Size(199, 23);
            this.txtPhone.TabIndex = 21;
            // 
            // txtNames
            // 
            this.txtNames.Location = new System.Drawing.Point(159, 48);
            this.txtNames.Name = "txtNames";
            this.txtNames.PlaceholderText = "Nombres";
            this.txtNames.Size = new System.Drawing.Size(199, 23);
            this.txtNames.TabIndex = 20;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.txtSearch.BorderColor = System.Drawing.Color.Silver;
            this.txtSearch.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSearch.BorderRadius = 0;
            this.txtSearch.BorderSize = 2;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearch.Location = new System.Drawing.Point(42, 207);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSearch.PasswordChar = false;
            this.txtSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSearch.PlaceholderText = "Cédula del cliente";
            this.txtSearch.Size = new System.Drawing.Size(398, 31);
            this.txtSearch.TabIndex = 19;
            this.txtSearch.Texts = "";
            this.txtSearch.UnderlinedStyle = false;
            // 
            // btSearchClient
            // 
            this.btSearchClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSearchClient.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btSearchClient.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btSearchClient.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btSearchClient.BorderRadius = 5;
            this.btSearchClient.BorderSize = 0;
            this.btSearchClient.FlatAppearance.BorderSize = 0;
            this.btSearchClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSearchClient.ForeColor = System.Drawing.Color.White;
            this.btSearchClient.Location = new System.Drawing.Point(464, 207);
            this.btSearchClient.Name = "btSearchClient";
            this.btSearchClient.Size = new System.Drawing.Size(110, 31);
            this.btSearchClient.TabIndex = 18;
            this.btSearchClient.Text = "Buscar";
            this.btSearchClient.TextColor = System.Drawing.Color.White;
            this.btSearchClient.UseVisualStyleBackColor = false;
            this.btSearchClient.Click += new System.EventHandler(this.btSearchClient_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btUpdate.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btUpdate.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btUpdate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btUpdate.BorderRadius = 5;
            this.btUpdate.BorderSize = 0;
            this.btUpdate.FlatAppearance.BorderSize = 0;
            this.btUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUpdate.ForeColor = System.Drawing.Color.White;
            this.btUpdate.Location = new System.Drawing.Point(740, 207);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(110, 31);
            this.btUpdate.TabIndex = 17;
            this.btUpdate.Text = "Actualizar";
            this.btUpdate.TextColor = System.Drawing.Color.White;
            this.btUpdate.UseVisualStyleBackColor = false;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btDeleteClient
            // 
            this.btDeleteClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btDeleteClient.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btDeleteClient.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btDeleteClient.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btDeleteClient.BorderRadius = 5;
            this.btDeleteClient.BorderSize = 0;
            this.btDeleteClient.FlatAppearance.BorderSize = 0;
            this.btDeleteClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDeleteClient.ForeColor = System.Drawing.Color.White;
            this.btDeleteClient.Location = new System.Drawing.Point(885, 207);
            this.btDeleteClient.Name = "btDeleteClient";
            this.btDeleteClient.Size = new System.Drawing.Size(110, 31);
            this.btDeleteClient.TabIndex = 16;
            this.btDeleteClient.Text = "Eliminar";
            this.btDeleteClient.TextColor = System.Drawing.Color.White;
            this.btDeleteClient.UseVisualStyleBackColor = false;
            // 
            // pickerDate
            // 
            this.pickerDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pickerDate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.pickerDate.BorderSize = 0;
            this.pickerDate.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pickerDate.Location = new System.Drawing.Point(148, 147);
            this.pickerDate.MinimumSize = new System.Drawing.Size(4, 35);
            this.pickerDate.Name = "pickerDate";
            this.pickerDate.Size = new System.Drawing.Size(244, 35);
            this.pickerDate.SkinColor = System.Drawing.Color.Silver;
            this.pickerDate.TabIndex = 10;
            this.pickerDate.TextColor = System.Drawing.Color.White;
            // 
            // UsClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelPrinc);
            this.Name = "UsClients";
            this.Size = new System.Drawing.Size(1036, 462);
            this.Load += new System.EventHandler(this.UsClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).EndInit();
            this.panelPrinc.ResumeLayout(false);
            this.panelPrinc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgClients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RJCodeAdvance.RJControls.RJCircularPictureBox pbxPhoto;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private RJCodeAdvance.RJControls.RJButton btAgg;
        private System.Windows.Forms.Panel panelPrinc;
        private RJCodeAdvance.RJControls.RJDatePicker pickerDate;
        private RJCodeAdvance.RJControls.RJTextBox txtSearch;
        private RJCodeAdvance.RJControls.RJButton btSearchClient;
        private RJCodeAdvance.RJControls.RJButton btUpdate;
        private RJCodeAdvance.RJControls.RJButton btDeleteClient;
        private System.Windows.Forms.TextBox txtDirection;
        private System.Windows.Forms.TextBox txtNationality;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtSurnames;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtNames;
        private Guna.UI2.WinForms.Guna2DataGridView dvgClients;
    }
}
