namespace rentCar.views.car
{
    partial class CommonCRUDS
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CarBrandCB = new System.Windows.Forms.ComboBox();
            this.modelsDataView = new System.Windows.Forms.DataGridView();
            this.modelInput = new System.Windows.Forms.TextBox();
            this.addNewModel = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.fuelTypeDTV = new System.Windows.Forms.DataGridView();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.carTypeDTV = new System.Windows.Forms.DataGridView();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.brandsDataView = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.label8 = new System.Windows.Forms.Label();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelsDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelTypeDTV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carTypeDTV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandsDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.iconButton3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.iconButton2);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.CarBrandCB);
            this.panel1.Controls.Add(this.modelsDataView);
            this.panel1.Controls.Add(this.modelInput);
            this.panel1.Controls.Add(this.addNewModel);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.fuelTypeDTV);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.carTypeDTV);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.brandsDataView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(911, 604);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(624, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Nuevo modelo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(480, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Marca";
            // 
            // CarBrandCB
            // 
            this.CarBrandCB.DisplayMember = "assad";
            this.CarBrandCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CarBrandCB.FormattingEnabled = true;
            this.CarBrandCB.Location = new System.Drawing.Point(483, 263);
            this.CarBrandCB.Name = "CarBrandCB";
            this.CarBrandCB.Size = new System.Drawing.Size(138, 21);
            this.CarBrandCB.TabIndex = 42;
            // 
            // modelsDataView
            // 
            this.modelsDataView.AllowUserToAddRows = false;
            this.modelsDataView.AllowUserToDeleteRows = false;
            this.modelsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modelsDataView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.modelsDataView.Location = new System.Drawing.Point(482, 44);
            this.modelsDataView.MultiSelect = false;
            this.modelsDataView.Name = "modelsDataView";
            this.modelsDataView.ReadOnly = true;
            this.modelsDataView.Size = new System.Drawing.Size(417, 194);
            this.modelsDataView.TabIndex = 30;
            this.modelsDataView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.modelsDataView_CellMouseDoubleClick);
            // 
            // modelInput
            // 
            this.modelInput.Location = new System.Drawing.Point(627, 263);
            this.modelInput.Name = "modelInput";
            this.modelInput.Size = new System.Drawing.Size(164, 20);
            this.modelInput.TabIndex = 29;
            this.modelInput.TextChanged += new System.EventHandler(this.modelInput_TextChanged);
            // 
            // addNewModel
            // 
            this.addNewModel.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.addNewModel.IconChar = FontAwesome.Sharp.IconChar.None;
            this.addNewModel.IconColor = System.Drawing.Color.Black;
            this.addNewModel.IconSize = 16;
            this.addNewModel.Location = new System.Drawing.Point(797, 242);
            this.addNewModel.Name = "addNewModel";
            this.addNewModel.Rotation = 0D;
            this.addNewModel.Size = new System.Drawing.Size(102, 41);
            this.addNewModel.TabIndex = 28;
            this.addNewModel.Text = "Agregar ";
            this.addNewModel.UseVisualStyleBackColor = true;
            this.addNewModel.Click += new System.EventHandler(this.addNewModel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(479, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(348, 23);
            this.label4.TabIndex = 27;
            this.label4.Text = "Mantenimiento tipo de combustible";
            // 
            // fuelTypeDTV
            // 
            this.fuelTypeDTV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fuelTypeDTV.Location = new System.Drawing.Point(483, 354);
            this.fuelTypeDTV.Name = "fuelTypeDTV";
            this.fuelTypeDTV.Size = new System.Drawing.Size(416, 194);
            this.fuelTypeDTV.TabIndex = 26;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(611, 575);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(180, 20);
            this.textBox4.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(301, 23);
            this.label3.TabIndex = 20;
            this.label3.Text = "Mantenimiento tipos de carros";
            // 
            // carTypeDTV
            // 
            this.carTypeDTV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carTypeDTV.Location = new System.Drawing.Point(13, 354);
            this.carTypeDTV.Name = "carTypeDTV";
            this.carTypeDTV.Size = new System.Drawing.Size(387, 194);
            this.carTypeDTV.TabIndex = 19;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(113, 572);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(179, 20);
            this.textBox3.TabIndex = 17;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(479, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mantenimiento de modelos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mantenimiento de marcas";
            // 
            // brandsDataView
            // 
            this.brandsDataView.AllowUserToAddRows = false;
            this.brandsDataView.AllowUserToDeleteRows = false;
            this.brandsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.brandsDataView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.brandsDataView.Location = new System.Drawing.Point(13, 44);
            this.brandsDataView.MultiSelect = false;
            this.brandsDataView.Name = "brandsDataView";
            this.brandsDataView.ReadOnly = true;
            this.brandsDataView.Size = new System.Drawing.Size(387, 194);
            this.brandsDataView.TabIndex = 5;
            this.brandsDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(110, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Nueva marca";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(113, 265);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 20);
            this.textBox1.TabIndex = 46;
            // 
            // iconButton1
            // 
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconSize = 16;
            this.iconButton1.Location = new System.Drawing.Point(298, 244);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(102, 41);
            this.iconButton1.TabIndex = 48;
            this.iconButton1.Text = "Agregar ";
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            this.iconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconSize = 16;
            this.iconButton2.Location = new System.Drawing.Point(298, 554);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Rotation = 0D;
            this.iconButton2.Size = new System.Drawing.Size(102, 41);
            this.iconButton2.TabIndex = 49;
            this.iconButton2.Text = "Agregar ";
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(110, 557);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "Nueva tipo de carro";
            // 
            // iconButton3
            // 
            this.iconButton3.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconSize = 16;
            this.iconButton3.Location = new System.Drawing.Point(797, 554);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Rotation = 0D;
            this.iconButton3.Size = new System.Drawing.Size(102, 41);
            this.iconButton3.TabIndex = 51;
            this.iconButton3.Text = "Agregar ";
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(608, 554);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 13);
            this.label9.TabIndex = 52;
            this.label9.Text = "Nueva tipo de combustible";
            // 
            // CommonCRUDS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 604);
            this.Controls.Add(this.panel1);
            this.Name = "CommonCRUDS";
            this.Text = "Mantenimientos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelsDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelTypeDTV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carTypeDTV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandsDataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView brandsDataView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView fuelTypeDTV;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView carTypeDTV;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView modelsDataView;
        private System.Windows.Forms.TextBox modelInput;
        private FontAwesome.Sharp.IconButton addNewModel;
        private System.Windows.Forms.ComboBox CarBrandCB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private FontAwesome.Sharp.IconButton iconButton3;
    }
}