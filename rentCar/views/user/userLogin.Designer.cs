namespace rentCar.user
{
    partial class userLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userLogin));
            this.userCard = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.userContainerForm = new System.Windows.Forms.Panel();
            this.recoverCredentials = new System.Windows.Forms.LinkLabel();
            this.validateUserBtn = new FontAwesome.Sharp.IconButton();
            this.appLogo = new System.Windows.Forms.PictureBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userContainerForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // userCard
            // 
            this.userCard.Location = new System.Drawing.Point(166, 220);
            this.userCard.MaxLength = 15;
            this.userCard.Name = "userCard";
            this.userCard.Size = new System.Drawing.Size(304, 20);
            this.userCard.TabIndex = 0;
            this.userCard.TextChanged += new System.EventHandler(this.userCard_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(163, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tarjeta de empleado";
            // 
            // userContainerForm
            // 
            this.userContainerForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.userContainerForm.Controls.Add(this.recoverCredentials);
            this.userContainerForm.Controls.Add(this.validateUserBtn);
            this.userContainerForm.Controls.Add(this.appLogo);
            this.userContainerForm.Controls.Add(this.passwordInput);
            this.userContainerForm.Controls.Add(this.label2);
            this.userContainerForm.Controls.Add(this.userCard);
            this.userContainerForm.Controls.Add(this.label1);
            this.userContainerForm.Location = new System.Drawing.Point(75, 33);
            this.userContainerForm.Name = "userContainerForm";
            this.userContainerForm.Size = new System.Drawing.Size(642, 389);
            this.userContainerForm.TabIndex = 2;
            // 
            // recoverCredentials
            // 
            this.recoverCredentials.AutoSize = true;
            this.recoverCredentials.LinkColor = System.Drawing.Color.White;
            this.recoverCredentials.Location = new System.Drawing.Point(248, 364);
            this.recoverCredentials.Name = "recoverCredentials";
            this.recoverCredentials.Size = new System.Drawing.Size(128, 13);
            this.recoverCredentials.TabIndex = 6;
            this.recoverCredentials.TabStop = true;
            this.recoverCredentials.Text = "Olvido sus credenciales ?";
            // 
            // validateUserBtn
            // 
            this.validateUserBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(0)))), ((int)(((byte)(26)))));
            this.validateUserBtn.FlatAppearance.BorderSize = 0;
            this.validateUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.validateUserBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.validateUserBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validateUserBtn.ForeColor = System.Drawing.Color.White;
            this.validateUserBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.validateUserBtn.IconColor = System.Drawing.Color.Black;
            this.validateUserBtn.IconSize = 16;
            this.validateUserBtn.Location = new System.Drawing.Point(166, 306);
            this.validateUserBtn.Name = "validateUserBtn";
            this.validateUserBtn.Rotation = 0D;
            this.validateUserBtn.Size = new System.Drawing.Size(304, 39);
            this.validateUserBtn.TabIndex = 5;
            this.validateUserBtn.Text = "Ingresar";
            this.validateUserBtn.UseVisualStyleBackColor = false;
            this.validateUserBtn.Click += new System.EventHandler(this.validateUserBtn_Click);
            // 
            // appLogo
            // 
            this.appLogo.Image = ((System.Drawing.Image)(resources.GetObject("appLogo.Image")));
            this.appLogo.Location = new System.Drawing.Point(166, 16);
            this.appLogo.Name = "appLogo";
            this.appLogo.Size = new System.Drawing.Size(302, 171);
            this.appLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.appLogo.TabIndex = 4;
            this.appLogo.TabStop = false;
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(166, 269);
            this.passwordInput.MaxLength = 30;
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '*';
            this.passwordInput.Size = new System.Drawing.Size(304, 20);
            this.passwordInput.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(163, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Clave";
            // 
            // userLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(0)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.userContainerForm);
            this.Name = "userLogin";
            this.userContainerForm.ResumeLayout(false);
            this.userContainerForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox userCard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel userContainerForm;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox appLogo;
        private FontAwesome.Sharp.IconButton validateUserBtn;
        private System.Windows.Forms.LinkLabel recoverCredentials;
    }
}