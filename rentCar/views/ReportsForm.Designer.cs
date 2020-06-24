namespace rentCar.views.reportes
{
    partial class ReportsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.reportDV = new System.Windows.Forms.DataGridView();
            this.exportBtn = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.reportDV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(523, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Un Reporte de rentas: entre fechas, por tipo de vehículo, etc. ";
            // 
            // reportDV
            // 
            this.reportDV.AllowUserToAddRows = false;
            this.reportDV.AllowUserToDeleteRows = false;
            this.reportDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportDV.Location = new System.Drawing.Point(12, 63);
            this.reportDV.Name = "reportDV";
            this.reportDV.ReadOnly = true;
            this.reportDV.Size = new System.Drawing.Size(776, 375);
            this.reportDV.TabIndex = 1;
            // 
            // exportBtn
            // 
            this.exportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(0)))), ((int)(((byte)(39)))));
            this.exportBtn.FlatAppearance.BorderSize = 0;
            this.exportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.exportBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportBtn.ForeColor = System.Drawing.Color.White;
            this.exportBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.exportBtn.IconColor = System.Drawing.Color.Black;
            this.exportBtn.IconSize = 16;
            this.exportBtn.Location = new System.Drawing.Point(647, 9);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Rotation = 0D;
            this.exportBtn.Size = new System.Drawing.Size(140, 48);
            this.exportBtn.TabIndex = 2;
            this.exportBtn.Text = "Export to PDF";
            this.exportBtn.UseVisualStyleBackColor = false;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exportBtn);
            this.Controls.Add(this.reportDV);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportsForm";
            this.Text = "ReportsForm";
            ((System.ComponentModel.ISupportInitialize)(this.reportDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView reportDV;
        private FontAwesome.Sharp.IconButton exportBtn;
    }
}