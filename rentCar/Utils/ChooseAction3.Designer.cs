namespace rentCar.views.users
{
    partial class ChooseAction3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseAction3));
            this.ContChooseAction = new System.Windows.Forms.Panel();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.ContChooseAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContChooseAction
            // 
            this.ContChooseAction.Controls.Add(this.iconButton3);
            this.ContChooseAction.Controls.Add(this.iconButton2);
            this.ContChooseAction.Controls.Add(this.iconButton1);
            this.ContChooseAction.Controls.Add(this.label1);
            this.ContChooseAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContChooseAction.Location = new System.Drawing.Point(0, 0);
            this.ContChooseAction.Name = "ContChooseAction";
            this.ContChooseAction.Size = new System.Drawing.Size(621, 157);
            this.ContChooseAction.TabIndex = 0;
            // 
            // iconButton3
            // 
            this.iconButton3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.iconButton3.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconSize = 16;
            this.iconButton3.Location = new System.Drawing.Point(12, 76);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Rotation = 0D;
            this.iconButton3.Size = new System.Drawing.Size(134, 53);
            this.iconButton3.TabIndex = 6;
            this.iconButton3.Text = "Eliminar";
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            this.iconButton2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.iconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconSize = 16;
            this.iconButton2.Location = new System.Drawing.Point(242, 76);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Rotation = 0D;
            this.iconButton2.Size = new System.Drawing.Size(134, 53);
            this.iconButton2.TabIndex = 5;
            this.iconButton2.Text = "Editar";
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            this.iconButton1.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconSize = 16;
            this.iconButton1.Location = new System.Drawing.Point(475, 76);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(134, 53);
            this.iconButton1.TabIndex = 4;
            this.iconButton1.Text = "Obtener credenciales";
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Que accion desea ejecutar sobre este elemento?";
            // 
            // ChooseAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 157);
            this.ControlBox = false;
            this.Controls.Add(this.ContChooseAction);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChooseAction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ContChooseAction.ResumeLayout(false);
            this.ContChooseAction.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ContChooseAction;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButton3;
    }
}