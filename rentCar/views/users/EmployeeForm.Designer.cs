namespace rentCar.user
{
    partial class EmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.comissions = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.workPositionCB = new System.Windows.Forms.ComboBox();
            this.workSessionCB = new System.Windows.Forms.ComboBox();
            this.employeStateCheck = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dominicanIDTX = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.employeeDV = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.employeeLastNameTX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.createUserBtn = new FontAwesome.Sharp.IconButton();
            this.appLogo = new System.Windows.Forms.PictureBox();
            this.employeeNameTX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.empoyeeCardTX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comissions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.panel1.Controls.Add(this.comissions);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.workPositionCB);
            this.panel1.Controls.Add(this.workSessionCB);
            this.panel1.Controls.Add(this.employeStateCheck);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dominicanIDTX);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.employeeDV);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.employeeLastNameTX);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.createUserBtn);
            this.panel1.Controls.Add(this.appLogo);
            this.panel1.Controls.Add(this.employeeNameTX);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.empoyeeCardTX);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 459);
            this.panel1.TabIndex = 3;
            // 
            // comissions
            // 
            this.comissions.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.comissions.Location = new System.Drawing.Point(632, 36);
            this.comissions.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.comissions.Name = "comissions";
            this.comissions.Size = new System.Drawing.Size(204, 22);
            this.comissions.TabIndex = 98;
            this.comissions.ThousandsSeparator = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(401, 17);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 14);
            this.label7.TabIndex = 22;
            this.label7.Text = "Tanda";
            // 
            // workPositionCB
            // 
            this.workPositionCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workPositionCB.FormattingEnabled = true;
            this.workPositionCB.Items.AddRange(new object[] {
            "Rentador",
            "Insperctor",
            "Administrador"});
            this.workPositionCB.Location = new System.Drawing.Point(404, 123);
            this.workPositionCB.Name = "workPositionCB";
            this.workPositionCB.Size = new System.Drawing.Size(210, 22);
            this.workPositionCB.TabIndex = 21;
            // 
            // workSessionCB
            // 
            this.workSessionCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workSessionCB.FormattingEnabled = true;
            this.workSessionCB.Items.AddRange(new object[] {
            "Matutina",
            "Vespertina",
            "Diurna",
            "Nocturna"});
            this.workSessionCB.Location = new System.Drawing.Point(404, 34);
            this.workSessionCB.Name = "workSessionCB";
            this.workSessionCB.Size = new System.Drawing.Size(210, 22);
            this.workSessionCB.TabIndex = 20;
            // 
            // employeStateCheck
            // 
            this.employeStateCheck.AutoSize = true;
            this.employeStateCheck.ForeColor = System.Drawing.Color.White;
            this.employeStateCheck.Location = new System.Drawing.Point(632, 78);
            this.employeStateCheck.Name = "employeStateCheck";
            this.employeStateCheck.Size = new System.Drawing.Size(129, 18);
            this.employeStateCheck.TabIndex = 19;
            this.employeStateCheck.Text = "Empleado activo";
            this.employeStateCheck.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(401, 105);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 14);
            this.label8.TabIndex = 17;
            this.label8.Text = "Area";
            // 
            // dominicanIDTX
            // 
            this.dominicanIDTX.Location = new System.Drawing.Point(404, 79);
            this.dominicanIDTX.Margin = new System.Windows.Forms.Padding(4);
            this.dominicanIDTX.MaxLength = 11;
            this.dominicanIDTX.Name = "dominicanIDTX";
            this.dominicanIDTX.Size = new System.Drawing.Size(210, 22);
            this.dominicanIDTX.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(401, 61);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 14);
            this.label6.TabIndex = 15;
            this.label6.Text = "Cedula";
            // 
            // employeeDV
            // 
            this.employeeDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDV.Location = new System.Drawing.Point(15, 166);
            this.employeeDV.Name = "employeeDV";
            this.employeeDV.Size = new System.Drawing.Size(827, 280);
            this.employeeDV.TabIndex = 13;
            this.employeeDV.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.employeeDV_CellMouseDoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(401, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 14);
            this.label5.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(629, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 14);
            this.label4.TabIndex = 10;
            this.label4.Text = "Comision por rentas";
            // 
            // employeeLastNameTX
            // 
            this.employeeLastNameTX.Location = new System.Drawing.Point(173, 123);
            this.employeeLastNameTX.Margin = new System.Windows.Forms.Padding(4);
            this.employeeLastNameTX.MaxLength = 40;
            this.employeeLastNameTX.Name = "employeeLastNameTX";
            this.employeeLastNameTX.Size = new System.Drawing.Size(210, 22);
            this.employeeLastNameTX.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(170, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 14);
            this.label3.TabIndex = 8;
            this.label3.Text = "Apellido(s)";
            // 
            // createUserBtn
            // 
            this.createUserBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(0)))), ((int)(((byte)(26)))));
            this.createUserBtn.FlatAppearance.BorderSize = 0;
            this.createUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createUserBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.createUserBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createUserBtn.ForeColor = System.Drawing.Color.White;
            this.createUserBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.createUserBtn.IconColor = System.Drawing.Color.Black;
            this.createUserBtn.IconSize = 16;
            this.createUserBtn.Location = new System.Drawing.Point(632, 103);
            this.createUserBtn.Margin = new System.Windows.Forms.Padding(4);
            this.createUserBtn.Name = "createUserBtn";
            this.createUserBtn.Rotation = 0D;
            this.createUserBtn.Size = new System.Drawing.Size(204, 42);
            this.createUserBtn.TabIndex = 5;
            this.createUserBtn.Text = "Crear emplado";
            this.createUserBtn.UseVisualStyleBackColor = false;
            this.createUserBtn.Click += new System.EventHandler(this.createUserBtn_Click);
            // 
            // appLogo
            // 
            this.appLogo.Image = ((System.Drawing.Image)(resources.GetObject("appLogo.Image")));
            this.appLogo.Location = new System.Drawing.Point(13, 17);
            this.appLogo.Margin = new System.Windows.Forms.Padding(4);
            this.appLogo.Name = "appLogo";
            this.appLogo.Size = new System.Drawing.Size(149, 128);
            this.appLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.appLogo.TabIndex = 4;
            this.appLogo.TabStop = false;
            // 
            // employeeNameTX
            // 
            this.employeeNameTX.Location = new System.Drawing.Point(173, 79);
            this.employeeNameTX.Margin = new System.Windows.Forms.Padding(4);
            this.employeeNameTX.MaxLength = 30;
            this.employeeNameTX.Name = "employeeNameTX";
            this.employeeNameTX.Size = new System.Drawing.Size(210, 22);
            this.employeeNameTX.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(170, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre(s)";
            // 
            // empoyeeCardTX
            // 
            this.empoyeeCardTX.Location = new System.Drawing.Point(173, 35);
            this.empoyeeCardTX.Margin = new System.Windows.Forms.Padding(4);
            this.empoyeeCardTX.MaxLength = 20;
            this.empoyeeCardTX.Name = "empoyeeCardTX";
            this.empoyeeCardTX.Size = new System.Drawing.Size(210, 22);
            this.empoyeeCardTX.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(170, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tarjeta de empleado";
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(0)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(892, 485);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeeForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comissions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton createUserBtn;
        private System.Windows.Forms.PictureBox appLogo;
        private System.Windows.Forms.TextBox employeeNameTX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox empoyeeCardTX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox employeeLastNameTX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView employeeDV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox dominicanIDTX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox employeStateCheck;
        private System.Windows.Forms.ComboBox workSessionCB;
        private System.Windows.Forms.ComboBox workPositionCB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown comissions;
    }
}