namespace rentCar
{
    partial class AppForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppForm));
            this.menuPanel = new System.Windows.Forms.Panel();
            this.adminSubMenuPanel = new System.Windows.Forms.Panel();
            this.reportBtn = new FontAwesome.Sharp.IconButton();
            this.consultBtn = new FontAwesome.Sharp.IconButton();
            this.processSubMenuPanel = new System.Windows.Forms.Panel();
            this.rentManagerBtn = new FontAwesome.Sharp.IconButton();
            this.inspectorManagerBtn = new FontAwesome.Sharp.IconButton();
            this.copyRights = new System.Windows.Forms.LinkLabel();
            this.processBtn = new FontAwesome.Sharp.IconButton();
            this.gestiSubMenuPanel = new System.Windows.Forms.Panel();
            this.CustomerManagerBtn = new FontAwesome.Sharp.IconButton();
            this.employeeManagerBtn = new FontAwesome.Sharp.IconButton();
            this.GeneralManagerBtn = new FontAwesome.Sharp.IconButton();
            this.carManagerBtn = new FontAwesome.Sharp.IconButton();
            this.gestiBtn = new FontAwesome.Sharp.IconButton();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.appLogo = new System.Windows.Forms.PictureBox();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelDash = new System.Windows.Forms.Panel();
            this.titleBar = new System.Windows.Forms.Panel();
            this.userStatus = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.userName = new System.Windows.Forms.Label();
            this.minimizeBtn = new FontAwesome.Sharp.IconPictureBox();
            this.closeBtn = new FontAwesome.Sharp.IconPictureBox();
            this.maximizeBtn = new FontAwesome.Sharp.IconPictureBox();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.menuPanel.SuspendLayout();
            this.adminSubMenuPanel.SuspendLayout();
            this.processSubMenuPanel.SuspendLayout();
            this.gestiSubMenuPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appLogo)).BeginInit();
            this.panelContainer.SuspendLayout();
            this.titleBar.SuspendLayout();
            this.userStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.menuPanel.Controls.Add(this.adminSubMenuPanel);
            this.menuPanel.Controls.Add(this.processSubMenuPanel);
            this.menuPanel.Controls.Add(this.copyRights);
            this.menuPanel.Controls.Add(this.processBtn);
            this.menuPanel.Controls.Add(this.gestiSubMenuPanel);
            this.menuPanel.Controls.Add(this.gestiBtn);
            this.menuPanel.Controls.Add(this.logoPanel);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPanel.ForeColor = System.Drawing.Color.White;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(234, 563);
            this.menuPanel.TabIndex = 0;
            // 
            // adminSubMenuPanel
            // 
            this.adminSubMenuPanel.Controls.Add(this.reportBtn);
            this.adminSubMenuPanel.Controls.Add(this.consultBtn);
            this.adminSubMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.adminSubMenuPanel.Location = new System.Drawing.Point(0, 421);
            this.adminSubMenuPanel.Name = "adminSubMenuPanel";
            this.adminSubMenuPanel.Size = new System.Drawing.Size(234, 103);
            this.adminSubMenuPanel.TabIndex = 8;
            // 
            // reportBtn
            // 
            this.reportBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.reportBtn.FlatAppearance.BorderSize = 0;
            this.reportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.reportBtn.ForeColor = System.Drawing.Color.FloralWhite;
            this.reportBtn.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.reportBtn.IconColor = System.Drawing.Color.WhiteSmoke;
            this.reportBtn.IconSize = 32;
            this.reportBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportBtn.Location = new System.Drawing.Point(0, 44);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.reportBtn.Rotation = 0D;
            this.reportBtn.Size = new System.Drawing.Size(234, 46);
            this.reportBtn.TabIndex = 7;
            this.reportBtn.Text = "Reportes";
            this.reportBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.reportBtn.UseVisualStyleBackColor = true;
            this.reportBtn.Click += new System.EventHandler(this.ReportBtn_Click);
            // 
            // consultBtn
            // 
            this.consultBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.consultBtn.FlatAppearance.BorderSize = 0;
            this.consultBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.consultBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.consultBtn.ForeColor = System.Drawing.Color.FloralWhite;
            this.consultBtn.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.consultBtn.IconColor = System.Drawing.Color.WhiteSmoke;
            this.consultBtn.IconSize = 32;
            this.consultBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.consultBtn.Location = new System.Drawing.Point(0, 0);
            this.consultBtn.Name = "consultBtn";
            this.consultBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.consultBtn.Rotation = 0D;
            this.consultBtn.Size = new System.Drawing.Size(234, 44);
            this.consultBtn.TabIndex = 8;
            this.consultBtn.Text = "Consultas";
            this.consultBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.consultBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.consultBtn.UseVisualStyleBackColor = true;
            this.consultBtn.Click += new System.EventHandler(this.ConsultBtn_Click);
            // 
            // processSubMenuPanel
            // 
            this.processSubMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(0)))), ((int)(((byte)(33)))));
            this.processSubMenuPanel.Controls.Add(this.rentManagerBtn);
            this.processSubMenuPanel.Controls.Add(this.inspectorManagerBtn);
            this.processSubMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.processSubMenuPanel.Location = new System.Drawing.Point(0, 348);
            this.processSubMenuPanel.Name = "processSubMenuPanel";
            this.processSubMenuPanel.Size = new System.Drawing.Size(234, 73);
            this.processSubMenuPanel.TabIndex = 10;
            // 
            // rentManagerBtn
            // 
            this.rentManagerBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.rentManagerBtn.FlatAppearance.BorderSize = 0;
            this.rentManagerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rentManagerBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.rentManagerBtn.ForeColor = System.Drawing.Color.FloralWhite;
            this.rentManagerBtn.IconChar = FontAwesome.Sharp.IconChar.ChartPie;
            this.rentManagerBtn.IconColor = System.Drawing.Color.WhiteSmoke;
            this.rentManagerBtn.IconSize = 32;
            this.rentManagerBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rentManagerBtn.Location = new System.Drawing.Point(0, 38);
            this.rentManagerBtn.Name = "rentManagerBtn";
            this.rentManagerBtn.Padding = new System.Windows.Forms.Padding(35, 0, 20, 0);
            this.rentManagerBtn.Rotation = 0D;
            this.rentManagerBtn.Size = new System.Drawing.Size(234, 41);
            this.rentManagerBtn.TabIndex = 12;
            this.rentManagerBtn.Text = "Renta/Devoluccion";
            this.rentManagerBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rentManagerBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rentManagerBtn.UseVisualStyleBackColor = true;
            this.rentManagerBtn.Click += new System.EventHandler(this.RentManagerBtn_Click);
            // 
            // inspectorManagerBtn
            // 
            this.inspectorManagerBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.inspectorManagerBtn.FlatAppearance.BorderSize = 0;
            this.inspectorManagerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inspectorManagerBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.inspectorManagerBtn.ForeColor = System.Drawing.Color.FloralWhite;
            this.inspectorManagerBtn.IconChar = FontAwesome.Sharp.IconChar.ChartPie;
            this.inspectorManagerBtn.IconColor = System.Drawing.Color.WhiteSmoke;
            this.inspectorManagerBtn.IconSize = 32;
            this.inspectorManagerBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inspectorManagerBtn.Location = new System.Drawing.Point(0, 0);
            this.inspectorManagerBtn.Name = "inspectorManagerBtn";
            this.inspectorManagerBtn.Padding = new System.Windows.Forms.Padding(35, 0, 20, 0);
            this.inspectorManagerBtn.Rotation = 0D;
            this.inspectorManagerBtn.Size = new System.Drawing.Size(234, 38);
            this.inspectorManagerBtn.TabIndex = 11;
            this.inspectorManagerBtn.Text = "Inspecciones";
            this.inspectorManagerBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inspectorManagerBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.inspectorManagerBtn.UseVisualStyleBackColor = true;
            this.inspectorManagerBtn.Click += new System.EventHandler(this.InspectorManagerBtn_Click);
            // 
            // copyRights
            // 
            this.copyRights.AutoSize = true;
            this.copyRights.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.copyRights.LinkColor = System.Drawing.Color.White;
            this.copyRights.Location = new System.Drawing.Point(0, 547);
            this.copyRights.Name = "copyRights";
            this.copyRights.Size = new System.Drawing.Size(181, 16);
            this.copyRights.TabIndex = 9;
            this.copyRights.TabStop = true;
            this.copyRights.Text = "Alfredo Acosta 2018-1829";
            // 
            // processBtn
            // 
            this.processBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.processBtn.FlatAppearance.BorderSize = 0;
            this.processBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.processBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.processBtn.ForeColor = System.Drawing.Color.FloralWhite;
            this.processBtn.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.processBtn.IconColor = System.Drawing.Color.WhiteSmoke;
            this.processBtn.IconSize = 32;
            this.processBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.processBtn.Location = new System.Drawing.Point(0, 298);
            this.processBtn.Name = "processBtn";
            this.processBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.processBtn.Rotation = 0D;
            this.processBtn.Size = new System.Drawing.Size(234, 50);
            this.processBtn.TabIndex = 6;
            this.processBtn.Text = "Procesos";
            this.processBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.processBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.processBtn.UseVisualStyleBackColor = true;
            this.processBtn.Click += new System.EventHandler(this.ProcessBtn_Click);
            // 
            // gestiSubMenuPanel
            // 
            this.gestiSubMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(0)))), ((int)(((byte)(33)))));
            this.gestiSubMenuPanel.Controls.Add(this.CustomerManagerBtn);
            this.gestiSubMenuPanel.Controls.Add(this.employeeManagerBtn);
            this.gestiSubMenuPanel.Controls.Add(this.GeneralManagerBtn);
            this.gestiSubMenuPanel.Controls.Add(this.carManagerBtn);
            this.gestiSubMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.gestiSubMenuPanel.Location = new System.Drawing.Point(0, 150);
            this.gestiSubMenuPanel.Name = "gestiSubMenuPanel";
            this.gestiSubMenuPanel.Size = new System.Drawing.Size(234, 148);
            this.gestiSubMenuPanel.TabIndex = 5;
            // 
            // CustomerManagerBtn
            // 
            this.CustomerManagerBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.CustomerManagerBtn.FlatAppearance.BorderSize = 0;
            this.CustomerManagerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomerManagerBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.CustomerManagerBtn.ForeColor = System.Drawing.Color.FloralWhite;
            this.CustomerManagerBtn.IconChar = FontAwesome.Sharp.IconChar.ChartPie;
            this.CustomerManagerBtn.IconColor = System.Drawing.Color.WhiteSmoke;
            this.CustomerManagerBtn.IconSize = 32;
            this.CustomerManagerBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CustomerManagerBtn.Location = new System.Drawing.Point(0, 106);
            this.CustomerManagerBtn.Name = "CustomerManagerBtn";
            this.CustomerManagerBtn.Padding = new System.Windows.Forms.Padding(35, 0, 20, 0);
            this.CustomerManagerBtn.Rotation = 0D;
            this.CustomerManagerBtn.Size = new System.Drawing.Size(234, 42);
            this.CustomerManagerBtn.TabIndex = 11;
            this.CustomerManagerBtn.Text = "Clientes";
            this.CustomerManagerBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CustomerManagerBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CustomerManagerBtn.UseVisualStyleBackColor = true;
            this.CustomerManagerBtn.Click += new System.EventHandler(this.CustomerManagerBtn_Click);
            // 
            // employeeManagerBtn
            // 
            this.employeeManagerBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.employeeManagerBtn.FlatAppearance.BorderSize = 0;
            this.employeeManagerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeeManagerBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.employeeManagerBtn.ForeColor = System.Drawing.Color.FloralWhite;
            this.employeeManagerBtn.IconChar = FontAwesome.Sharp.IconChar.ChartPie;
            this.employeeManagerBtn.IconColor = System.Drawing.Color.WhiteSmoke;
            this.employeeManagerBtn.IconSize = 32;
            this.employeeManagerBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.employeeManagerBtn.Location = new System.Drawing.Point(0, 68);
            this.employeeManagerBtn.Name = "employeeManagerBtn";
            this.employeeManagerBtn.Padding = new System.Windows.Forms.Padding(35, 0, 20, 0);
            this.employeeManagerBtn.Rotation = 0D;
            this.employeeManagerBtn.Size = new System.Drawing.Size(234, 38);
            this.employeeManagerBtn.TabIndex = 10;
            this.employeeManagerBtn.Text = "Empleados";
            this.employeeManagerBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.employeeManagerBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.employeeManagerBtn.UseVisualStyleBackColor = true;
            this.employeeManagerBtn.Click += new System.EventHandler(this.EmployeeManagerBtn_Click);
            // 
            // GeneralManagerBtn
            // 
            this.GeneralManagerBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.GeneralManagerBtn.FlatAppearance.BorderSize = 0;
            this.GeneralManagerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GeneralManagerBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.GeneralManagerBtn.ForeColor = System.Drawing.Color.FloralWhite;
            this.GeneralManagerBtn.IconChar = FontAwesome.Sharp.IconChar.ChartPie;
            this.GeneralManagerBtn.IconColor = System.Drawing.Color.WhiteSmoke;
            this.GeneralManagerBtn.IconSize = 32;
            this.GeneralManagerBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GeneralManagerBtn.Location = new System.Drawing.Point(0, 34);
            this.GeneralManagerBtn.Name = "GeneralManagerBtn";
            this.GeneralManagerBtn.Padding = new System.Windows.Forms.Padding(35, 0, 20, 0);
            this.GeneralManagerBtn.Rotation = 0D;
            this.GeneralManagerBtn.Size = new System.Drawing.Size(234, 34);
            this.GeneralManagerBtn.TabIndex = 9;
            this.GeneralManagerBtn.Text = "Mantenimientos";
            this.GeneralManagerBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GeneralManagerBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GeneralManagerBtn.UseVisualStyleBackColor = true;
            this.GeneralManagerBtn.Click += new System.EventHandler(this.GeneralManagerBtn_Click);
            // 
            // carManagerBtn
            // 
            this.carManagerBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.carManagerBtn.FlatAppearance.BorderSize = 0;
            this.carManagerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carManagerBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.carManagerBtn.ForeColor = System.Drawing.Color.FloralWhite;
            this.carManagerBtn.IconChar = FontAwesome.Sharp.IconChar.ChartPie;
            this.carManagerBtn.IconColor = System.Drawing.Color.WhiteSmoke;
            this.carManagerBtn.IconSize = 32;
            this.carManagerBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.carManagerBtn.Location = new System.Drawing.Point(0, 0);
            this.carManagerBtn.Name = "carManagerBtn";
            this.carManagerBtn.Padding = new System.Windows.Forms.Padding(35, 0, 20, 0);
            this.carManagerBtn.Rotation = 0D;
            this.carManagerBtn.Size = new System.Drawing.Size(234, 34);
            this.carManagerBtn.TabIndex = 8;
            this.carManagerBtn.Text = "Vehiculos";
            this.carManagerBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.carManagerBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.carManagerBtn.UseVisualStyleBackColor = true;
            this.carManagerBtn.Click += new System.EventHandler(this.CarManagerBtn_Click);
            // 
            // gestiBtn
            // 
            this.gestiBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.gestiBtn.FlatAppearance.BorderSize = 0;
            this.gestiBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gestiBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.gestiBtn.ForeColor = System.Drawing.Color.FloralWhite;
            this.gestiBtn.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.gestiBtn.IconColor = System.Drawing.Color.WhiteSmoke;
            this.gestiBtn.IconSize = 32;
            this.gestiBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gestiBtn.Location = new System.Drawing.Point(0, 100);
            this.gestiBtn.Name = "gestiBtn";
            this.gestiBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.gestiBtn.Rotation = 0D;
            this.gestiBtn.Size = new System.Drawing.Size(234, 50);
            this.gestiBtn.TabIndex = 4;
            this.gestiBtn.Text = "Gestiones";
            this.gestiBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gestiBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.gestiBtn.UseVisualStyleBackColor = true;
            this.gestiBtn.Click += new System.EventHandler(this.GestiBtn_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.Controls.Add(this.appLogo);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(234, 100);
            this.logoPanel.TabIndex = 2;
            // 
            // appLogo
            // 
            this.appLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appLogo.Image = ((System.Drawing.Image)(resources.GetObject("appLogo.Image")));
            this.appLogo.Location = new System.Drawing.Point(0, 0);
            this.appLogo.Name = "appLogo";
            this.appLogo.Size = new System.Drawing.Size(234, 100);
            this.appLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.appLogo.TabIndex = 0;
            this.appLogo.TabStop = false;
            this.appLogo.Click += new System.EventHandler(this.AppLogo_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.panelContainer.Controls.Add(this.panelDash);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(234, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(738, 563);
            this.panelContainer.TabIndex = 2;
            // 
            // panelDash
            // 
            this.panelDash.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDash.Location = new System.Drawing.Point(6, 56);
            this.panelDash.Name = "panelDash";
            this.panelDash.Size = new System.Drawing.Size(720, 495);
            this.panelDash.TabIndex = 0;
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.titleBar.Controls.Add(this.userStatus);
            this.titleBar.Controls.Add(this.minimizeBtn);
            this.titleBar.Controls.Add(this.closeBtn);
            this.titleBar.Controls.Add(this.maximizeBtn);
            this.titleBar.Controls.Add(this.lblTitleChildForm);
            this.titleBar.Controls.Add(this.iconCurrentChildForm);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(234, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(738, 50);
            this.titleBar.TabIndex = 3;
            this.titleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            // 
            // userStatus
            // 
            this.userStatus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.userStatus.Controls.Add(this.iconPictureBox1);
            this.userStatus.Controls.Add(this.userName);
            this.userStatus.Location = new System.Drawing.Point(450, 3);
            this.userStatus.Name = "userStatus";
            this.userStatus.Size = new System.Drawing.Size(195, 32);
            this.userStatus.TabIndex = 8;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.iconPictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UniversalAccess;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 6;
            this.iconPictureBox1.TabStop = false;
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.userName.Location = new System.Drawing.Point(38, 10);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(42, 13);
            this.userName.TabIndex = 7;
            this.userName.Text = "LogOut";
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.minimizeBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.minimizeBtn.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.minimizeBtn.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.minimizeBtn.IconSize = 23;
            this.minimizeBtn.Location = new System.Drawing.Point(651, 3);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(24, 23);
            this.minimizeBtn.TabIndex = 5;
            this.minimizeBtn.TabStop = false;
            this.minimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click_1);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(0)))), ((int)(((byte)(33)))));
            this.closeBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.closeBtn.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.closeBtn.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.closeBtn.IconSize = 23;
            this.closeBtn.Location = new System.Drawing.Point(711, 3);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(24, 23);
            this.closeBtn.TabIndex = 4;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.CloseBtn_Click_1);
            // 
            // maximizeBtn
            // 
            this.maximizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.maximizeBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.maximizeBtn.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.maximizeBtn.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.maximizeBtn.IconSize = 23;
            this.maximizeBtn.Location = new System.Drawing.Point(681, 3);
            this.maximizeBtn.Name = "maximizeBtn";
            this.maximizeBtn.Size = new System.Drawing.Size(24, 23);
            this.maximizeBtn.TabIndex = 3;
            this.maximizeBtn.TabStop = false;
            this.maximizeBtn.Click += new System.EventHandler(this.MaximizeBtn_Click_1);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTitleChildForm.Location = new System.Drawing.Point(45, 22);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(0, 13);
            this.lblTitleChildForm.TabIndex = 2;
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(7, 13);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 563);
            this.ControlBox = false;
            this.Controls.Add(this.titleBar);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.menuPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "AppForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.adminSubMenuPanel.ResumeLayout(false);
            this.processSubMenuPanel.ResumeLayout(false);
            this.gestiSubMenuPanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.appLogo)).EndInit();
            this.panelContainer.ResumeLayout(false);
            this.titleBar.ResumeLayout(false);
            this.titleBar.PerformLayout();
            this.userStatus.ResumeLayout(false);
            this.userStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.PictureBox appLogo;
        private System.Windows.Forms.LinkLabel copyRights;
        private FontAwesome.Sharp.IconButton rentManagerBtn;
        private FontAwesome.Sharp.IconButton inspectorManagerBtn;
        private FontAwesome.Sharp.IconButton processBtn;
        private System.Windows.Forms.Panel gestiSubMenuPanel;
        private FontAwesome.Sharp.IconButton employeeManagerBtn;
        private FontAwesome.Sharp.IconButton GeneralManagerBtn;
        private FontAwesome.Sharp.IconButton carManagerBtn;
        private FontAwesome.Sharp.IconButton gestiBtn;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel titleBar;
        private FontAwesome.Sharp.IconPictureBox minimizeBtn;
        private FontAwesome.Sharp.IconPictureBox closeBtn;
        private FontAwesome.Sharp.IconPictureBox maximizeBtn;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label userName;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel userStatus;
        private System.Windows.Forms.Panel adminSubMenuPanel;
        private FontAwesome.Sharp.IconButton consultBtn;
        private FontAwesome.Sharp.IconButton reportBtn;
        private FontAwesome.Sharp.IconButton CustomerManagerBtn;
        private System.Windows.Forms.Panel processSubMenuPanel;
        private System.Windows.Forms.Panel panelDash;
    }
}

