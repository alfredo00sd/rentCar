namespace rentCar.views
{
    partial class InspectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InspectionForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.inspectionCommentTX = new System.Windows.Forms.TextBox();
            this.formTile = new System.Windows.Forms.Label();
            this.SaveInspectionBtn = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CustomerCB = new System.Windows.Forms.ComboBox();
            this.inspector = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hasScratchesChek = new System.Windows.Forms.CheckBox();
            this.CarCB = new System.Windows.Forms.ComboBox();
            this.hasBotiquinChek = new System.Windows.Forms.CheckBox();
            this.hasRefactionChek = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.QuantityOfFuelCB = new System.Windows.Forms.ComboBox();
            this.checkLlanta1 = new System.Windows.Forms.CheckBox();
            this.checkLlanta2 = new System.Windows.Forms.CheckBox();
            this.checkLlanta4 = new System.Windows.Forms.CheckBox();
            this.checkLlanta3 = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.heplBtn = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.inspectionsDV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionsDV)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Maroon;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(1262, 558);
            this.splitContainer1.SplitterDistance = 569;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.inspectionCommentTX);
            this.panel1.Controls.Add(this.formTile);
            this.panel1.Controls.Add(this.SaveInspectionBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.CustomerCB);
            this.panel1.Controls.Add(this.inspector);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.hasScratchesChek);
            this.panel1.Controls.Add(this.CarCB);
            this.panel1.Controls.Add(this.hasBotiquinChek);
            this.panel1.Controls.Add(this.hasRefactionChek);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.QuantityOfFuelCB);
            this.panel1.Controls.Add(this.checkLlanta1);
            this.panel1.Controls.Add(this.checkLlanta2);
            this.panel1.Controls.Add(this.checkLlanta4);
            this.panel1.Controls.Add(this.checkLlanta3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 558);
            this.panel1.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(351, 465);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Comentario de inspeccion";
            // 
            // inspectionCommentTX
            // 
            this.inspectionCommentTX.Location = new System.Drawing.Point(351, 481);
            this.inspectionCommentTX.Multiline = true;
            this.inspectionCommentTX.Name = "inspectionCommentTX";
            this.inspectionCommentTX.Size = new System.Drawing.Size(215, 68);
            this.inspectionCommentTX.TabIndex = 18;
            // 
            // formTile
            // 
            this.formTile.AutoSize = true;
            this.formTile.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formTile.ForeColor = System.Drawing.Color.White;
            this.formTile.Location = new System.Drawing.Point(12, 9);
            this.formTile.Name = "formTile";
            this.formTile.Size = new System.Drawing.Size(252, 23);
            this.formTile.TabIndex = 17;
            this.formTile.Text = "Formulario de inspeccion";
            // 
            // SaveInspectionBtn
            // 
            this.SaveInspectionBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(95)))));
            this.SaveInspectionBtn.FlatAppearance.BorderSize = 0;
            this.SaveInspectionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveInspectionBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.SaveInspectionBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveInspectionBtn.ForeColor = System.Drawing.Color.White;
            this.SaveInspectionBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SaveInspectionBtn.IconColor = System.Drawing.Color.Black;
            this.SaveInspectionBtn.IconSize = 16;
            this.SaveInspectionBtn.Location = new System.Drawing.Point(437, 12);
            this.SaveInspectionBtn.Name = "SaveInspectionBtn";
            this.SaveInspectionBtn.Rotation = 0D;
            this.SaveInspectionBtn.Size = new System.Drawing.Size(129, 57);
            this.SaveInspectionBtn.TabIndex = 16;
            this.SaveInspectionBtn.Text = "Guardar inspeccion";
            this.SaveInspectionBtn.UseVisualStyleBackColor = false;
            this.SaveInspectionBtn.Click += new System.EventHandler(this.SaveInspectionBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(2, 466);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cliente que desea rentar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(2, 513);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Empleado que asiste";
            // 
            // CustomerCB
            // 
            this.CustomerCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CustomerCB.FormattingEnabled = true;
            this.CustomerCB.Location = new System.Drawing.Point(5, 481);
            this.CustomerCB.Name = "CustomerCB";
            this.CustomerCB.Size = new System.Drawing.Size(337, 21);
            this.CustomerCB.TabIndex = 7;
            // 
            // inspector
            // 
            this.inspector.Location = new System.Drawing.Point(5, 529);
            this.inspector.Name = "inspector";
            this.inspector.ReadOnly = true;
            this.inspector.Size = new System.Drawing.Size(337, 20);
            this.inspector.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 419);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Vehiculo bajo inspeccion";
            // 
            // hasScratchesChek
            // 
            this.hasScratchesChek.AutoSize = true;
            this.hasScratchesChek.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hasScratchesChek.ForeColor = System.Drawing.Color.White;
            this.hasScratchesChek.Location = new System.Drawing.Point(281, 390);
            this.hasScratchesChek.Name = "hasScratchesChek";
            this.hasScratchesChek.Size = new System.Drawing.Size(288, 17);
            this.hasScratchesChek.TabIndex = 13;
            this.hasScratchesChek.Text = "Tiene alguna ralladura de cristal u otra parte?";
            this.hasScratchesChek.UseVisualStyleBackColor = true;
            // 
            // CarCB
            // 
            this.CarCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CarCB.FormattingEnabled = true;
            this.CarCB.Location = new System.Drawing.Point(5, 434);
            this.CarCB.Name = "CarCB";
            this.CarCB.Size = new System.Drawing.Size(337, 21);
            this.CarCB.TabIndex = 5;
            // 
            // hasBotiquinChek
            // 
            this.hasBotiquinChek.AutoSize = true;
            this.hasBotiquinChek.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hasBotiquinChek.ForeColor = System.Drawing.Color.White;
            this.hasBotiquinChek.Location = new System.Drawing.Point(130, 390);
            this.hasBotiquinChek.Name = "hasBotiquinChek";
            this.hasBotiquinChek.Size = new System.Drawing.Size(152, 17);
            this.hasBotiquinChek.TabIndex = 12;
            this.hasBotiquinChek.Text = "Tiene gato y botiquin?";
            this.hasBotiquinChek.UseVisualStyleBackColor = true;
            // 
            // hasRefactionChek
            // 
            this.hasRefactionChek.AutoSize = true;
            this.hasRefactionChek.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hasRefactionChek.ForeColor = System.Drawing.Color.White;
            this.hasRefactionChek.Location = new System.Drawing.Point(5, 391);
            this.hasRefactionChek.Name = "hasRefactionChek";
            this.hasRefactionChek.Size = new System.Drawing.Size(119, 17);
            this.hasRefactionChek.TabIndex = 11;
            this.hasRefactionChek.Text = "Tiene refaccion?";
            this.hasRefactionChek.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(351, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cantidad de combustible";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(189, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // QuantityOfFuelCB
            // 
            this.QuantityOfFuelCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.QuantityOfFuelCB.FormattingEnabled = true;
            this.QuantityOfFuelCB.Items.AddRange(new object[] {
            "Tanque lleno",
            "Tanque medio",
            "Tanque en reserva",
            "llega a la bomba",
            "Tanque vacio"});
            this.QuantityOfFuelCB.Location = new System.Drawing.Point(354, 434);
            this.QuantityOfFuelCB.Name = "QuantityOfFuelCB";
            this.QuantityOfFuelCB.Size = new System.Drawing.Size(212, 21);
            this.QuantityOfFuelCB.TabIndex = 9;
            // 
            // checkLlanta1
            // 
            this.checkLlanta1.AutoSize = true;
            this.checkLlanta1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkLlanta1.ForeColor = System.Drawing.Color.White;
            this.checkLlanta1.Location = new System.Drawing.Point(10, 137);
            this.checkLlanta1.Name = "checkLlanta1";
            this.checkLlanta1.Size = new System.Drawing.Size(174, 17);
            this.checkLlanta1.TabIndex = 4;
            this.checkLlanta1.Text = "Llanta delantera izquierda";
            this.checkLlanta1.UseVisualStyleBackColor = true;
            // 
            // checkLlanta2
            // 
            this.checkLlanta2.AutoSize = true;
            this.checkLlanta2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkLlanta2.ForeColor = System.Drawing.Color.White;
            this.checkLlanta2.Location = new System.Drawing.Point(374, 139);
            this.checkLlanta2.Name = "checkLlanta2";
            this.checkLlanta2.Size = new System.Drawing.Size(168, 17);
            this.checkLlanta2.TabIndex = 1;
            this.checkLlanta2.Text = "Llanta delantera derecha";
            this.checkLlanta2.UseVisualStyleBackColor = true;
            // 
            // checkLlanta4
            // 
            this.checkLlanta4.AutoSize = true;
            this.checkLlanta4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkLlanta4.ForeColor = System.Drawing.Color.White;
            this.checkLlanta4.Location = new System.Drawing.Point(22, 301);
            this.checkLlanta4.Name = "checkLlanta4";
            this.checkLlanta4.Size = new System.Drawing.Size(161, 17);
            this.checkLlanta4.TabIndex = 3;
            this.checkLlanta4.Text = "Llanta trasera izquierda";
            this.checkLlanta4.UseVisualStyleBackColor = true;
            // 
            // checkLlanta3
            // 
            this.checkLlanta3.AutoSize = true;
            this.checkLlanta3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkLlanta3.ForeColor = System.Drawing.Color.White;
            this.checkLlanta3.Location = new System.Drawing.Point(374, 301);
            this.checkLlanta3.Name = "checkLlanta3";
            this.checkLlanta3.Size = new System.Drawing.Size(155, 17);
            this.checkLlanta3.TabIndex = 2;
            this.checkLlanta3.Text = "Llanta trasera derecha";
            this.checkLlanta3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(214)))));
            this.panel2.Controls.Add(this.heplBtn);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(689, 558);
            this.panel2.TabIndex = 8;
            // 
            // heplBtn
            // 
            this.heplBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.heplBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.heplBtn.IconColor = System.Drawing.Color.Black;
            this.heplBtn.IconSize = 16;
            this.heplBtn.Location = new System.Drawing.Point(605, 9);
            this.heplBtn.Name = "heplBtn";
            this.heplBtn.Rotation = 0D;
            this.heplBtn.Size = new System.Drawing.Size(72, 28);
            this.heplBtn.TabIndex = 18;
            this.heplBtn.Text = "Ayuda";
            this.heplBtn.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "Inspecciones realizadas";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.inspectionsDV);
            this.panel3.Location = new System.Drawing.Point(9, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(668, 507);
            this.panel3.TabIndex = 0;
            // 
            // inspectionsDV
            // 
            this.inspectionsDV.AllowUserToAddRows = false;
            this.inspectionsDV.AllowUserToDeleteRows = false;
            this.inspectionsDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inspectionsDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inspectionsDV.Location = new System.Drawing.Point(0, 0);
            this.inspectionsDV.Name = "inspectionsDV";
            this.inspectionsDV.ReadOnly = true;
            this.inspectionsDV.Size = new System.Drawing.Size(668, 507);
            this.inspectionsDV.TabIndex = 0;
            this.inspectionsDV.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.inspectionsDV_CellMouseDoubleClick);
            // 
            // InspectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 558);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InspectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inspectionsDV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox inspectionCommentTX;
        private System.Windows.Forms.Label formTile;
        private FontAwesome.Sharp.IconButton SaveInspectionBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CustomerCB;
        private System.Windows.Forms.TextBox inspector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox hasScratchesChek;
        private System.Windows.Forms.ComboBox CarCB;
        private System.Windows.Forms.CheckBox hasBotiquinChek;
        private System.Windows.Forms.CheckBox hasRefactionChek;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox QuantityOfFuelCB;
        private System.Windows.Forms.CheckBox checkLlanta1;
        private System.Windows.Forms.CheckBox checkLlanta2;
        private System.Windows.Forms.CheckBox checkLlanta4;
        private System.Windows.Forms.CheckBox checkLlanta3;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton heplBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView inspectionsDV;
    }
}