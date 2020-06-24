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
            this.userNameTX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.userContainerForm = new System.Windows.Forms.Panel();
            this.recoverCredentials = new System.Windows.Forms.LinkLabel();
            this.validateUserBtn = new FontAwesome.Sharp.IconButton();
            this.appLogo = new System.Windows.Forms.PictureBox();
            this.passTX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.minimizeBtn = new FontAwesome.Sharp.IconPictureBox();
            this.closeBtn = new FontAwesome.Sharp.IconPictureBox();
            this.maximizeBtn = new FontAwesome.Sharp.IconPictureBox();
            this.userContainerForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // userNameTX
            // 
            this.userNameTX.Location = new System.Drawing.Point(166, 220);
            this.userNameTX.MaxLength = 15;
            this.userNameTX.Name = "userNameTX";
            this.userNameTX.Size = new System.Drawing.Size(304, 20);
            this.userNameTX.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(163, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            // 
            // userContainerForm
            // 
            this.userContainerForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.userContainerForm.Controls.Add(this.recoverCredentials);
            this.userContainerForm.Controls.Add(this.validateUserBtn);
            this.userContainerForm.Controls.Add(this.appLogo);
            this.userContainerForm.Controls.Add(this.passTX);
            this.userContainerForm.Controls.Add(this.label2);
            this.userContainerForm.Controls.Add(this.userNameTX);
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
            this.recoverCredentials.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.recoverCredentials_LinkClicked);
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
            // passTX
            // 
            this.passTX.Location = new System.Drawing.Point(166, 269);
            this.passTX.MaxLength = 30;
            this.passTX.Name = "passTX";
            this.passTX.PasswordChar = '*';
            this.passTX.Size = new System.Drawing.Size(304, 20);
            this.passTX.TabIndex = 2;
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
            // minimizeBtn
            // 
            this.minimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.minimizeBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.minimizeBtn.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.minimizeBtn.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.minimizeBtn.IconSize = 23;
            this.minimizeBtn.Location = new System.Drawing.Point(713, 3);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(24, 23);
            this.minimizeBtn.TabIndex = 11;
            this.minimizeBtn.TabStop = false;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(0)))), ((int)(((byte)(33)))));
            this.closeBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.closeBtn.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.closeBtn.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.closeBtn.IconSize = 23;
            this.closeBtn.Location = new System.Drawing.Point(773, 3);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(24, 23);
            this.closeBtn.TabIndex = 10;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // maximizeBtn
            // 
            this.maximizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.maximizeBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.maximizeBtn.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.maximizeBtn.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.maximizeBtn.IconSize = 23;
            this.maximizeBtn.Location = new System.Drawing.Point(743, 3);
            this.maximizeBtn.Name = "maximizeBtn";
            this.maximizeBtn.Size = new System.Drawing.Size(24, 23);
            this.maximizeBtn.TabIndex = 9;
            this.maximizeBtn.TabStop = false;
            this.maximizeBtn.Click += new System.EventHandler(this.maximizeBtn_Click);
            // 
            // userLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(0)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.minimizeBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.maximizeBtn);
            this.Controls.Add(this.userContainerForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "userLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.userContainerForm.ResumeLayout(false);
            this.userContainerForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizeBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox userNameTX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel userContainerForm;
        private System.Windows.Forms.TextBox passTX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox appLogo;
        private FontAwesome.Sharp.IconButton validateUserBtn;
        private System.Windows.Forms.LinkLabel recoverCredentials;
        private FontAwesome.Sharp.IconPictureBox minimizeBtn;
        private FontAwesome.Sharp.IconPictureBox closeBtn;
        private FontAwesome.Sharp.IconPictureBox maximizeBtn;
    }
}