namespace rentCar.views.car.type
{
    partial class CarModelEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarModelEditForm));
            this.modelIdTB = new System.Windows.Forms.TextBox();
            this.saveEditBtn = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.modeloTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CarBrandCB = new System.Windows.Forms.ComboBox();
            this.deleteBtn = new FontAwesome.Sharp.IconButton();
            this.statusCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // modelIdTB
            // 
            this.modelIdTB.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelIdTB.Location = new System.Drawing.Point(120, 10);
            this.modelIdTB.Name = "modelIdTB";
            this.modelIdTB.ReadOnly = true;
            this.modelIdTB.Size = new System.Drawing.Size(221, 23);
            this.modelIdTB.TabIndex = 0;
            // 
            // saveEditBtn
            // 
            this.saveEditBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(95)))));
            this.saveEditBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveEditBtn.FlatAppearance.BorderSize = 0;
            this.saveEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveEditBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.saveEditBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveEditBtn.ForeColor = System.Drawing.Color.White;
            this.saveEditBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.saveEditBtn.IconColor = System.Drawing.Color.Black;
            this.saveEditBtn.IconSize = 16;
            this.saveEditBtn.Location = new System.Drawing.Point(224, 193);
            this.saveEditBtn.Name = "saveEditBtn";
            this.saveEditBtn.Rotation = 0D;
            this.saveEditBtn.Size = new System.Drawing.Size(128, 65);
            this.saveEditBtn.TabIndex = 1;
            this.saveEditBtn.Text = "Guardar cambios";
            this.saveEditBtn.UseVisualStyleBackColor = false;
            this.saveEditBtn.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Identificador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Modelo";
            // 
            // modeloTB
            // 
            this.modeloTB.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeloTB.Location = new System.Drawing.Point(120, 54);
            this.modeloTB.Name = "modeloTB";
            this.modeloTB.Size = new System.Drawing.Size(221, 23);
            this.modeloTB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Marca";
            // 
            // CarBrandCB
            // 
            this.CarBrandCB.DisplayMember = "assad";
            this.CarBrandCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CarBrandCB.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarBrandCB.FormattingEnabled = true;
            this.CarBrandCB.Location = new System.Drawing.Point(120, 101);
            this.CarBrandCB.Name = "CarBrandCB";
            this.CarBrandCB.Size = new System.Drawing.Size(221, 24);
            this.CarBrandCB.TabIndex = 41;
            this.CarBrandCB.SelectedIndexChanged += new System.EventHandler(this.CarBrandCB_SelectedIndexChanged);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(0)))), ((int)(((byte)(39)))));
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.deleteBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.deleteBtn.IconColor = System.Drawing.Color.Black;
            this.deleteBtn.IconSize = 16;
            this.deleteBtn.Location = new System.Drawing.Point(2, 193);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Rotation = 0D;
            this.deleteBtn.Size = new System.Drawing.Size(127, 65);
            this.deleteBtn.TabIndex = 42;
            this.deleteBtn.Text = "Eliminar ";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // statusCheck
            // 
            this.statusCheck.AutoSize = true;
            this.statusCheck.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusCheck.ForeColor = System.Drawing.Color.White;
            this.statusCheck.Location = new System.Drawing.Point(120, 146);
            this.statusCheck.Name = "statusCheck";
            this.statusCheck.Size = new System.Drawing.Size(118, 20);
            this.statusCheck.TabIndex = 44;
            this.statusCheck.Text = "Estado activo";
            this.statusCheck.UseVisualStyleBackColor = true;
            // 
            // CarModelEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(353, 261);
            this.Controls.Add(this.statusCheck);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.CarBrandCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.modeloTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveEditBtn);
            this.Controls.Add(this.modelIdTB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CarModelEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar/Borrar modelo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox modelIdTB;
        private FontAwesome.Sharp.IconButton saveEditBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox modeloTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CarBrandCB;
        private FontAwesome.Sharp.IconButton deleteBtn;
        private System.Windows.Forms.CheckBox statusCheck;
    }
}