namespace rentCar.views.customers
{
    partial class CustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchBarTX = new System.Windows.Forms.TextBox();
            this.creditLimitTN = new System.Windows.Forms.NumericUpDown();
            this.CustomerTypeCB = new System.Windows.Forms.ComboBox();
            this.CustomerStatusCheck = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CustomerCedulaTX = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CustomerDV = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.CreditCardTX = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.CustomerLastNameTX = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.validateCustomerBtn = new FontAwesome.Sharp.IconButton();
            this.appLogo = new System.Windows.Forms.PictureBox();
            this.CustomerNameTX = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.RNCTX = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.creditLimitTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(966, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.SearchBarTX);
            this.panel2.Controls.Add(this.creditLimitTN);
            this.panel2.Controls.Add(this.CustomerTypeCB);
            this.panel2.Controls.Add(this.CustomerStatusCheck);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.CustomerCedulaTX);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.CustomerDV);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.CreditCardTX);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.CustomerLastNameTX);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.validateCustomerBtn);
            this.panel2.Controls.Add(this.appLogo);
            this.panel2.Controls.Add(this.CustomerNameTX);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.RNCTX);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(966, 450);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(621, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 14);
            this.label1.TabIndex = 99;
            this.label1.Text = "Busca por cedula o RNC";
            // 
            // SearchBarTX
            // 
            this.SearchBarTX.Location = new System.Drawing.Point(778, 117);
            this.SearchBarTX.Margin = new System.Windows.Forms.Padding(4);
            this.SearchBarTX.MaxLength = 30;
            this.SearchBarTX.Name = "SearchBarTX";
            this.SearchBarTX.Size = new System.Drawing.Size(175, 20);
            this.SearchBarTX.TabIndex = 98;
            this.SearchBarTX.TextChanged += new System.EventHandler(this.SearchBarTX_TextChanged);
            // 
            // creditLimitTN
            // 
            this.creditLimitTN.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.creditLimitTN.Location = new System.Drawing.Point(624, 30);
            this.creditLimitTN.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.creditLimitTN.Name = "creditLimitTN";
            this.creditLimitTN.Size = new System.Drawing.Size(192, 20);
            this.creditLimitTN.TabIndex = 97;
            this.creditLimitTN.ThousandsSeparator = true;
            // 
            // CustomerTypeCB
            // 
            this.CustomerTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CustomerTypeCB.FormattingEnabled = true;
            this.CustomerTypeCB.Items.AddRange(new object[] {
            "Fisica",
            "Juridica"});
            this.CustomerTypeCB.Location = new System.Drawing.Point(404, 117);
            this.CustomerTypeCB.Name = "CustomerTypeCB";
            this.CustomerTypeCB.Size = new System.Drawing.Size(210, 21);
            this.CustomerTypeCB.TabIndex = 21;
            // 
            // CustomerStatusCheck
            // 
            this.CustomerStatusCheck.AutoSize = true;
            this.CustomerStatusCheck.ForeColor = System.Drawing.Color.White;
            this.CustomerStatusCheck.Location = new System.Drawing.Point(863, 29);
            this.CustomerStatusCheck.Name = "CustomerStatusCheck";
            this.CustomerStatusCheck.Size = new System.Drawing.Size(90, 17);
            this.CustomerStatusCheck.TabIndex = 19;
            this.CustomerStatusCheck.Text = "Cliente activo";
            this.CustomerStatusCheck.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(401, 99);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 14);
            this.label9.TabIndex = 17;
            this.label9.Text = "Tipo de persona";
            // 
            // CustomerCedulaTX
            // 
            this.CustomerCedulaTX.Location = new System.Drawing.Point(404, 73);
            this.CustomerCedulaTX.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerCedulaTX.MaxLength = 11;
            this.CustomerCedulaTX.Name = "CustomerCedulaTX";
            this.CustomerCedulaTX.Size = new System.Drawing.Size(210, 20);
            this.CustomerCedulaTX.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(401, 55);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 14);
            this.label10.TabIndex = 15;
            this.label10.Text = "Cedula";
            // 
            // CustomerDV
            // 
            this.CustomerDV.AllowUserToAddRows = false;
            this.CustomerDV.AllowUserToDeleteRows = false;
            this.CustomerDV.AllowUserToOrderColumns = true;
            this.CustomerDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerDV.Location = new System.Drawing.Point(12, 160);
            this.CustomerDV.Name = "CustomerDV";
            this.CustomerDV.ReadOnly = true;
            this.CustomerDV.Size = new System.Drawing.Size(941, 260);
            this.CustomerDV.TabIndex = 13;
            this.CustomerDV.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CustomerDV_CellMouseDoubleClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(401, 11);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 14);
            this.label11.TabIndex = 12;
            this.label11.Text = "Tarjeta de credito";
            // 
            // CreditCardTX
            // 
            this.CreditCardTX.Location = new System.Drawing.Point(404, 29);
            this.CreditCardTX.Margin = new System.Windows.Forms.Padding(4);
            this.CreditCardTX.MaxLength = 20;
            this.CreditCardTX.Name = "CreditCardTX";
            this.CreditCardTX.Size = new System.Drawing.Size(210, 20);
            this.CreditCardTX.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(621, 11);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 14);
            this.label12.TabIndex = 10;
            this.label12.Text = "Limite de credito";
            // 
            // CustomerLastNameTX
            // 
            this.CustomerLastNameTX.Location = new System.Drawing.Point(173, 117);
            this.CustomerLastNameTX.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerLastNameTX.MaxLength = 30;
            this.CustomerLastNameTX.Name = "CustomerLastNameTX";
            this.CustomerLastNameTX.Size = new System.Drawing.Size(210, 20);
            this.CustomerLastNameTX.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(170, 99);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 14);
            this.label13.TabIndex = 8;
            this.label13.Text = "Apellido(s)";
            // 
            // validateCustomerBtn
            // 
            this.validateCustomerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(0)))), ((int)(((byte)(26)))));
            this.validateCustomerBtn.FlatAppearance.BorderSize = 0;
            this.validateCustomerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.validateCustomerBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.validateCustomerBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validateCustomerBtn.ForeColor = System.Drawing.Color.White;
            this.validateCustomerBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.validateCustomerBtn.IconColor = System.Drawing.Color.Black;
            this.validateCustomerBtn.IconSize = 16;
            this.validateCustomerBtn.Location = new System.Drawing.Point(624, 61);
            this.validateCustomerBtn.Margin = new System.Windows.Forms.Padding(4);
            this.validateCustomerBtn.Name = "validateCustomerBtn";
            this.validateCustomerBtn.Rotation = 0D;
            this.validateCustomerBtn.Size = new System.Drawing.Size(329, 42);
            this.validateCustomerBtn.TabIndex = 5;
            this.validateCustomerBtn.Text = "Crear cliente";
            this.validateCustomerBtn.UseVisualStyleBackColor = false;
            this.validateCustomerBtn.Click += new System.EventHandler(this.validateCustomerBtn_Click);
            // 
            // appLogo
            // 
            this.appLogo.Image = ((System.Drawing.Image)(resources.GetObject("appLogo.Image")));
            this.appLogo.Location = new System.Drawing.Point(13, 11);
            this.appLogo.Margin = new System.Windows.Forms.Padding(4);
            this.appLogo.Name = "appLogo";
            this.appLogo.Size = new System.Drawing.Size(149, 128);
            this.appLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.appLogo.TabIndex = 4;
            this.appLogo.TabStop = false;
            // 
            // CustomerNameTX
            // 
            this.CustomerNameTX.Location = new System.Drawing.Point(173, 73);
            this.CustomerNameTX.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerNameTX.MaxLength = 30;
            this.CustomerNameTX.Name = "CustomerNameTX";
            this.CustomerNameTX.Size = new System.Drawing.Size(210, 20);
            this.CustomerNameTX.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(170, 55);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 14);
            this.label14.TabIndex = 3;
            this.label14.Text = "Nombre(s)";
            // 
            // RNCTX
            // 
            this.RNCTX.Location = new System.Drawing.Point(173, 29);
            this.RNCTX.Margin = new System.Windows.Forms.Padding(4);
            this.RNCTX.MaxLength = 20;
            this.RNCTX.Name = "RNCTX";
            this.RNCTX.Size = new System.Drawing.Size(210, 20);
            this.RNCTX.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(170, 11);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 14);
            this.label15.TabIndex = 1;
            this.label15.Text = "RNC";
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.creditLimitTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox CustomerTypeCB;
        private System.Windows.Forms.CheckBox CustomerStatusCheck;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox CustomerCedulaTX;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView CustomerDV;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox CreditCardTX;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox CustomerLastNameTX;
        private System.Windows.Forms.Label label13;
        private FontAwesome.Sharp.IconButton validateCustomerBtn;
        private System.Windows.Forms.PictureBox appLogo;
        private System.Windows.Forms.TextBox CustomerNameTX;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox RNCTX;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown creditLimitTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchBarTX;
    }
}