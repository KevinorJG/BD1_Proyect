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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pbxPhoto = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.txtNames = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtSurnames = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtDirection = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtPhone = new RJCodeAdvance.RJControls.RJTextBox();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtDate = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtNationality = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtDni = new RJCodeAdvance.RJControls.RJTextBox();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btAgg = new RJCodeAdvance.RJControls.RJButton();
            this.panelPrinc = new System.Windows.Forms.Panel();
            this.timerMenu = new System.Windows.Forms.Timer(this.components);
            this.timerMenuClose = new System.Windows.Forms.Timer(this.components);
            this.rjDatePicker1 = new RJCodeAdvance.RJControls.RJDatePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.panelPrinc.SuspendLayout();
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
            this.pbxPhoto.Location = new System.Drawing.Point(27, 23);
            this.pbxPhoto.Name = "pbxPhoto";
            this.pbxPhoto.Size = new System.Drawing.Size(100, 100);
            this.pbxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPhoto.TabIndex = 0;
            this.pbxPhoto.TabStop = false;
            this.pbxPhoto.Click += new System.EventHandler(this.pbxPhoto_Click);
            // 
            // txtNames
            // 
            this.txtNames.BackColor = System.Drawing.SystemColors.Window;
            this.txtNames.BorderColor = System.Drawing.Color.Silver;
            this.txtNames.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNames.BorderRadius = 0;
            this.txtNames.BorderSize = 2;
            this.txtNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNames.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNames.Location = new System.Drawing.Point(159, 48);
            this.txtNames.Margin = new System.Windows.Forms.Padding(4);
            this.txtNames.Multiline = false;
            this.txtNames.Name = "txtNames";
            this.txtNames.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNames.PasswordChar = false;
            this.txtNames.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNames.PlaceholderText = "Nombres";
            this.txtNames.Size = new System.Drawing.Size(239, 31);
            this.txtNames.TabIndex = 2;
            this.txtNames.Texts = "";
            this.txtNames.UnderlinedStyle = false;
            // 
            // txtSurnames
            // 
            this.txtSurnames.BackColor = System.Drawing.SystemColors.Window;
            this.txtSurnames.BorderColor = System.Drawing.Color.Silver;
            this.txtSurnames.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSurnames.BorderRadius = 0;
            this.txtSurnames.BorderSize = 2;
            this.txtSurnames.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSurnames.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSurnames.Location = new System.Drawing.Point(159, 92);
            this.txtSurnames.Margin = new System.Windows.Forms.Padding(4);
            this.txtSurnames.Multiline = false;
            this.txtSurnames.Name = "txtSurnames";
            this.txtSurnames.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSurnames.PasswordChar = false;
            this.txtSurnames.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSurnames.PlaceholderText = "Apellidos";
            this.txtSurnames.Size = new System.Drawing.Size(239, 31);
            this.txtSurnames.TabIndex = 3;
            this.txtSurnames.Texts = "";
            this.txtSurnames.UnderlinedStyle = false;
            // 
            // txtDirection
            // 
            this.txtDirection.BackColor = System.Drawing.SystemColors.Window;
            this.txtDirection.BorderColor = System.Drawing.Color.Silver;
            this.txtDirection.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDirection.BorderRadius = 0;
            this.txtDirection.BorderSize = 2;
            this.txtDirection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDirection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDirection.Location = new System.Drawing.Point(433, 48);
            this.txtDirection.Margin = new System.Windows.Forms.Padding(4);
            this.txtDirection.Multiline = true;
            this.txtDirection.Name = "txtDirection";
            this.txtDirection.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDirection.PasswordChar = false;
            this.txtDirection.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDirection.PlaceholderText = "Dirección";
            this.txtDirection.Size = new System.Drawing.Size(239, 52);
            this.txtDirection.TabIndex = 5;
            this.txtDirection.Texts = "";
            this.txtDirection.UnderlinedStyle = false;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.SystemColors.Window;
            this.txtPhone.BorderColor = System.Drawing.Color.Silver;
            this.txtPhone.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPhone.BorderRadius = 0;
            this.txtPhone.BorderSize = 2;
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPhone.Location = new System.Drawing.Point(27, 153);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Multiline = false;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPhone.PasswordChar = false;
            this.txtPhone.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPhone.PlaceholderText = "Telefono";
            this.txtPhone.Size = new System.Drawing.Size(239, 31);
            this.txtPhone.TabIndex = 4;
            this.txtPhone.Texts = "";
            this.txtPhone.UnderlinedStyle = false;
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.SystemColors.Window;
            this.txtDate.BorderColor = System.Drawing.Color.Silver;
            this.txtDate.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDate.BorderRadius = 0;
            this.txtDate.BorderSize = 2;
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDate.Location = new System.Drawing.Point(326, 205);
            this.txtDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtDate.Multiline = false;
            this.txtDate.Name = "txtDate";
            this.txtDate.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDate.PasswordChar = false;
            this.txtDate.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDate.PlaceholderText = "Dia/Mes/Año";
            this.txtDate.Size = new System.Drawing.Size(108, 31);
            this.txtDate.TabIndex = 8;
            this.txtDate.Texts = "";
            this.txtDate.UnderlinedStyle = false;
            // 
            // txtNationality
            // 
            this.txtNationality.BackColor = System.Drawing.SystemColors.Window;
            this.txtNationality.BorderColor = System.Drawing.Color.Silver;
            this.txtNationality.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNationality.BorderRadius = 0;
            this.txtNationality.BorderSize = 2;
            this.txtNationality.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNationality.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNationality.Location = new System.Drawing.Point(326, 153);
            this.txtNationality.Margin = new System.Windows.Forms.Padding(4);
            this.txtNationality.Multiline = false;
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNationality.PasswordChar = false;
            this.txtNationality.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNationality.PlaceholderText = "Nacionalidad";
            this.txtNationality.Size = new System.Drawing.Size(159, 31);
            this.txtNationality.TabIndex = 7;
            this.txtNationality.Texts = "";
            this.txtNationality.UnderlinedStyle = false;
            // 
            // txtDni
            // 
            this.txtDni.BackColor = System.Drawing.SystemColors.Window;
            this.txtDni.BorderColor = System.Drawing.Color.Silver;
            this.txtDni.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDni.BorderRadius = 0;
            this.txtDni.BorderSize = 2;
            this.txtDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDni.Location = new System.Drawing.Point(27, 205);
            this.txtDni.Margin = new System.Windows.Forms.Padding(4);
            this.txtDni.Multiline = false;
            this.txtDni.Name = "txtDni";
            this.txtDni.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDni.PasswordChar = false;
            this.txtDni.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDni.PlaceholderText = "Cédula";
            this.txtDni.Size = new System.Drawing.Size(239, 31);
            this.txtDni.TabIndex = 6;
            this.txtDni.Texts = "";
            this.txtDni.UnderlinedStyle = false;
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 4;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(27, 292);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowTemplate.Height = 25;
            this.guna2DataGridView1.Size = new System.Drawing.Size(684, 150);
            this.guna2DataGridView1.TabIndex = 9;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 25;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btAgg
            // 
            this.btAgg.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btAgg.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btAgg.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btAgg.BorderRadius = 0;
            this.btAgg.BorderSize = 0;
            this.btAgg.FlatAppearance.BorderSize = 0;
            this.btAgg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAgg.ForeColor = System.Drawing.Color.White;
            this.btAgg.Location = new System.Drawing.Point(522, 153);
            this.btAgg.Name = "btAgg";
            this.btAgg.Size = new System.Drawing.Size(150, 40);
            this.btAgg.TabIndex = 9;
            this.btAgg.Text = "Registrar";
            this.btAgg.TextColor = System.Drawing.Color.White;
            this.btAgg.UseVisualStyleBackColor = false;
            this.btAgg.Click += new System.EventHandler(this.btAgg_Click);
            // 
            // panelPrinc
            // 
            this.panelPrinc.Controls.Add(this.rjDatePicker1);
            this.panelPrinc.Controls.Add(this.btAgg);
            this.panelPrinc.Controls.Add(this.txtDate);
            this.panelPrinc.Controls.Add(this.txtNationality);
            this.panelPrinc.Controls.Add(this.pbxPhoto);
            this.panelPrinc.Controls.Add(this.txtNames);
            this.panelPrinc.Controls.Add(this.txtDni);
            this.panelPrinc.Controls.Add(this.txtDirection);
            this.panelPrinc.Controls.Add(this.txtSurnames);
            this.panelPrinc.Controls.Add(this.txtPhone);
            this.panelPrinc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrinc.Location = new System.Drawing.Point(0, 0);
            this.panelPrinc.Name = "panelPrinc";
            this.panelPrinc.Size = new System.Drawing.Size(798, 457);
            this.panelPrinc.TabIndex = 10;
            // 
            // timerMenu
            // 
            this.timerMenu.Tick += new System.EventHandler(this.timerMenu_Tick);
            // 
            // timerMenuClose
            // 
            this.timerMenuClose.Tick += new System.EventHandler(this.timerMenuClose_Tick);
            // 
            // rjDatePicker1
            // 
            this.rjDatePicker1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjDatePicker1.BorderSize = 0;
            this.rjDatePicker1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rjDatePicker1.Location = new System.Drawing.Point(511, 230);
            this.rjDatePicker1.MinimumSize = new System.Drawing.Size(0, 35);
            this.rjDatePicker1.Name = "rjDatePicker1";
            this.rjDatePicker1.Size = new System.Drawing.Size(200, 35);
            this.rjDatePicker1.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.rjDatePicker1.TabIndex = 10;
            this.rjDatePicker1.TextColor = System.Drawing.Color.White;
            // 
            // UsClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.panelPrinc);
            this.Name = "UsClients";
            this.Size = new System.Drawing.Size(798, 457);
            this.Load += new System.EventHandler(this.UsClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.panelPrinc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RJCodeAdvance.RJControls.RJCircularPictureBox pbxPhoto;
        private RJCodeAdvance.RJControls.RJTextBox txtNames;
        private RJCodeAdvance.RJControls.RJTextBox txtSurnames;
        private RJCodeAdvance.RJControls.RJTextBox txtDirection;
        private RJCodeAdvance.RJControls.RJTextBox txtPhone;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private RJCodeAdvance.RJControls.RJTextBox txtDate;
        private RJCodeAdvance.RJControls.RJTextBox txtNationality;
        private RJCodeAdvance.RJControls.RJTextBox txtDni;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private RJCodeAdvance.RJControls.RJButton btAgg;
        private System.Windows.Forms.Panel panelPrinc;
        private System.Windows.Forms.Timer timerMenu;
        private System.Windows.Forms.Timer timerMenuClose;
        private RJCodeAdvance.RJControls.RJDatePicker rjDatePicker1;
    }
}
