namespace rentCar.views
{
    partial class RentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.rentsDV = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.rentComment = new System.Windows.Forms.TextBox();
            this.totalTX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CustomerTX = new System.Windows.Forms.TextBox();
            this.fechaDeRenta = new System.Windows.Forms.DateTimePicker();
            this.CarTX = new System.Windows.Forms.TextBox();
            this.fechaDevolucion = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CatOfDays = new System.Windows.Forms.NumericUpDown();
            this.SaveRentBtn = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.costPerDay = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchRentsTX = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentsDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CatOfDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costPerDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rentsDV);
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 537);
            this.panel1.TabIndex = 27;
            // 
            // rentsDV
            // 
            this.rentsDV.AllowUserToAddRows = false;
            this.rentsDV.AllowUserToDeleteRows = false;
            this.rentsDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentsDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rentsDV.Location = new System.Drawing.Point(0, 189);
            this.rentsDV.Name = "rentsDV";
            this.rentsDV.ReadOnly = true;
            this.rentsDV.Size = new System.Drawing.Size(980, 348);
            this.rentsDV.TabIndex = 51;
            this.rentsDV.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.rentsDV_CellMouseDoubleClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.rentComment);
            this.splitContainer1.Panel1.Controls.Add(this.totalTX);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.textBox2);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.CustomerTX);
            this.splitContainer1.Panel1.Controls.Add(this.fechaDeRenta);
            this.splitContainer1.Panel1.Controls.Add(this.CarTX);
            this.splitContainer1.Panel1.Controls.Add(this.fechaDevolucion);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.CatOfDays);
            this.splitContainer1.Panel1.Controls.Add(this.SaveRentBtn);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.costPerDay);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel2.Controls.Add(this.searchRentsTX);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Size = new System.Drawing.Size(980, 189);
            this.splitContainer1.SplitterDistance = 777;
            this.splitContainer1.TabIndex = 50;
            // 
            // rentComment
            // 
            this.rentComment.Location = new System.Drawing.Point(12, 116);
            this.rentComment.Multiline = true;
            this.rentComment.Name = "rentComment";
            this.rentComment.Size = new System.Drawing.Size(545, 63);
            this.rentComment.TabIndex = 44;
            // 
            // totalTX
            // 
            this.totalTX.Location = new System.Drawing.Point(669, 21);
            this.totalTX.Name = "totalTX";
            this.totalTX.ReadOnly = true;
            this.totalTX.Size = new System.Drawing.Size(100, 20);
            this.totalTX.TabIndex = 49;
            this.totalTX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Vehiculo bajo inspeccion";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(669, 69);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 48;
            this.textBox2.Text = "18%";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Cliente que desea rentar";
            // 
            // CustomerTX
            // 
            this.CustomerTX.Location = new System.Drawing.Point(16, 68);
            this.CustomerTX.Name = "CustomerTX";
            this.CustomerTX.ReadOnly = true;
            this.CustomerTX.Size = new System.Drawing.Size(335, 20);
            this.CustomerTX.TabIndex = 47;
            // 
            // fechaDeRenta
            // 
            this.fechaDeRenta.Location = new System.Drawing.Point(357, 22);
            this.fechaDeRenta.MinDate = new System.DateTime(2020, 6, 23, 0, 0, 0, 0);
            this.fechaDeRenta.Name = "fechaDeRenta";
            this.fechaDeRenta.Size = new System.Drawing.Size(200, 20);
            this.fechaDeRenta.TabIndex = 31;
            this.fechaDeRenta.Value = new System.DateTime(2020, 6, 24, 23, 59, 59, 0);
            // 
            // CarTX
            // 
            this.CarTX.Location = new System.Drawing.Point(16, 21);
            this.CarTX.Name = "CarTX";
            this.CarTX.ReadOnly = true;
            this.CarTX.Size = new System.Drawing.Size(335, 20);
            this.CarTX.TabIndex = 46;
            // 
            // fechaDevolucion
            // 
            this.fechaDevolucion.Location = new System.Drawing.Point(357, 70);
            this.fechaDevolucion.MinDate = new System.DateTime(2020, 6, 24, 0, 0, 0, 0);
            this.fechaDevolucion.Name = "fechaDevolucion";
            this.fechaDevolucion.Size = new System.Drawing.Size(200, 20);
            this.fechaDevolucion.TabIndex = 32;
            this.fechaDevolucion.Value = new System.DateTime(2020, 6, 24, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "Comentario de renta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(560, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Cantidad de dias";
            // 
            // CatOfDays
            // 
            this.CatOfDays.Location = new System.Drawing.Point(563, 22);
            this.CatOfDays.Name = "CatOfDays";
            this.CatOfDays.Size = new System.Drawing.Size(100, 20);
            this.CatOfDays.TabIndex = 34;
            this.CatOfDays.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SaveRentBtn
            // 
            this.SaveRentBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.SaveRentBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SaveRentBtn.IconColor = System.Drawing.Color.Black;
            this.SaveRentBtn.IconSize = 16;
            this.SaveRentBtn.Location = new System.Drawing.Point(563, 116);
            this.SaveRentBtn.Name = "SaveRentBtn";
            this.SaveRentBtn.Rotation = 0D;
            this.SaveRentBtn.Size = new System.Drawing.Size(206, 63);
            this.SaveRentBtn.TabIndex = 43;
            this.SaveRentBtn.Text = "Procesar renta";
            this.SaveRentBtn.UseVisualStyleBackColor = true;
            this.SaveRentBtn.Click += new System.EventHandler(this.SaveRentBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(354, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Fecha de reserva o Renta";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(666, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "ITEBIS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(354, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Fecha para devolucion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(667, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Total a pagar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(560, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Costo x dia";
            // 
            // costPerDay
            // 
            this.costPerDay.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.costPerDay.Location = new System.Drawing.Point(563, 69);
            this.costPerDay.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.costPerDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.costPerDay.Name = "costPerDay";
            this.costPerDay.Size = new System.Drawing.Size(100, 20);
            this.costPerDay.TabIndex = 38;
            this.costPerDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.costPerDay.ValueChanged += new System.EventHandler(this.costPerDay_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // searchRentsTX
            // 
            this.searchRentsTX.Location = new System.Drawing.Point(7, 159);
            this.searchRentsTX.Name = "searchRentsTX";
            this.searchRentsTX.Size = new System.Drawing.Size(180, 20);
            this.searchRentsTX.TabIndex = 1;
            this.searchRentsTX.TextChanged += new System.EventHandler(this.searchRentsTX_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(192, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Rentas por.: clientes, vehiculo o fecha.";
            // 
            // RentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 537);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proceso de renta";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rentsDV)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CatOfDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costPerDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton SaveRentBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown costPerDay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown CatOfDays;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker fechaDevolucion;
        private System.Windows.Forms.DateTimePicker fechaDeRenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox rentComment;
        private System.Windows.Forms.TextBox CustomerTX;
        private System.Windows.Forms.TextBox CarTX;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox totalTX;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox searchRentsTX;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView rentsDV;
    }
}