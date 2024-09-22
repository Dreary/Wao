namespace Wao
{
    partial class formLaunchOption
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
            this.btnLaunch = new System.Windows.Forms.Button();
            this.radioSync = new System.Windows.Forms.RadioButton();
            this.radioAsync = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.minimiseBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLaunch
            // 
            this.btnLaunch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(11)))), ((int)(((byte)(18)))));
            this.btnLaunch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaunch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(123)))), ((int)(((byte)(224)))));
            this.btnLaunch.Location = new System.Drawing.Point(67, 86);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(87, 39);
            this.btnLaunch.TabIndex = 29;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.UseVisualStyleBackColor = false;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // radioSync
            // 
            this.radioSync.AutoSize = true;
            this.radioSync.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioSync.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(123)))), ((int)(((byte)(224)))));
            this.radioSync.Location = new System.Drawing.Point(25, 60);
            this.radioSync.Name = "radioSync";
            this.radioSync.Size = new System.Drawing.Size(180, 17);
            this.radioSync.TabIndex = 28;
            this.radioSync.Text = "Sync   - Less Resources (Slower)";
            this.radioSync.UseVisualStyleBackColor = true;
            // 
            // radioAsync
            // 
            this.radioAsync.AutoSize = true;
            this.radioAsync.Checked = true;
            this.radioAsync.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioAsync.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(123)))), ((int)(((byte)(224)))));
            this.radioAsync.Location = new System.Drawing.Point(25, 37);
            this.radioAsync.Name = "radioAsync";
            this.radioAsync.Size = new System.Drawing.Size(180, 17);
            this.radioAsync.TabIndex = 27;
            this.radioAsync.TabStop = true;
            this.radioAsync.Text = "Async - Resource Heavy (Faster)";
            this.radioAsync.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(123)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Wao - Launch";
            // 
            // minimiseBtn
            // 
            this.minimiseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(11)))), ((int)(((byte)(18)))));
            this.minimiseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimiseBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(123)))), ((int)(((byte)(224)))));
            this.minimiseBtn.Location = new System.Drawing.Point(155, 1);
            this.minimiseBtn.Name = "minimiseBtn";
            this.minimiseBtn.Size = new System.Drawing.Size(32, 23);
            this.minimiseBtn.TabIndex = 25;
            this.minimiseBtn.Text = "_";
            this.minimiseBtn.UseVisualStyleBackColor = false;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(11)))), ((int)(((byte)(18)))));
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(123)))), ((int)(((byte)(224)))));
            this.exitBtn.Location = new System.Drawing.Point(188, 1);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(32, 23);
            this.exitBtn.TabIndex = 24;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // formLaunchOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(223, 136);
            this.Controls.Add(this.btnLaunch);
            this.Controls.Add(this.radioSync);
            this.Controls.Add(this.radioAsync);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minimiseBtn);
            this.Controls.Add(this.exitBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formLaunchOption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formLaunchOption";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLaunch;
        public System.Windows.Forms.RadioButton radioAsync;
        public System.Windows.Forms.RadioButton radioSync;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button minimiseBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}