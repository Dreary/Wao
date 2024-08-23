namespace Wao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.portLbl = new System.Windows.Forms.Label();
            this.ipLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.minimiseBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.serverEditBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPort
            // 
            this.txtPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(11)))), ((int)(((byte)(18)))));
            this.txtPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(123)))), ((int)(((byte)(224)))));
            this.txtPort.Location = new System.Drawing.Point(16, 170);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(207, 20);
            this.txtPort.TabIndex = 26;
            // 
            // txtIp
            // 
            this.txtIp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(11)))), ((int)(((byte)(18)))));
            this.txtIp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(123)))), ((int)(((byte)(224)))));
            this.txtIp.Location = new System.Drawing.Point(16, 110);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(207, 20);
            this.txtIp.TabIndex = 25;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(11)))), ((int)(((byte)(18)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(123)))), ((int)(((byte)(224)))));
            this.txtName.Location = new System.Drawing.Point(16, 51);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(207, 20);
            this.txtName.TabIndex = 24;
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
            this.portLbl.TabIndex = 23;
            this.portLbl.Text = "Port";
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
            this.ipLbl.TabIndex = 22;
            this.ipLbl.Text = "IP";
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
            this.nameLbl.TabIndex = 21;
            this.nameLbl.Text = "Name";
            // 
            // minimiseBtn
            // 
            this.minimiseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(11)))), ((int)(((byte)(18)))));
            this.minimiseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimiseBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(123)))), ((int)(((byte)(224)))));
            this.minimiseBtn.Location = new System.Drawing.Point(177, 2);
            this.minimiseBtn.Name = "minimiseBtn";
            this.minimiseBtn.Size = new System.Drawing.Size(32, 23);
            this.minimiseBtn.TabIndex = 20;
            this.minimiseBtn.Text = "_";
            this.minimiseBtn.UseVisualStyleBackColor = false;
            this.minimiseBtn.Click += new System.EventHandler(this.minimiseBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(11)))), ((int)(((byte)(18)))));
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(123)))), ((int)(((byte)(224)))));
            this.exitBtn.Location = new System.Drawing.Point(210, 2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(32, 23);
            this.exitBtn.TabIndex = 19;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // serverEditBtn
            // 
            this.serverEditBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(11)))), ((int)(((byte)(18)))));
            this.serverEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serverEditBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(123)))), ((int)(((byte)(224)))));
            this.serverEditBtn.Location = new System.Drawing.Point(70, 203);
            this.serverEditBtn.Name = "serverEditBtn";
            this.serverEditBtn.Size = new System.Drawing.Size(107, 23);
            this.serverEditBtn.TabIndex = 18;
            this.serverEditBtn.Text = "Edit Server";
            this.serverEditBtn.UseVisualStyleBackColor = false;
            this.serverEditBtn.Click += new System.EventHandler(this.serverEditBtn_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(246, 237);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtIp);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.portLbl);
            this.Controls.Add(this.ipLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.minimiseBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.serverEditBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wao - Edit Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label portLbl;
        private System.Windows.Forms.Label ipLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Button minimiseBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button serverEditBtn;
    }
}