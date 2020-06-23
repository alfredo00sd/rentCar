namespace rentCar.views.car
{
    partial class CarMantView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.helpBtn = new FontAwesome.Sharp.IconButton();
            this.refreshBtn = new FontAwesome.Sharp.IconButton();
            this.label16 = new System.Windows.Forms.Label();
            this.viewTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CarFabYearCB = new System.Windows.Forms.ComboBox();
            this.CarPhoto = new System.Windows.Forms.PictureBox();
            this.useInKm = new System.Windows.Forms.NumericUpDown();
            this.colorContainer = new System.Windows.Forms.TextBox();
            this.colorPicker = new FontAwesome.Sharp.IconButton();
            this.SaveCarBtn = new FontAwesome.Sharp.IconButton();
            this.commentBox = new System.Windows.Forms.TextBox();
            this.placaInput = new System.Windows.Forms.TextBox();
            this.motorNoInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.chasisNoInput = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cantPuertas = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cantPasajeros = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CarCondition = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CarBrandCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CarModelCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FuelTypeCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CarTypeCB = new System.Windows.Forms.ComboBox();
            this.carDV = new System.Windows.Forms.DataGridView();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.carStatsCheck = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.useInKm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(0)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.helpBtn);
            this.panel1.Controls.Add(this.refreshBtn);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.viewTitle);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1075, 491);
            this.panel1.TabIndex = 0;
            // 
            // helpBtn
            // 
            this.helpBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.helpBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.helpBtn.IconColor = System.Drawing.Color.Black;
            this.helpBtn.IconSize = 16;
            this.helpBtn.Location = new System.Drawing.Point(928, 6);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Rotation = 0D;
            this.helpBtn.Size = new System.Drawing.Size(53, 23);
            this.helpBtn.TabIndex = 11;
            this.helpBtn.Text = "Help ?";
            this.helpBtn.UseVisualStyleBackColor = true;
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.refreshBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.refreshBtn.IconColor = System.Drawing.Color.Black;
            this.refreshBtn.IconSize = 16;
            this.refreshBtn.Location = new System.Drawing.Point(1007, 6);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Rotation = 0D;
            this.refreshBtn.Size = new System.Drawing.Size(53, 23);
            this.refreshBtn.TabIndex = 10;
            this.refreshBtn.Text = "Reload";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(214, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(101, 23);
            this.label16.TabIndex = 9;
            this.label16.Text = "vehiculo";
            // 
            // viewTitle
            // 
            this.viewTitle.AutoSize = true;
            this.viewTitle.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewTitle.ForeColor = System.Drawing.Color.White;
            this.viewTitle.Location = new System.Drawing.Point(12, 9);
            this.viewTitle.Name = "viewTitle";
            this.viewTitle.Size = new System.Drawing.Size(214, 23);
            this.viewTitle.TabIndex = 8;
            this.viewTitle.Text = "Mantenimiento de ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.panel2.Controls.Add(this.splitContainer1);
            this.panel2.Location = new System.Drawing.Point(12, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1048, 438);
            this.panel2.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.carStatsCheck);
            this.splitContainer1.Panel1.Controls.Add(this.label15);
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.splitContainer1.Panel1.Controls.Add(this.CarFabYearCB);
            this.splitContainer1.Panel1.Controls.Add(this.CarPhoto);
            this.splitContainer1.Panel1.Controls.Add(this.useInKm);
            this.splitContainer1.Panel1.Controls.Add(this.colorContainer);
            this.splitContainer1.Panel1.Controls.Add(this.colorPicker);
            this.splitContainer1.Panel1.Controls.Add(this.SaveCarBtn);
            this.splitContainer1.Panel1.Controls.Add(this.commentBox);
            this.splitContainer1.Panel1.Controls.Add(this.placaInput);
            this.splitContainer1.Panel1.Controls.Add(this.motorNoInput);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.iconButton1);
            this.splitContainer1.Panel1.Controls.Add(this.chasisNoInput);
            this.splitContainer1.Panel1.Controls.Add(this.label14);
            this.splitContainer1.Panel1.Controls.Add(this.label13);
            this.splitContainer1.Panel1.Controls.Add(this.label12);
            this.splitContainer1.Panel1.Controls.Add(this.cantPuertas);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.cantPasajeros);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.CarCondition);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.CarBrandCB);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.CarModelCB);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.FuelTypeCB);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.CarTypeCB);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.carDV);
            this.splitContainer1.Size = new System.Drawing.Size(1048, 438);
            this.splitContainer1.SplitterDistance = 227;
            this.splitContainer1.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(12, 181);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(122, 16);
            this.label15.TabIndex = 104;
            this.label15.Text = "Busqueda por.: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(134, 183);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(272, 14);
            this.label11.TabIndex = 103;
            this.label11.Text = "marca, modelo, placa, chasis, motor o año";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 198);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(406, 20);
            this.textBox1.TabIndex = 102;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CarFabYearCB
            // 
            this.CarFabYearCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CarFabYearCB.FormattingEnabled = true;
            this.CarFabYearCB.Items.AddRange(new object[] {
            "2022",
            "2021",
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990",
            "1989",
            "1988",
            "1987",
            "1986",
            "1985",
            "1984",
            "1983",
            "1982",
            "1981",
            "1980"});
            this.CarFabYearCB.Location = new System.Drawing.Point(283, 152);
            this.CarFabYearCB.Name = "CarFabYearCB";
            this.CarFabYearCB.Size = new System.Drawing.Size(138, 21);
            this.CarFabYearCB.TabIndex = 101;
            // 
            // CarPhoto
            // 
            this.CarPhoto.Location = new System.Drawing.Point(798, 15);
            this.CarPhoto.Name = "CarPhoto";
            this.CarPhoto.Size = new System.Drawing.Size(228, 95);
            this.CarPhoto.TabIndex = 98;
            this.CarPhoto.TabStop = false;
            // 
            // useInKm
            // 
            this.useInKm.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.useInKm.Location = new System.Drawing.Point(679, 95);
            this.useInKm.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.useInKm.Name = "useInKm";
            this.useInKm.Size = new System.Drawing.Size(103, 20);
            this.useInKm.TabIndex = 96;
            this.useInKm.ThousandsSeparator = true;
            // 
            // colorContainer
            // 
            this.colorContainer.Location = new System.Drawing.Point(796, 144);
            this.colorContainer.MaxLength = 80;
            this.colorContainer.Name = "colorContainer";
            this.colorContainer.ReadOnly = true;
            this.colorContainer.Size = new System.Drawing.Size(101, 20);
            this.colorContainer.TabIndex = 94;
            // 
            // colorPicker
            // 
            this.colorPicker.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.colorPicker.IconChar = FontAwesome.Sharp.IconChar.None;
            this.colorPicker.IconColor = System.Drawing.Color.Black;
            this.colorPicker.IconSize = 16;
            this.colorPicker.Location = new System.Drawing.Point(796, 116);
            this.colorPicker.Name = "colorPicker";
            this.colorPicker.Rotation = 0D;
            this.colorPicker.Size = new System.Drawing.Size(101, 20);
            this.colorPicker.TabIndex = 91;
            this.colorPicker.Text = "Color";
            this.colorPicker.UseVisualStyleBackColor = true;
            this.colorPicker.Click += new System.EventHandler(this.colorPicker_Click);
            // 
            // SaveCarBtn
            // 
            this.SaveCarBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.SaveCarBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SaveCarBtn.IconColor = System.Drawing.Color.Black;
            this.SaveCarBtn.IconSize = 16;
            this.SaveCarBtn.Location = new System.Drawing.Point(798, 185);
            this.SaveCarBtn.Name = "SaveCarBtn";
            this.SaveCarBtn.Rotation = 0D;
            this.SaveCarBtn.Size = new System.Drawing.Size(228, 33);
            this.SaveCarBtn.TabIndex = 90;
            this.SaveCarBtn.Text = "Agregar nuevo";
            this.SaveCarBtn.UseVisualStyleBackColor = true;
            this.SaveCarBtn.Click += new System.EventHandler(this.SaveCarBtn_Click);
            // 
            // commentBox
            // 
            this.commentBox.Location = new System.Drawing.Point(427, 151);
            this.commentBox.MaxLength = 200;
            this.commentBox.Multiline = true;
            this.commentBox.Name = "commentBox";
            this.commentBox.Size = new System.Drawing.Size(275, 67);
            this.commentBox.TabIndex = 89;
            // 
            // placaInput
            // 
            this.placaInput.Location = new System.Drawing.Point(14, 95);
            this.placaInput.MaxLength = 15;
            this.placaInput.Name = "placaInput";
            this.placaInput.Size = new System.Drawing.Size(161, 20);
            this.placaInput.TabIndex = 88;
            // 
            // motorNoInput
            // 
            this.motorNoInput.Location = new System.Drawing.Point(410, 95);
            this.motorNoInput.MaxLength = 40;
            this.motorNoInput.Name = "motorNoInput";
            this.motorNoInput.Size = new System.Drawing.Size(263, 20);
            this.motorNoInput.TabIndex = 87;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(281, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 16);
            this.label5.TabIndex = 100;
            this.label5.Text = "Año del vehiculo";
            // 
            // iconButton1
            // 
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconSize = 16;
            this.iconButton1.Location = new System.Drawing.Point(903, 117);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(123, 48);
            this.iconButton1.TabIndex = 99;
            this.iconButton1.Text = "Agregar imagen";
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // chasisNoInput
            // 
            this.chasisNoInput.Location = new System.Drawing.Point(181, 95);
            this.chasisNoInput.MaxLength = 17;
            this.chasisNoInput.Name = "chasisNoInput";
            this.chasisNoInput.Size = new System.Drawing.Size(223, 20);
            this.chasisNoInput.TabIndex = 86;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(424, 132);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 16);
            this.label14.TabIndex = 85;
            this.label14.Text = "Comentario";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(675, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 16);
            this.label13.TabIndex = 84;
            this.label13.Text = "Uso en km";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(12, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 16);
            this.label12.TabIndex = 83;
            this.label12.Text = "Placa";
            // 
            // cantPuertas
            // 
            this.cantPuertas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cantPuertas.FormattingEnabled = true;
            this.cantPuertas.Items.AddRange(new object[] {
            "2",
            "4",
            "6"});
            this.cantPuertas.Location = new System.Drawing.Point(14, 152);
            this.cantPuertas.Name = "cantPuertas";
            this.cantPuertas.Size = new System.Drawing.Size(105, 21);
            this.cantPuertas.TabIndex = 82;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(12, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 16);
            this.label10.TabIndex = 81;
            this.label10.Text = "Cant. puertas";
            // 
            // cantPasajeros
            // 
            this.cantPasajeros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cantPasajeros.FormattingEnabled = true;
            this.cantPasajeros.Items.AddRange(new object[] {
            "2",
            "6",
            "7"});
            this.cantPasajeros.Location = new System.Drawing.Point(142, 152);
            this.cantPasajeros.Name = "cantPasajeros";
            this.cantPasajeros.Size = new System.Drawing.Size(120, 21);
            this.cantPasajeros.TabIndex = 80;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(139, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 16);
            this.label9.TabIndex = 79;
            this.label9.Text = "Cant. pasajeros";
            // 
            // CarCondition
            // 
            this.CarCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CarCondition.FormattingEnabled = true;
            this.CarCondition.Items.AddRange(new object[] {
            "Nuevo",
            "Usado"});
            this.CarCondition.Location = new System.Drawing.Point(679, 34);
            this.CarCondition.Name = "CarCondition";
            this.CarCondition.Size = new System.Drawing.Size(103, 21);
            this.CarCondition.TabIndex = 78;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(676, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 16);
            this.label8.TabIndex = 77;
            this.label8.Text = "Condiciones";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(407, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 76;
            this.label7.Text = "Motor No.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(178, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 75;
            this.label6.Text = "Chasis No.";
            // 
            // CarBrandCB
            // 
            this.CarBrandCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CarBrandCB.FormattingEnabled = true;
            this.CarBrandCB.Location = new System.Drawing.Point(181, 34);
            this.CarBrandCB.Name = "CarBrandCB";
            this.CarBrandCB.Size = new System.Drawing.Size(160, 21);
            this.CarBrandCB.TabIndex = 74;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(178, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 73;
            this.label4.Text = "Marca";
            // 
            // CarModelCB
            // 
            this.CarModelCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CarModelCB.FormattingEnabled = true;
            this.CarModelCB.Location = new System.Drawing.Point(347, 34);
            this.CarModelCB.Name = "CarModelCB";
            this.CarModelCB.Size = new System.Drawing.Size(160, 21);
            this.CarModelCB.TabIndex = 72;
            this.CarModelCB.Enter += new System.EventHandler(this.CarBrandCB_Leaves);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(510, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 16);
            this.label2.TabIndex = 69;
            this.label2.Text = "Tipo de combustible";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(344, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 71;
            this.label3.Text = "Modelo";
            // 
            // FuelTypeCB
            // 
            this.FuelTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FuelTypeCB.FormattingEnabled = true;
            this.FuelTypeCB.Location = new System.Drawing.Point(513, 34);
            this.FuelTypeCB.Name = "FuelTypeCB";
            this.FuelTypeCB.Size = new System.Drawing.Size(160, 21);
            this.FuelTypeCB.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 67;
            this.label1.Text = "Tipo de carro";
            // 
            // CarTypeCB
            // 
            this.CarTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CarTypeCB.FormattingEnabled = true;
            this.CarTypeCB.Location = new System.Drawing.Point(15, 34);
            this.CarTypeCB.Name = "CarTypeCB";
            this.CarTypeCB.Size = new System.Drawing.Size(160, 21);
            this.CarTypeCB.TabIndex = 68;
            // 
            // carDV
            // 
            this.carDV.AllowUserToAddRows = false;
            this.carDV.AllowUserToDeleteRows = false;
            this.carDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.carDV.Location = new System.Drawing.Point(0, 0);
            this.carDV.Name = "carDV";
            this.carDV.ReadOnly = true;
            this.carDV.Size = new System.Drawing.Size(1048, 207);
            this.carDV.TabIndex = 0;
            this.carDV.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.carDV_CellMouseDoubleClick);
            // 
            // carStatsCheck
            // 
            this.carStatsCheck.AutoSize = true;
            this.carStatsCheck.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carStatsCheck.ForeColor = System.Drawing.Color.White;
            this.carStatsCheck.Location = new System.Drawing.Point(708, 151);
            this.carStatsCheck.Name = "carStatsCheck";
            this.carStatsCheck.Size = new System.Drawing.Size(74, 18);
            this.carStatsCheck.TabIndex = 105;
            this.carStatsCheck.Text = "Estatus";
            this.carStatsCheck.UseVisualStyleBackColor = true;
            // 
            // CarMantView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 491);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Name = "CarMantView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CarPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.useInKm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label viewTitle;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox CarFabYearCB;
        private System.Windows.Forms.PictureBox CarPhoto;
        private System.Windows.Forms.NumericUpDown useInKm;
        private System.Windows.Forms.TextBox colorContainer;
        private FontAwesome.Sharp.IconButton colorPicker;
        private FontAwesome.Sharp.IconButton SaveCarBtn;
        private System.Windows.Forms.TextBox commentBox;
        private System.Windows.Forms.TextBox placaInput;
        private System.Windows.Forms.TextBox motorNoInput;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TextBox chasisNoInput;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cantPuertas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cantPasajeros;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CarCondition;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CarBrandCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CarModelCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox FuelTypeCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CarTypeCB;
        private System.Windows.Forms.DataGridView carDV;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private FontAwesome.Sharp.IconButton refreshBtn;
        private FontAwesome.Sharp.IconButton helpBtn;
        private System.Windows.Forms.CheckBox carStatsCheck;
    }
}