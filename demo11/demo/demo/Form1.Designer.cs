namespace demo
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btndiv = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMutipl = new System.Windows.Forms.Button();
            this.btnresult = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnInputfiles = new System.Windows.Forms.Button();
            this.txtInputfile = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(469, 461);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 53);
            this.button1.TabIndex = 1;
            this.button1.Text = "Phan So";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(942, 403);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 26);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Pink;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(469, 403);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 48);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btndiv
            // 
            this.btndiv.BackColor = System.Drawing.Color.Pink;
            this.btndiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndiv.Location = new System.Drawing.Point(765, 403);
            this.btndiv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(112, 48);
            this.btndiv.TabIndex = 4;
            this.btndiv.Text = "/";
            this.btndiv.UseVisualStyleBackColor = false;
            this.btndiv.Click += new System.EventHandler(this.btndiv_Click);
            // 
            // btnSub
            // 
            this.btnSub.BackColor = System.Drawing.Color.Pink;
            this.btnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.Location = new System.Drawing.Point(617, 403);
            this.btnSub.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(112, 48);
            this.btnSub.TabIndex = 5;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = false;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnMutipl
            // 
            this.btnMutipl.BackColor = System.Drawing.Color.Pink;
            this.btnMutipl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMutipl.Location = new System.Drawing.Point(617, 461);
            this.btnMutipl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMutipl.Name = "btnMutipl";
            this.btnMutipl.Size = new System.Drawing.Size(112, 53);
            this.btnMutipl.TabIndex = 6;
            this.btnMutipl.Text = "*";
            this.btnMutipl.UseVisualStyleBackColor = false;
            this.btnMutipl.Click += new System.EventHandler(this.btnMutipl_Click);
            // 
            // btnresult
            // 
            this.btnresult.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresult.Location = new System.Drawing.Point(765, 461);
            this.btnresult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnresult.Name = "btnresult";
            this.btnresult.Size = new System.Drawing.Size(112, 53);
            this.btnresult.TabIndex = 7;
            this.btnresult.Text = "=";
            this.btnresult.UseVisualStyleBackColor = false;
            this.btnresult.Click += new System.EventHandler(this.btnresult_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(942, 483);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(148, 26);
            this.textBox2.TabIndex = 8;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(942, 439);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 35);
            this.label1.TabIndex = 9;
            this.label1.Text = "----------";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Red;
            this.btnClear.Location = new System.Drawing.Point(1144, 438);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 53);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "AC";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnInputfiles
            // 
            this.btnInputfiles.BackColor = System.Drawing.Color.Green;
            this.btnInputfiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInputfiles.ForeColor = System.Drawing.Color.Yellow;
            this.btnInputfiles.Location = new System.Drawing.Point(22, 421);
            this.btnInputfiles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInputfiles.Name = "btnInputfiles";
            this.btnInputfiles.Size = new System.Drawing.Size(134, 88);
            this.btnInputfiles.TabIndex = 11;
            this.btnInputfiles.Text = "Open Files";
            this.btnInputfiles.UseVisualStyleBackColor = false;
            this.btnInputfiles.Click += new System.EventHandler(this.btnInputfiles_Click);
            // 
            // txtInputfile
            // 
            this.txtInputfile.Location = new System.Drawing.Point(177, 406);
            this.txtInputfile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInputfile.Multiline = true;
            this.txtInputfile.Name = "txtInputfile";
            this.txtInputfile.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInputfile.Size = new System.Drawing.Size(250, 109);
            this.txtInputfile.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1295, 543);
            this.Controls.Add(this.txtInputfile);
            this.Controls.Add(this.btnInputfiles);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnresult);
            this.Controls.Add(this.btnMutipl);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btndiv);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Chuong Trinh Phan So";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btndiv;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMutipl;
        private System.Windows.Forms.Button btnresult;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnInputfiles;
        private System.Windows.Forms.TextBox txtInputfile;
    }
}

