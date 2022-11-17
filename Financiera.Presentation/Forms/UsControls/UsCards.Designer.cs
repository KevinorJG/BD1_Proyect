namespace Financiera.Presentation.Forms.UsControls
{
    partial class UsCards
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
            this.PickerOpenDate = new RJCodeAdvance.RJControls.RJDatePicker();
            this.txtMounOpen = new RJCodeAdvance.RJControls.RJTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCounts = new System.Windows.Forms.Label();
            this.cbTypeCard = new RJCodeAdvance.RJControls.RJComboBox();
            this.cbTypeCoin = new RJCodeAdvance.RJControls.RJComboBox();
            this.txtDniClient = new RJCodeAdvance.RJControls.RJTextBox();
            this.dgvCards = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtSearch = new RJCodeAdvance.RJControls.RJTextBox();
            this.btSearchCard = new RJCodeAdvance.RJControls.RJButton();
            this.btDeleteCard = new RJCodeAdvance.RJControls.RJButton();
            this.btAddCard = new RJCodeAdvance.RJControls.RJButton();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtNCard = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbNameCard = new System.Windows.Forms.Label();
            this.txtNameCard = new System.Windows.Forms.TextBox();
            this.txtBaseD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBaseC = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCards)).BeginInit();
            this.SuspendLayout();
            // 
            // PickerOpenDate
            // 
            this.PickerOpenDate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.PickerOpenDate.BorderSize = 0;
            this.PickerOpenDate.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PickerOpenDate.Location = new System.Drawing.Point(42, 182);
            this.PickerOpenDate.MinimumSize = new System.Drawing.Size(4, 35);
            this.PickerOpenDate.Name = "PickerOpenDate";
            this.PickerOpenDate.Size = new System.Drawing.Size(251, 35);
            this.PickerOpenDate.SkinColor = System.Drawing.Color.Silver;
            this.PickerOpenDate.TabIndex = 19;
            this.PickerOpenDate.TextColor = System.Drawing.Color.White;
            // 
            // txtMounOpen
            // 
            this.txtMounOpen.BackColor = System.Drawing.SystemColors.Window;
            this.txtMounOpen.BorderColor = System.Drawing.Color.Silver;
            this.txtMounOpen.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMounOpen.BorderRadius = 0;
            this.txtMounOpen.BorderSize = 2;
            this.txtMounOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMounOpen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMounOpen.Location = new System.Drawing.Point(802, 27);
            this.txtMounOpen.Margin = new System.Windows.Forms.Padding(4);
            this.txtMounOpen.Multiline = false;
            this.txtMounOpen.Name = "txtMounOpen";
            this.txtMounOpen.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMounOpen.PasswordChar = false;
            this.txtMounOpen.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMounOpen.PlaceholderText = "Monto de apertura";
            this.txtMounOpen.Size = new System.Drawing.Size(141, 31);
            this.txtMounOpen.TabIndex = 13;
            this.txtMounOpen.Texts = "";
            this.txtMounOpen.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(596, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Tipo de tarjeta";
            // 
            // lbCounts
            // 
            this.lbCounts.AutoSize = true;
            this.lbCounts.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCounts.Location = new System.Drawing.Point(381, 1);
            this.lbCounts.Name = "lbCounts";
            this.lbCounts.Size = new System.Drawing.Size(64, 20);
            this.lbCounts.TabIndex = 24;
            this.lbCounts.Text = "Moneda";
            // 
            // cbTypeCard
            // 
            this.cbTypeCard.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbTypeCard.BorderColor = System.Drawing.Color.DarkGray;
            this.cbTypeCard.BorderSize = 1;
            this.cbTypeCard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbTypeCard.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbTypeCard.ForeColor = System.Drawing.Color.DimGray;
            this.cbTypeCard.IconColor = System.Drawing.Color.RoyalBlue;
            this.cbTypeCard.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbTypeCard.ListTextColor = System.Drawing.Color.DimGray;
            this.cbTypeCard.Location = new System.Drawing.Point(543, 27);
            this.cbTypeCard.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbTypeCard.Name = "cbTypeCard";
            this.cbTypeCard.Padding = new System.Windows.Forms.Padding(1);
            this.cbTypeCard.Size = new System.Drawing.Size(200, 30);
            this.cbTypeCard.TabIndex = 23;
            this.cbTypeCard.Texts = "";
            this.cbTypeCard.OnSelectedIndexChanged += new System.EventHandler(this.cbTypeCard_OnSelectedIndexChanged);
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
            this.cbTypeCoin.Location = new System.Drawing.Point(320, 27);
            this.cbTypeCoin.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbTypeCoin.Name = "cbTypeCoin";
            this.cbTypeCoin.Padding = new System.Windows.Forms.Padding(1);
            this.cbTypeCoin.Size = new System.Drawing.Size(200, 30);
            this.cbTypeCoin.TabIndex = 22;
            this.cbTypeCoin.Texts = "";
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
            this.txtDniClient.Location = new System.Drawing.Point(42, 26);
            this.txtDniClient.Margin = new System.Windows.Forms.Padding(4);
            this.txtDniClient.Multiline = false;
            this.txtDniClient.Name = "txtDniClient";
            this.txtDniClient.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDniClient.PasswordChar = false;
            this.txtDniClient.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDniClient.PlaceholderText = "Cédula del cliente";
            this.txtDniClient.Size = new System.Drawing.Size(239, 31);
            this.txtDniClient.TabIndex = 26;
            this.txtDniClient.Texts = "";
            this.txtDniClient.UnderlinedStyle = false;
            this.txtDniClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDniClient_KeyPress);
            // 
            // dgvCards
            // 
            this.dgvCards.AllowUserToAddRows = false;
            this.dgvCards.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvCards.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCards.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCards.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCards.ColumnHeadersHeight = 30;
            this.dgvCards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCards.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCards.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCards.Location = new System.Drawing.Point(42, 290);
            this.dgvCards.Name = "dgvCards";
            this.dgvCards.ReadOnly = true;
            this.dgvCards.RowHeadersVisible = false;
            this.dgvCards.RowTemplate.Height = 25;
            this.dgvCards.Size = new System.Drawing.Size(953, 150);
            this.dgvCards.TabIndex = 27;
            this.dgvCards.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCards.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCards.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCards.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCards.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCards.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvCards.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCards.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvCards.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCards.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvCards.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCards.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCards.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvCards.ThemeStyle.ReadOnly = true;
            this.dgvCards.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCards.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCards.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvCards.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCards.ThemeStyle.RowsStyle.Height = 25;
            this.dgvCards.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCards.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            this.txtSearch.Location = new System.Drawing.Point(42, 233);
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
            // btSearchCard
            // 
            this.btSearchCard.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btSearchCard.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btSearchCard.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btSearchCard.BorderRadius = 5;
            this.btSearchCard.BorderSize = 0;
            this.btSearchCard.FlatAppearance.BorderSize = 0;
            this.btSearchCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSearchCard.ForeColor = System.Drawing.Color.White;
            this.btSearchCard.Location = new System.Drawing.Point(464, 233);
            this.btSearchCard.Name = "btSearchCard";
            this.btSearchCard.Size = new System.Drawing.Size(110, 31);
            this.btSearchCard.TabIndex = 31;
            this.btSearchCard.Text = "Buscar";
            this.btSearchCard.TextColor = System.Drawing.Color.White;
            this.btSearchCard.UseVisualStyleBackColor = false;
            this.btSearchCard.Click += new System.EventHandler(this.btSearchCard_Click);
            // 
            // btDeleteCard
            // 
            this.btDeleteCard.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btDeleteCard.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btDeleteCard.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btDeleteCard.BorderRadius = 5;
            this.btDeleteCard.BorderSize = 0;
            this.btDeleteCard.FlatAppearance.BorderSize = 0;
            this.btDeleteCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDeleteCard.ForeColor = System.Drawing.Color.White;
            this.btDeleteCard.Location = new System.Drawing.Point(742, 233);
            this.btDeleteCard.Name = "btDeleteCard";
            this.btDeleteCard.Size = new System.Drawing.Size(110, 31);
            this.btDeleteCard.TabIndex = 29;
            this.btDeleteCard.Text = "Eliminar";
            this.btDeleteCard.TextColor = System.Drawing.Color.White;
            this.btDeleteCard.UseVisualStyleBackColor = false;
            // 
            // btAddCard
            // 
            this.btAddCard.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btAddCard.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btAddCard.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btAddCard.BorderRadius = 5;
            this.btAddCard.BorderSize = 0;
            this.btAddCard.FlatAppearance.BorderSize = 0;
            this.btAddCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddCard.ForeColor = System.Drawing.Color.White;
            this.btAddCard.Location = new System.Drawing.Point(600, 233);
            this.btAddCard.Name = "btAddCard";
            this.btAddCard.Size = new System.Drawing.Size(110, 31);
            this.btAddCard.TabIndex = 28;
            this.btAddCard.Text = "Registrar";
            this.btAddCard.TextColor = System.Drawing.Color.White;
            this.btAddCard.UseVisualStyleBackColor = false;
            this.btAddCard.Click += new System.EventHandler(this.btAddCard_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(42, 77);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(239, 89);
            this.txtDescription.TabIndex = 34;
            // 
            // txtNCard
            // 
            this.txtNCard.Location = new System.Drawing.Point(477, 135);
            this.txtNCard.Name = "txtNCard";
            this.txtNCard.ReadOnly = true;
            this.txtNCard.Size = new System.Drawing.Size(126, 23);
            this.txtNCard.TabIndex = 35;
            this.txtNCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(320, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Numero de tarjeta:";
            // 
            // lbNameCard
            // 
            this.lbNameCard.AutoSize = true;
            this.lbNameCard.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNameCard.Location = new System.Drawing.Point(320, 96);
            this.lbNameCard.Name = "lbNameCard";
            this.lbNameCard.Size = new System.Drawing.Size(151, 20);
            this.lbNameCard.TabIndex = 37;
            this.lbNameCard.Text = "Nombre de la tarjeta:";
            // 
            // txtNameCard
            // 
            this.txtNameCard.Enabled = false;
            this.txtNameCard.Location = new System.Drawing.Point(477, 97);
            this.txtNameCard.Name = "txtNameCard";
            this.txtNameCard.ReadOnly = true;
            this.txtNameCard.Size = new System.Drawing.Size(156, 23);
            this.txtNameCard.TabIndex = 38;
            this.txtNameCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBaseD
            // 
            this.txtBaseD.Enabled = false;
            this.txtBaseD.Location = new System.Drawing.Point(822, 93);
            this.txtBaseD.Name = "txtBaseD";
            this.txtBaseD.ReadOnly = true;
            this.txtBaseD.Size = new System.Drawing.Size(126, 23);
            this.txtBaseD.TabIndex = 42;
            this.txtBaseD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(660, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "Monto base Dólares:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(660, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "Monto base Córdobas:";
            // 
            // txtBaseC
            // 
            this.txtBaseC.Enabled = false;
            this.txtBaseC.Location = new System.Drawing.Point(822, 131);
            this.txtBaseC.Name = "txtBaseC";
            this.txtBaseC.ReadOnly = true;
            this.txtBaseC.Size = new System.Drawing.Size(126, 23);
            this.txtBaseC.TabIndex = 39;
            this.txtBaseC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UsCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtBaseD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBaseC);
            this.Controls.Add(this.txtNameCard);
            this.Controls.Add(this.lbNameCard);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNCard);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btSearchCard);
            this.Controls.Add(this.btDeleteCard);
            this.Controls.Add(this.btAddCard);
            this.Controls.Add(this.dgvCards);
            this.Controls.Add(this.txtDniClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCounts);
            this.Controls.Add(this.cbTypeCard);
            this.Controls.Add(this.cbTypeCoin);
            this.Controls.Add(this.PickerOpenDate);
            this.Controls.Add(this.txtMounOpen);
            this.Name = "UsCards";
            this.Size = new System.Drawing.Size(1036, 462);
            this.Load += new System.EventHandler(this.UsCards_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCards)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJCodeAdvance.RJControls.RJDatePicker PickerOpenDate;
        private RJCodeAdvance.RJControls.RJTextBox txtMounOpen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCounts;
        private RJCodeAdvance.RJControls.RJComboBox cbTypeCard;
        private RJCodeAdvance.RJControls.RJComboBox cbTypeCoin;
        private RJCodeAdvance.RJControls.RJTextBox txtDniClient;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCards;
        private RJCodeAdvance.RJControls.RJTextBox txtSearch;
        private RJCodeAdvance.RJControls.RJButton btSearchCard;
        private RJCodeAdvance.RJControls.RJButton btDeleteCard;
        private RJCodeAdvance.RJControls.RJButton btAddCard;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtNCard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbNameCard;
        private System.Windows.Forms.TextBox txtNameCard;
        private System.Windows.Forms.TextBox txtBaseD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBaseC;
    }
}
