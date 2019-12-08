namespace WindowsFormsApp1
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NumMini_Mau = new System.Windows.Forms.TextBox();
            this.NumMini_Tu = new System.Windows.Forms.TextBox();
            this.NumRMini_Mau = new System.Windows.Forms.TextBox();
            this.NumRMini_Tu = new System.Windows.Forms.TextBox();
            this.Num_int = new System.Windows.Forms.TextBox();
            this.Num_tu = new System.Windows.Forms.TextBox();
            this.Num_mau = new System.Windows.Forms.TextBox();
            this.NumR_Tu = new System.Windows.Forms.TextBox();
            this.NumR_Mau = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btntoigianphanso = new System.Windows.Forms.Button();
            this.btnhonso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tối giản phân số";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gold;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(320, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hỗn số ra phân số";
            // 
            // NumMini_Mau
            // 
            this.NumMini_Mau.Location = new System.Drawing.Point(12, 98);
            this.NumMini_Mau.Name = "NumMini_Mau";
            this.NumMini_Mau.Size = new System.Drawing.Size(55, 20);
            this.NumMini_Mau.TabIndex = 1;
            this.NumMini_Mau.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumMini_Mau.TextChanged += new System.EventHandler(this.NumMini_Mau_TextChanged);
            this.NumMini_Mau.Leave += new System.EventHandler(this.NumMini_Mau_Leave);
            // 
            // NumMini_Tu
            // 
            this.NumMini_Tu.Location = new System.Drawing.Point(12, 56);
            this.NumMini_Tu.Name = "NumMini_Tu";
            this.NumMini_Tu.Size = new System.Drawing.Size(55, 20);
            this.NumMini_Tu.TabIndex = 0;
            this.NumMini_Tu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NumRMini_Mau
            // 
            this.NumRMini_Mau.Location = new System.Drawing.Point(114, 96);
            this.NumRMini_Mau.Name = "NumRMini_Mau";
            this.NumRMini_Mau.Size = new System.Drawing.Size(55, 20);
            this.NumRMini_Mau.TabIndex = 10;
            // 
            // NumRMini_Tu
            // 
            this.NumRMini_Tu.Location = new System.Drawing.Point(114, 56);
            this.NumRMini_Tu.Name = "NumRMini_Tu";
            this.NumRMini_Tu.Size = new System.Drawing.Size(55, 20);
            this.NumRMini_Tu.TabIndex = 12;
            // 
            // Num_int
            // 
            this.Num_int.Location = new System.Drawing.Point(253, 70);
            this.Num_int.Name = "Num_int";
            this.Num_int.Size = new System.Drawing.Size(55, 20);
            this.Num_int.TabIndex = 18;
            this.Num_int.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Num_tu
            // 
            this.Num_tu.Location = new System.Drawing.Point(310, 49);
            this.Num_tu.Name = "Num_tu";
            this.Num_tu.Size = new System.Drawing.Size(55, 20);
            this.Num_tu.TabIndex = 19;
            this.Num_tu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Num_mau
            // 
            this.Num_mau.Location = new System.Drawing.Point(310, 98);
            this.Num_mau.Name = "Num_mau";
            this.Num_mau.Size = new System.Drawing.Size(55, 20);
            this.Num_mau.TabIndex = 20;
            this.Num_mau.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Num_mau.TextChanged += new System.EventHandler(this.Num_mau_TextChanged);
            this.Num_mau.Leave += new System.EventHandler(this.Num_mau_Leave);
            // 
            // NumR_Tu
            // 
            this.NumR_Tu.Location = new System.Drawing.Point(412, 49);
            this.NumR_Tu.Name = "NumR_Tu";
            this.NumR_Tu.Size = new System.Drawing.Size(55, 20);
            this.NumR_Tu.TabIndex = 21;
            this.NumR_Tu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NumR_Mau
            // 
            this.NumR_Mau.Location = new System.Drawing.Point(412, 98);
            this.NumR_Mau.Name = "NumR_Mau";
            this.NumR_Mau.Size = new System.Drawing.Size(55, 20);
            this.NumR_Mau.TabIndex = 22;
            this.NumR_Mau.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "----------";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(111, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 16);
            this.label8.TabIndex = 27;
            this.label8.Text = "----------";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(314, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 16);
            this.label11.TabIndex = 30;
            this.label11.Text = "---------";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(411, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 16);
            this.label12.TabIndex = 31;
            this.label12.Text = "----------";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btntoigianphanso
            // 
            this.btntoigianphanso.Enabled = false;
            this.btntoigianphanso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntoigianphanso.Location = new System.Drawing.Point(73, 77);
            this.btntoigianphanso.Name = "btntoigianphanso";
            this.btntoigianphanso.Size = new System.Drawing.Size(32, 23);
            this.btntoigianphanso.TabIndex = 32;
            this.btntoigianphanso.Text = "=";
            this.btntoigianphanso.UseVisualStyleBackColor = true;
            this.btntoigianphanso.Click += new System.EventHandler(this.btntoigianphanso_Click);
            // 
            // btnhonso
            // 
            this.btnhonso.Enabled = false;
            this.btnhonso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhonso.Location = new System.Drawing.Point(373, 72);
            this.btnhonso.Name = "btnhonso";
            this.btnhonso.Size = new System.Drawing.Size(32, 23);
            this.btnhonso.TabIndex = 34;
            this.btnhonso.Text = "=";
            this.btnhonso.UseVisualStyleBackColor = true;
            this.btnhonso.Click += new System.EventHandler(this.btnhonso_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(484, 158);
            this.Controls.Add(this.btnhonso);
            this.Controls.Add(this.btntoigianphanso);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NumR_Mau);
            this.Controls.Add(this.NumR_Tu);
            this.Controls.Add(this.Num_mau);
            this.Controls.Add(this.Num_tu);
            this.Controls.Add(this.Num_int);
            this.Controls.Add(this.NumRMini_Tu);
            this.Controls.Add(this.NumRMini_Mau);
            this.Controls.Add(this.NumMini_Tu);
            this.Controls.Add(this.NumMini_Mau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Mở Rộng";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NumMini_Mau;
        private System.Windows.Forms.TextBox NumMini_Tu;
        private System.Windows.Forms.TextBox NumRMini_Mau;
        private System.Windows.Forms.TextBox NumRMini_Tu;
        private System.Windows.Forms.TextBox Num_int;
        private System.Windows.Forms.TextBox Num_tu;
        private System.Windows.Forms.TextBox Num_mau;
        private System.Windows.Forms.TextBox NumR_Tu;
        private System.Windows.Forms.TextBox NumR_Mau;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btntoigianphanso;
        private System.Windows.Forms.Button btnhonso;
    }
}