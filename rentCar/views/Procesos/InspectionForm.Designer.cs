﻿namespace rentCar.views
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkLlanta2 = new System.Windows.Forms.CheckBox();
            this.checkLlanta3 = new System.Windows.Forms.CheckBox();
            this.checkLlanta4 = new System.Windows.Forms.CheckBox();
            this.checkLlanta1 = new System.Windows.Forms.CheckBox();
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
            this.QuantityOfFuelCB = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.heplBtn = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.inspectionsDV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionsDV)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(164, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // checkLlanta2
            // 
            this.checkLlanta2.AutoSize = true;
            this.checkLlanta2.Location = new System.Drawing.Point(349, 85);
            this.checkLlanta2.Name = "checkLlanta2";
            this.checkLlanta2.Size = new System.Drawing.Size(144, 17);
            this.checkLlanta2.TabIndex = 1;
            this.checkLlanta2.Text = "Llanta delantera derecha";
            this.checkLlanta2.UseVisualStyleBackColor = true;
            // 
            // checkLlanta3
            // 
            this.checkLlanta3.AutoSize = true;
            this.checkLlanta3.Location = new System.Drawing.Point(349, 247);
            this.checkLlanta3.Name = "checkLlanta3";
            this.checkLlanta3.Size = new System.Drawing.Size(132, 17);
            this.checkLlanta3.TabIndex = 2;
            this.checkLlanta3.Text = "Llanta trasera derecha";
            this.checkLlanta3.UseVisualStyleBackColor = true;
            // 
            // checkLlanta4
            // 
            this.checkLlanta4.AutoSize = true;
            this.checkLlanta4.Location = new System.Drawing.Point(23, 247);
            this.checkLlanta4.Name = "checkLlanta4";
            this.checkLlanta4.Size = new System.Drawing.Size(135, 17);
            this.checkLlanta4.TabIndex = 3;
            this.checkLlanta4.Text = "Llanta trasera izquierda";
            this.checkLlanta4.UseVisualStyleBackColor = true;
            // 
            // checkLlanta1
            // 
            this.checkLlanta1.AutoSize = true;
            this.checkLlanta1.Location = new System.Drawing.Point(11, 83);
            this.checkLlanta1.Name = "checkLlanta1";
            this.checkLlanta1.Size = new System.Drawing.Size(147, 17);
            this.checkLlanta1.TabIndex = 4;
            this.checkLlanta1.Text = "Llanta delantera izquierda";
            this.checkLlanta1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
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
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 507);
            this.panel1.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(352, 411);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Comentario de inspeccion";
            // 
            // inspectionCommentTX
            // 
            this.inspectionCommentTX.Location = new System.Drawing.Point(352, 427);
            this.inspectionCommentTX.Multiline = true;
            this.inspectionCommentTX.Name = "inspectionCommentTX";
            this.inspectionCommentTX.Size = new System.Drawing.Size(215, 68);
            this.inspectionCommentTX.TabIndex = 18;
            // 
            // formTile
            // 
            this.formTile.AutoSize = true;
            this.formTile.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formTile.Location = new System.Drawing.Point(12, 9);
            this.formTile.Name = "formTile";
            this.formTile.Size = new System.Drawing.Size(170, 16);
            this.formTile.TabIndex = 17;
            this.formTile.Text = "Formulario de inspeccion";
            // 
            // SaveInspectionBtn
            // 
            this.SaveInspectionBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.SaveInspectionBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SaveInspectionBtn.IconColor = System.Drawing.Color.Black;
            this.SaveInspectionBtn.IconSize = 16;
            this.SaveInspectionBtn.Location = new System.Drawing.Point(438, 3);
            this.SaveInspectionBtn.Name = "SaveInspectionBtn";
            this.SaveInspectionBtn.Rotation = 0D;
            this.SaveInspectionBtn.Size = new System.Drawing.Size(129, 57);
            this.SaveInspectionBtn.TabIndex = 16;
            this.SaveInspectionBtn.Text = "Guardar inspeccion";
            this.SaveInspectionBtn.UseVisualStyleBackColor = true;
            this.SaveInspectionBtn.Click += new System.EventHandler(this.SaveInspectionBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cliente que desea rentar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 459);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Empleado que asiste";
            // 
            // CustomerCB
            // 
            this.CustomerCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CustomerCB.FormattingEnabled = true;
            this.CustomerCB.Location = new System.Drawing.Point(6, 427);
            this.CustomerCB.Name = "CustomerCB";
            this.CustomerCB.Size = new System.Drawing.Size(337, 21);
            this.CustomerCB.TabIndex = 7;
            // 
            // inspector
            // 
            this.inspector.Location = new System.Drawing.Point(6, 475);
            this.inspector.Name = "inspector";
            this.inspector.ReadOnly = true;
            this.inspector.Size = new System.Drawing.Size(337, 20);
            this.inspector.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Vehiculo bajo inspeccion";
            // 
            // hasScratchesChek
            // 
            this.hasScratchesChek.AutoSize = true;
            this.hasScratchesChek.Location = new System.Drawing.Point(255, 336);
            this.hasScratchesChek.Name = "hasScratchesChek";
            this.hasScratchesChek.Size = new System.Drawing.Size(239, 17);
            this.hasScratchesChek.TabIndex = 13;
            this.hasScratchesChek.Text = "Tiene alguna ralladura de cristal u otra parte?";
            this.hasScratchesChek.UseVisualStyleBackColor = true;
            // 
            // CarCB
            // 
            this.CarCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CarCB.FormattingEnabled = true;
            this.CarCB.Location = new System.Drawing.Point(6, 380);
            this.CarCB.Name = "CarCB";
            this.CarCB.Size = new System.Drawing.Size(337, 21);
            this.CarCB.TabIndex = 5;
            // 
            // hasBotiquinChek
            // 
            this.hasBotiquinChek.AutoSize = true;
            this.hasBotiquinChek.Location = new System.Drawing.Point(118, 337);
            this.hasBotiquinChek.Name = "hasBotiquinChek";
            this.hasBotiquinChek.Size = new System.Drawing.Size(131, 17);
            this.hasBotiquinChek.TabIndex = 12;
            this.hasBotiquinChek.Text = "Tiene gato y botiquin?";
            this.hasBotiquinChek.UseVisualStyleBackColor = true;
            // 
            // hasRefactionChek
            // 
            this.hasRefactionChek.AutoSize = true;
            this.hasRefactionChek.Location = new System.Drawing.Point(6, 337);
            this.hasRefactionChek.Name = "hasRefactionChek";
            this.hasRefactionChek.Size = new System.Drawing.Size(106, 17);
            this.hasRefactionChek.TabIndex = 11;
            this.hasRefactionChek.Text = "Tiene refaccion?";
            this.hasRefactionChek.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cantidad de combustible";
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
            this.QuantityOfFuelCB.Location = new System.Drawing.Point(355, 380);
            this.QuantityOfFuelCB.Name = "QuantityOfFuelCB";
            this.QuantityOfFuelCB.Size = new System.Drawing.Size(212, 21);
            this.QuantityOfFuelCB.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.heplBtn);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(573, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(689, 507);
            this.panel2.TabIndex = 6;
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
            this.heplBtn.Click += new System.EventHandler(this.heplBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 16);
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
            this.panel3.Size = new System.Drawing.Size(668, 456);
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
            this.inspectionsDV.Size = new System.Drawing.Size(668, 456);
            this.inspectionsDV.TabIndex = 0;
            this.inspectionsDV.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.inspectionsDV_CellMouseDoubleClick);
            // 
            // InspectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 507);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InspectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inspectionsDV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkLlanta2;
        private System.Windows.Forms.CheckBox checkLlanta3;
        private System.Windows.Forms.CheckBox checkLlanta4;
        private System.Windows.Forms.CheckBox checkLlanta1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CustomerCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CarCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox QuantityOfFuelCB;
        private System.Windows.Forms.CheckBox hasScratchesChek;
        private System.Windows.Forms.CheckBox hasBotiquinChek;
        private System.Windows.Forms.CheckBox hasRefactionChek;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inspector;
        private FontAwesome.Sharp.IconButton SaveInspectionBtn;
        private System.Windows.Forms.Label formTile;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton heplBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView inspectionsDV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox inspectionCommentTX;
    }
}