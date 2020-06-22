namespace rentCar.views.car.type
{
    partial class ConfirmAction
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
            this.label1 = new System.Windows.Forms.Label();
            this.okBtn = new FontAwesome.Sharp.IconButton();
            this.cancelBtn = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Esta seguro de eliminar este elemento ?";
            // 
            // okBtn
            // 
            this.okBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.okBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.okBtn.IconColor = System.Drawing.Color.Black;
            this.okBtn.IconSize = 16;
            this.okBtn.Location = new System.Drawing.Point(279, 64);
            this.okBtn.Name = "okBtn";
            this.okBtn.Rotation = 0D;
            this.okBtn.Size = new System.Drawing.Size(124, 57);
            this.okBtn.TabIndex = 1;
            this.okBtn.Text = "Si, borrar";
            this.okBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.cancelBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.cancelBtn.IconColor = System.Drawing.Color.Black;
            this.cancelBtn.IconSize = 16;
            this.cancelBtn.Location = new System.Drawing.Point(16, 64);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Rotation = 0D;
            this.cancelBtn.Size = new System.Drawing.Size(124, 57);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "No, cancelar";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // Confirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 133);
            this.ControlBox = false;
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.label1);
            this.Name = "Confirmation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton okBtn;
        private FontAwesome.Sharp.IconButton cancelBtn;
    }
}