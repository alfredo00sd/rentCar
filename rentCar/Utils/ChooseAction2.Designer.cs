namespace rentCar.views.car
{
    partial class ChooseAction2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseAction2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.rightBtn = new FontAwesome.Sharp.IconButton();
            this.leftBtn = new FontAwesome.Sharp.IconButton();
            this.chooseMsg = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rightBtn);
            this.panel1.Controls.Add(this.leftBtn);
            this.panel1.Controls.Add(this.chooseMsg);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 161);
            this.panel1.TabIndex = 0;
            // 
            // rightBtn
            // 
            this.rightBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.rightBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.rightBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.rightBtn.IconColor = System.Drawing.Color.Black;
            this.rightBtn.IconSize = 16;
            this.rightBtn.Location = new System.Drawing.Point(334, 96);
            this.rightBtn.Name = "rightBtn";
            this.rightBtn.Rotation = 0D;
            this.rightBtn.Size = new System.Drawing.Size(134, 53);
            this.rightBtn.TabIndex = 2;
            this.rightBtn.Text = "Editar";
            this.rightBtn.UseVisualStyleBackColor = true;
            // 
            // leftBtn
            // 
            this.leftBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.leftBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.leftBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.leftBtn.IconColor = System.Drawing.Color.Black;
            this.leftBtn.IconSize = 16;
            this.leftBtn.Location = new System.Drawing.Point(12, 96);
            this.leftBtn.Name = "leftBtn";
            this.leftBtn.Rotation = 0D;
            this.leftBtn.Size = new System.Drawing.Size(134, 53);
            this.leftBtn.TabIndex = 1;
            this.leftBtn.Text = "Eliminar";
            this.leftBtn.UseVisualStyleBackColor = true;
            // 
            // chooseMsg
            // 
            this.chooseMsg.AutoSize = true;
            this.chooseMsg.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseMsg.Location = new System.Drawing.Point(75, 32);
            this.chooseMsg.Name = "chooseMsg";
            this.chooseMsg.Size = new System.Drawing.Size(335, 18);
            this.chooseMsg.TabIndex = 0;
            this.chooseMsg.Text = "Desea editar o eliminar este elemento?";
            // 
            // ChooseAction2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 161);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChooseAction2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label chooseMsg;
        private FontAwesome.Sharp.IconButton rightBtn;
        private FontAwesome.Sharp.IconButton leftBtn;
    }
}