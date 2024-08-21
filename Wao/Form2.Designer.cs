namespace Wao
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.serverAddBtn = new System.Windows.Forms.Button();
            this.minimiseBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.nameLbl = new System.Windows.Forms.Label();
            this.ipLbl = new System.Windows.Forms.Label();
            this.portLbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // serverAddBtn
            // 
            this.serverAddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(11)))), ((int)(((byte)(18)))));
            this.serverAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serverAddBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(123)))), ((int)(((byte)(224)))));
            this.serverAddBtn.Location = new System.Drawing.Point(70, 203);
            this.serverAddBtn.Name = "serverAddBtn";
            this.serverAddBtn.Size = new System.Drawing.Size(107, 23);
            this.serverAddBtn.TabIndex = 6;
            this.serverAddBtn.Text = "Add Server";
            this.serverAddBtn.UseVisualStyleBackColor = false;
            this.serverAddBtn.Click += new System.EventHandler(this.button5_Click);
            // 
            // minimiseBtn
            // 
            this.minimiseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(11)))), ((int)(((byte)(18)))));
            this.minimiseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimiseBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(123)))), ((int)(((byte)(224)))));
            this.minimiseBtn.Location = new System.Drawing.Point(178, 0);
            this.minimiseBtn.Name = "minimiseBtn";
            this.minimiseBtn.Size = new System.Drawing.Size(32, 23);
            this.minimiseBtn.TabIndex = 11;
            this.minimiseBtn.Text = "_";
            this.minimiseBtn.UseVisualStyleBackColor = false;
            this.minimiseBtn.Click += new System.EventHandler(this.button9_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(11)))), ((int)(((byte)(18)))));
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(123)))), ((int)(((byte)(224)))));
            this.exitBtn.Location = new System.Drawing.Point(211, 0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(32, 23);
            this.exitBtn.TabIndex = 10;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.button8_Click);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(123)))), ((int)(((byte)(224)))));
            this.nameLbl.Location = new System.Drawing.Point(12, 27);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(55, 20);
            this.nameLbl.TabIndex = 12;
            this.nameLbl.Text = "Name";
            // 
            // ipLbl
            // 
            this.ipLbl.AutoSize = true;
            this.ipLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.ipLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(123)))), ((int)(((byte)(224)))));
            this.ipLbl.Location = new System.Drawing.Point(12, 87);
            this.ipLbl.Name = "ipLbl";
            this.ipLbl.Size = new System.Drawing.Size(26, 20);
            this.ipLbl.TabIndex = 13;
            this.ipLbl.Text = "IP";
            // 
            // portLbl
            // 
            this.portLbl.AutoSize = true;
            this.portLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.portLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(123)))), ((int)(((byte)(224)))));
            this.portLbl.Location = new System.Drawing.Point(12, 147);
            this.portLbl.Name = "portLbl";
            this.portLbl.Size = new System.Drawing.Size(42, 20);
            this.portLbl.TabIndex = 14;
            this.portLbl.Text = "Port";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(11)))), ((int)(((byte)(18)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(123)))), ((int)(((byte)(224)))));
            this.textBox1.Location = new System.Drawing.Point(16, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 20);
            this.textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(11)))), ((int)(((byte)(18)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(123)))), ((int)(((byte)(224)))));
            this.textBox2.Location = new System.Drawing.Point(16, 110);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(207, 20);
            this.textBox2.TabIndex = 16;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(11)))), ((int)(((byte)(18)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(123)))), ((int)(((byte)(224)))));
            this.textBox3.Location = new System.Drawing.Point(16, 170);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(207, 20);
            this.textBox3.TabIndex = 17;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(246, 237);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.portLbl);
            this.Controls.Add(this.ipLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.minimiseBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.serverAddBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button serverAddBtn;
        private System.Windows.Forms.Button minimiseBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label ipLbl;
        private System.Windows.Forms.Label portLbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}