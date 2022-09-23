namespace Lab_10
{
    partial class FrmAddEmp
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
            this.TxtFname = new System.Windows.Forms.TextBox();
            this.TxtSsn = new System.Windows.Forms.TextBox();
            this.TxtLname = new System.Windows.Forms.TextBox();
            this.TxtSalary = new System.Windows.Forms.TextBox();
            this.LblFname = new System.Windows.Forms.Label();
            this.LblHead = new System.Windows.Forms.Label();
            this.LblLname = new System.Windows.Forms.Label();
            this.LblSsn = new System.Windows.Forms.Label();
            this.LblSalary = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.LblGender = new System.Windows.Forms.Label();
            this.TxtGender = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtFname
            // 
            this.TxtFname.Location = new System.Drawing.Point(193, 137);
            this.TxtFname.Name = "TxtFname";
            this.TxtFname.Size = new System.Drawing.Size(174, 23);
            this.TxtFname.TabIndex = 0;
            this.TxtFname.TextChanged += new System.EventHandler(this.TxtFname_TextChanged);
            // 
            // TxtSsn
            // 
            this.TxtSsn.Location = new System.Drawing.Point(193, 226);
            this.TxtSsn.Name = "TxtSsn";
            this.TxtSsn.Size = new System.Drawing.Size(174, 23);
            this.TxtSsn.TabIndex = 1;
            this.TxtSsn.TextChanged += new System.EventHandler(this.TxtSsn_TextChanged);
            // 
            // TxtLname
            // 
            this.TxtLname.Location = new System.Drawing.Point(193, 182);
            this.TxtLname.Name = "TxtLname";
            this.TxtLname.Size = new System.Drawing.Size(174, 23);
            this.TxtLname.TabIndex = 2;
            this.TxtLname.TextChanged += new System.EventHandler(this.TxtLname_TextChanged);
            // 
            // TxtSalary
            // 
            this.TxtSalary.Location = new System.Drawing.Point(193, 277);
            this.TxtSalary.Name = "TxtSalary";
            this.TxtSalary.Size = new System.Drawing.Size(174, 23);
            this.TxtSalary.TabIndex = 3;
            this.TxtSalary.TextChanged += new System.EventHandler(this.TxtSalary_TextChanged);
            // 
            // LblFname
            // 
            this.LblFname.AutoSize = true;
            this.LblFname.BackColor = System.Drawing.Color.LawnGreen;
            this.LblFname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblFname.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblFname.Location = new System.Drawing.Point(31, 134);
            this.LblFname.Name = "LblFname";
            this.LblFname.Size = new System.Drawing.Size(120, 26);
            this.LblFname.TabIndex = 4;
            this.LblFname.Text = "First Name";
            this.LblFname.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblHead
            // 
            this.LblHead.AutoSize = true;
            this.LblHead.BackColor = System.Drawing.Color.NavajoWhite;
            this.LblHead.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblHead.Location = new System.Drawing.Point(54, 21);
            this.LblHead.Name = "LblHead";
            this.LblHead.Size = new System.Drawing.Size(294, 46);
            this.LblHead.TabIndex = 8;
            this.LblHead.Text = "Add Employee";
            // 
            // LblLname
            // 
            this.LblLname.AutoSize = true;
            this.LblLname.BackColor = System.Drawing.Color.LawnGreen;
            this.LblLname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblLname.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblLname.Location = new System.Drawing.Point(32, 179);
            this.LblLname.Name = "LblLname";
            this.LblLname.Size = new System.Drawing.Size(119, 26);
            this.LblLname.TabIndex = 9;
            this.LblLname.Text = "Last Name";
            this.LblLname.Click += new System.EventHandler(this.label2_Click);
            // 
            // LblSsn
            // 
            this.LblSsn.AutoSize = true;
            this.LblSsn.BackColor = System.Drawing.Color.LawnGreen;
            this.LblSsn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblSsn.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblSsn.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.LblSsn.Location = new System.Drawing.Point(33, 221);
            this.LblSsn.Name = "LblSsn";
            this.LblSsn.Size = new System.Drawing.Size(120, 31);
            this.LblSsn.TabIndex = 10;
            this.LblSsn.Text = "      SSN      ";
            this.LblSsn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblSsn.UseCompatibleTextRendering = true;
            this.LblSsn.Click += new System.EventHandler(this.LblSsn_Click);
            // 
            // LblSalary
            // 
            this.LblSalary.AutoSize = true;
            this.LblSalary.BackColor = System.Drawing.Color.LawnGreen;
            this.LblSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblSalary.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblSalary.Location = new System.Drawing.Point(32, 277);
            this.LblSalary.Name = "LblSalary";
            this.LblSalary.Size = new System.Drawing.Size(122, 26);
            this.LblSalary.TabIndex = 11;
            this.LblSalary.Text = "    Salary    ";
            this.LblSalary.Click += new System.EventHandler(this.LblSalary_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnSave.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSave.Location = new System.Drawing.Point(32, 431);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(100, 42);
            this.BtnSave.TabIndex = 12;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.LightYellow;
            this.BtnClear.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnClear.Location = new System.Drawing.Point(162, 431);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(85, 42);
            this.BtnClear.TabIndex = 13;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Red;
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnClose.Location = new System.Drawing.Point(263, 431);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(85, 42);
            this.BtnClose.TabIndex = 14;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // LblGender
            // 
            this.LblGender.AutoSize = true;
            this.LblGender.BackColor = System.Drawing.Color.LawnGreen;
            this.LblGender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblGender.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblGender.Location = new System.Drawing.Point(33, 331);
            this.LblGender.Name = "LblGender";
            this.LblGender.Size = new System.Drawing.Size(122, 26);
            this.LblGender.TabIndex = 15;
            this.LblGender.Text = "   Gender   ";
            // 
            // TxtGender
            // 
            this.TxtGender.Location = new System.Drawing.Point(193, 331);
            this.TxtGender.Name = "TxtGender";
            this.TxtGender.Size = new System.Drawing.Size(174, 23);
            this.TxtGender.TabIndex = 16;
            this.TxtGender.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FrmAddEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(401, 485);
            this.Controls.Add(this.TxtGender);
            this.Controls.Add(this.LblGender);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.LblSalary);
            this.Controls.Add(this.LblSsn);
            this.Controls.Add(this.LblLname);
            this.Controls.Add(this.LblHead);
            this.Controls.Add(this.LblFname);
            this.Controls.Add(this.TxtSalary);
            this.Controls.Add(this.TxtLname);
            this.Controls.Add(this.TxtSsn);
            this.Controls.Add(this.TxtFname);
            this.Name = "FrmAddEmp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TxtFname;
        private TextBox TxtSsn;
        private TextBox TxtLname;
        private TextBox TxtSalary;
        private Label LblFname;
        private Label LblHead;
        private Label LblLname;
        private Label LblSsn;
        private Label LblSalary;
        private Button BtnSave;
        private Button BtnClear;
        private Button BtnClose;
        private Label LblGender;
        private TextBox TxtGender;
    }
}