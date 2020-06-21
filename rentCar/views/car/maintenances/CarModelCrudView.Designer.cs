namespace rentCar.views.car.type
{
    partial class CommonDEView
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
            this.modelIdTB.Location = new System.Drawing.Point(120, 10);
            this.modelIdTB.Name = "modelIdTB";
            this.modelIdTB.ReadOnly = true;
            this.modelIdTB.Size = new System.Drawing.Size(221, 20);
            this.modelIdTB.TabIndex = 0;
            // 
            // saveEditBtn
            // 
            this.saveEditBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveEditBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.saveEditBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.saveEditBtn.IconColor = System.Drawing.Color.Black;
            this.saveEditBtn.IconSize = 16;
            this.saveEditBtn.Location = new System.Drawing.Point(234, 202);
            this.saveEditBtn.Name = "saveEditBtn";
            this.saveEditBtn.Rotation = 0D;
            this.saveEditBtn.Size = new System.Drawing.Size(107, 47);
            this.saveEditBtn.TabIndex = 1;
            this.saveEditBtn.Text = "Guardar cambios";
            this.saveEditBtn.UseVisualStyleBackColor = true;
            this.saveEditBtn.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Identificador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Modelo";
            // 
            // modeloTB
            // 
            this.modeloTB.Location = new System.Drawing.Point(120, 54);
            this.modeloTB.Name = "modeloTB";
            this.modeloTB.Size = new System.Drawing.Size(221, 20);
            this.modeloTB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pertence a la marca";
            // 
            // CarBrandCB
            // 
            this.CarBrandCB.DisplayMember = "assad";
            this.CarBrandCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CarBrandCB.FormattingEnabled = true;
            this.CarBrandCB.Location = new System.Drawing.Point(120, 101);
            this.CarBrandCB.Name = "CarBrandCB";
            this.CarBrandCB.Size = new System.Drawing.Size(221, 21);
            this.CarBrandCB.TabIndex = 41;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.deleteBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.deleteBtn.IconColor = System.Drawing.Color.Black;
            this.deleteBtn.IconSize = 16;
            this.deleteBtn.Location = new System.Drawing.Point(12, 202);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Rotation = 0D;
            this.deleteBtn.Size = new System.Drawing.Size(99, 47);
            this.deleteBtn.TabIndex = 42;
            this.deleteBtn.Text = "Eliminar ";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // statusCheck
            // 
            this.statusCheck.AutoSize = true;
            this.statusCheck.Location = new System.Drawing.Point(120, 138);
            this.statusCheck.Name = "statusCheck";
            this.statusCheck.Size = new System.Drawing.Size(91, 17);
            this.statusCheck.TabIndex = 44;
            this.statusCheck.Text = "Estado activo";
            this.statusCheck.UseVisualStyleBackColor = true;
            // 
            // CommonDEView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Name = "CommonDEView";
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