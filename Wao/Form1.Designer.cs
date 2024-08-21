namespace Wao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serverListBox = new System.Windows.Forms.ListBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.launchBtn = new System.Windows.Forms.Button();
            this.setServerBtn = new System.Windows.Forms.Button();
            this.clientSelectBtn = new System.Windows.Forms.Button();
            this.clientPathBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.minimiseBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // serverListBox
            // 
            this.serverListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(11)))), ((int)(((byte)(18)))));
            this.serverListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serverListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(123)))), ((int)(((byte)(224)))));
            this.serverListBox.FormattingEnabled = true;
            this.serverListBox.ItemHeight = 16;
            this.serverListBox.Location = new System.Drawing.Point(4, 29);
            this.serverListBox.Name = "serverListBox";
            this.serverListBox.Size = new System.Drawing.Size(278, 98);
            this.serverListBox.TabIndex = 0;
            this.serverListBox.SelectedIndexChanged += new System.EventHandler(this.serverListBox_SelectedIndexChanged);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(11)))), ((int)(((byte)(18)))));
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(123)))), ((int)(((byte)(224)))));
            this.addBtn.Location = new System.Drawing.Point(4, 134);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(79, 23);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Add Server";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(11)))), ((int)(((byte)(18)))));
            this.removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(123)))), ((int)(((byte)(224)))));
            this.removeBtn.Location = new System.Drawing.Point(89, 134);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(92, 23);
            this.removeBtn.TabIndex = 2;
            this.removeBtn.Text = "Remove Server";
            this.removeBtn.UseVisualStyleBackColor = false;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // launchBtn
            // 
            this.launchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(11)))), ((int)(((byte)(18)))));
            this.launchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.launchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.launchBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(123)))), ((int)(((byte)(224)))));
            this.launchBtn.Location = new System.Drawing.Point(4, 163);
            this.launchBtn.Name = "launchBtn";
            this.launchBtn.Size = new System.Drawing.Size(393, 32);
            this.launchBtn.TabIndex = 3;
            this.launchBtn.Text = "Launch";
            this.launchBtn.UseVisualStyleBackColor = false;
            this.launchBtn.Click += new System.EventHandler(this.launchBtn_Click);
            // 
            // setServerBtn
            // 
            this.setServerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(11)))), ((int)(((byte)(18)))));
            this.setServerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setServerBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(123)))), ((int)(((byte)(224)))));
            this.setServerBtn.Location = new System.Drawing.Point(187, 134);
            this.setServerBtn.Name = "setServerBtn";
            this.setServerBtn.Size = new System.Drawing.Size(95, 23);
            this.setServerBtn.TabIndex = 4;
            this.setServerBtn.Text = "Set Server";
            this.setServerBtn.UseVisualStyleBackColor = false;
            this.setServerBtn.Click += new System.EventHandler(this.setServerBtn_Click);
            // 
            // clientSelectBtn
            // 
            this.clientSelectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(11)))), ((int)(((byte)(18)))));
            this.clientSelectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientSelectBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(123)))), ((int)(((byte)(224)))));
            this.clientSelectBtn.Location = new System.Drawing.Point(290, 29);
            this.clientSelectBtn.Name = "clientSelectBtn";
            this.clientSelectBtn.Size = new System.Drawing.Size(107, 48);
            this.clientSelectBtn.TabIndex = 5;
            this.clientSelectBtn.Text = "Select MS2 client folder";
            this.clientSelectBtn.UseVisualStyleBackColor = false;
            this.clientSelectBtn.Click += new System.EventHandler(this.clientSelectBtn_Click);
            // 
            // clientPathBtn
            // 
            this.clientPathBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(11)))), ((int)(((byte)(18)))));
            this.clientPathBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientPathBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(123)))), ((int)(((byte)(224)))));
            this.clientPathBtn.Location = new System.Drawing.Point(290, 83);
            this.clientPathBtn.Name = "clientPathBtn";
            this.clientPathBtn.Size = new System.Drawing.Size(107, 44);
            this.clientPathBtn.TabIndex = 6;
            this.clientPathBtn.Text = "Open Client Path";
            this.clientPathBtn.UseVisualStyleBackColor = false;
            this.clientPathBtn.Click += new System.EventHandler(this.clientPathBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(11)))), ((int)(((byte)(18)))));
            this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(123)))), ((int)(((byte)(224)))));
            this.refreshBtn.Location = new System.Drawing.Point(288, 134);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(109, 23);
            this.refreshBtn.TabIndex = 7;
            this.refreshBtn.Text = "Refresh Server List";
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(11)))), ((int)(((byte)(18)))));
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(123)))), ((int)(((byte)(224)))));
            this.exitBtn.Location = new System.Drawing.Point(365, 1);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(32, 23);
            this.exitBtn.TabIndex = 8;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // minimiseBtn
            // 
            this.minimiseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(11)))), ((int)(((byte)(18)))));
            this.minimiseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimiseBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(123)))), ((int)(((byte)(224)))));
            this.minimiseBtn.Location = new System.Drawing.Point(332, 1);
            this.minimiseBtn.Name = "minimiseBtn";
            this.minimiseBtn.Size = new System.Drawing.Size(32, 23);
            this.minimiseBtn.TabIndex = 9;
            this.minimiseBtn.Text = "_";
            this.minimiseBtn.UseVisualStyleBackColor = false;
            this.minimiseBtn.Click += new System.EventHandler(this.minimiseBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(123)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(2, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Wao";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(401, 200);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minimiseBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.clientPathBtn);
            this.Controls.Add(this.clientSelectBtn);
            this.Controls.Add(this.setServerBtn);
            this.Controls.Add(this.launchBtn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.serverListBox);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox serverListBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button launchBtn;
        private System.Windows.Forms.Button setServerBtn;
        private System.Windows.Forms.Button clientSelectBtn;
        private System.Windows.Forms.Button clientPathBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button minimiseBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

