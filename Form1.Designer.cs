namespace Lab_10
{
    partial class FrmCompany
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGV = new System.Windows.Forms.DataGridView();
            this.LblHead = new System.Windows.Forms.Label();
            this.BtnAddEmp = new Lab_10.RoundedButton();
            this.button2 = new Lab_10.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV
            // 
            this.DGV.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(0, 100);
            this.DGV.Name = "DGV";
            this.DGV.RowTemplate.Height = 25;
            this.DGV.Size = new System.Drawing.Size(465, 366);
            this.DGV.TabIndex = 0;
            this.DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellContentClick);
            // 
            // LblHead
            // 
            this.LblHead.AutoSize = true;
            this.LblHead.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblHead.Location = new System.Drawing.Point(68, 21);
            this.LblHead.Name = "LblHead";
            this.LblHead.Size = new System.Drawing.Size(308, 54);
            this.LblHead.TabIndex = 1;
            this.LblHead.Text = "Employee Data";
            this.LblHead.Click += new System.EventHandler(this.LblHead_Click);
            // 
            // BtnAddEmp
            // 
            this.BtnAddEmp.BackColor = System.Drawing.Color.Green;
            this.BtnAddEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnAddEmp.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnAddEmp.FlatAppearance.BorderSize = 0;
            this.BtnAddEmp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAddEmp.Location = new System.Drawing.Point(54, 486);
            this.BtnAddEmp.Name = "BtnAddEmp";
            this.BtnAddEmp.Size = new System.Drawing.Size(113, 54);
            this.BtnAddEmp.TabIndex = 2;
            this.BtnAddEmp.Text = "Add New Employee";
            this.BtnAddEmp.UseVisualStyleBackColor = false;
            this.BtnAddEmp.Click += new System.EventHandler(this.BtnAddEmp_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(282, 487);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 53);
            this.button2.TabIndex = 3;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(465, 563);
            this.Controls.Add(this.LblHead);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.BtnAddEmp);
            this.Controls.Add(this.button2);
            this.Name = "FrmCompany";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Company";
            this.Load += new System.EventHandler(this.FrmCompany_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView DGV;
        private Label LblHead;
        private RoundedButton BtnAddEmp;
        private RoundedButton button2;
    }
}