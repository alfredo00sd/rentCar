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
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnEdit = new FontAwesome.Sharp.IconButton();
            this.btnInfo = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.ContChooseAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContChooseAction
            // 
            this.ContChooseAction.Controls.Add(this.btnDelete);
            this.ContChooseAction.Controls.Add(this.btnEdit);
            this.ContChooseAction.Controls.Add(this.btnInfo);
            this.ContChooseAction.Controls.Add(this.label1);
            this.ContChooseAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContChooseAction.Location = new System.Drawing.Point(0, 0);
            this.ContChooseAction.Name = "ContChooseAction";
            this.ContChooseAction.Size = new System.Drawing.Size(621, 192);
            this.ContChooseAction.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDelete.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDelete.IconColor = System.Drawing.Color.Black;
            this.btnDelete.IconSize = 16;
            this.btnDelete.Location = new System.Drawing.Point(475, 130);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Rotation = 0D;
            this.btnDelete.Size = new System.Drawing.Size(134, 53);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEdit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnEdit.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnEdit.IconColor = System.Drawing.Color.Black;
            this.btnEdit.IconSize = 16;
            this.btnEdit.Location = new System.Drawing.Point(475, 71);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Rotation = 0D;
            this.btnEdit.Size = new System.Drawing.Size(134, 53);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnInfo
            // 
            this.btnInfo.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.btnInfo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnInfo.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnInfo.IconColor = System.Drawing.Color.Black;
            this.btnInfo.IconSize = 16;
            this.btnInfo.Location = new System.Drawing.Point(475, 12);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Rotation = 0D;
            this.btnInfo.Size = new System.Drawing.Size(134, 53);
            this.btnInfo.TabIndex = 4;
            this.btnInfo.Text = "Obtener credenciales";
            this.btnInfo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Que accion desea ejecutar ?";
            // 
            // ChooseAction3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 192);
            this.ControlBox = false;
            this.Controls.Add(this.ContChooseAction);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChooseAction3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ContChooseAction.ResumeLayout(false);
            this.ContChooseAction.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ContChooseAction;
        private FontAwesome.Sharp.IconButton btnEdit;
        private FontAwesome.Sharp.IconButton btnInfo;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnDelete;
    }
}