namespace rentCar.views.car.commonCruds
{
    partial class GeneralCrud
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
            this.statusCheck = new System.Windows.Forms.CheckBox();
            this.deleteBtn = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.descriptionInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveEditBtn = new FontAwesome.Sharp.IconButton();
            this.idInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // statusCheck
            // 
            this.statusCheck.AutoSize = true;
            this.statusCheck.Location = new System.Drawing.Point(120, 103);
            this.statusCheck.Name = "statusCheck";
            this.statusCheck.Size = new System.Drawing.Size(91, 17);
            this.statusCheck.TabIndex = 53;
            this.statusCheck.Text = "Estado activo";
            this.statusCheck.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.deleteBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.deleteBtn.IconColor = System.Drawing.Color.Black;
            this.deleteBtn.IconSize = 16;
            this.deleteBtn.Location = new System.Drawing.Point(12, 146);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Rotation = 0D;
            this.deleteBtn.Size = new System.Drawing.Size(99, 47);
            this.deleteBtn.TabIndex = 52;
            this.deleteBtn.Text = "Eliminar ";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Descripcion";
            // 
            // descriptionInput
            // 
            this.descriptionInput.Location = new System.Drawing.Point(120, 58);
            this.descriptionInput.Name = "descriptionInput";
            this.descriptionInput.Size = new System.Drawing.Size(221, 20);
            this.descriptionInput.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Identificador";
            // 
            // saveEditBtn
            // 
            this.saveEditBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveEditBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.saveEditBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.saveEditBtn.IconColor = System.Drawing.Color.Black;
            this.saveEditBtn.IconSize = 16;
            this.saveEditBtn.Location = new System.Drawing.Point(255, 144);
            this.saveEditBtn.Name = "saveEditBtn";
            this.saveEditBtn.Rotation = 0D;
            this.saveEditBtn.Size = new System.Drawing.Size(107, 47);
            this.saveEditBtn.TabIndex = 46;
            this.saveEditBtn.Text = "Guardar cambios";
            this.saveEditBtn.UseVisualStyleBackColor = true;
            this.saveEditBtn.Click += new System.EventHandler(this.saveEditBtn_Click);
            // 
            // idInput
            // 
            this.idInput.Location = new System.Drawing.Point(120, 14);
            this.idInput.Name = "idInput";
            this.idInput.ReadOnly = true;
            this.idInput.Size = new System.Drawing.Size(221, 20);
            this.idInput.TabIndex = 45;
            // 
            // CommondCrudDE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 205);
            this.Controls.Add(this.statusCheck);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.descriptionInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveEditBtn);
            this.Controls.Add(this.idInput);
            this.Name = "CommondCrudDE";
            this.Text = "CommondCrudDE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox statusCheck;
        private FontAwesome.Sharp.IconButton deleteBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox descriptionInput;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton saveEditBtn;
        private System.Windows.Forms.TextBox idInput;
    }
}