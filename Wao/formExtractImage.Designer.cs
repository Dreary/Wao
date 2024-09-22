namespace Wao
{
    partial class formExtractImage
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
            this.btnExtractImage = new System.Windows.Forms.Button();
            this.radioSync = new System.Windows.Forms.RadioButton();
            this.radioAsync = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.minimiseBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.chBoxBackup = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnExtractImage
            // 
            this.btnExtractImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(11)))), ((int)(((byte)(18)))));
            this.btnExtractImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtractImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(123)))), ((int)(((byte)(224)))));
            this.btnExtractImage.Location = new System.Drawing.Point(68, 106);
            this.btnExtractImage.Name = "btnExtractImage";
            this.btnExtractImage.Size = new System.Drawing.Size(87, 39);
            this.btnExtractImage.TabIndex = 22;
            this.btnExtractImage.Text = "Extract Image";
            this.btnExtractImage.UseVisualStyleBackColor = false;
            this.btnExtractImage.Click += new System.EventHandler(this.btnExtractImage_Click);
            // 
            // radioSync
            // 
            this.radioSync.AutoSize = true;
            this.radioSync.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioSync.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(123)))), ((int)(((byte)(224)))));
            this.radioSync.Location = new System.Drawing.Point(25, 60);
            this.radioSync.Name = "radioSync";
            this.radioSync.Size = new System.Drawing.Size(180, 17);
            this.radioSync.TabIndex = 21;
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
            this.radioAsync.TabIndex = 20;
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
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Wao - Extract";
            // 
            // minimiseBtn
            // 
            this.minimiseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(11)))), ((int)(((byte)(18)))));
            this.minimiseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimiseBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(123)))), ((int)(((byte)(224)))));
            this.minimiseBtn.Location = new System.Drawing.Point(155, 1);
            this.minimiseBtn.Name = "minimiseBtn";
            this.minimiseBtn.Size = new System.Drawing.Size(32, 23);
            this.minimiseBtn.TabIndex = 18;
            this.minimiseBtn.Text = "_";
            this.minimiseBtn.UseVisualStyleBackColor = false;
            this.minimiseBtn.Click += new System.EventHandler(this.minimiseBtn_Click_1);
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
            this.exitBtn.TabIndex = 17;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click_1);
            // 
            // chBoxBackup
            // 
            this.chBoxBackup.AutoSize = true;
            this.chBoxBackup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(123)))), ((int)(((byte)(224)))));
            this.chBoxBackup.Location = new System.Drawing.Point(25, 83);
            this.chBoxBackup.Name = "chBoxBackup";
            this.chBoxBackup.Size = new System.Drawing.Size(185, 17);
            this.chBoxBackup.TabIndex = 23;
            this.chBoxBackup.Text = "Backup current Image.m2d/m2h?";
            this.chBoxBackup.UseVisualStyleBackColor = true;
            // 
            // formExtractImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(223, 157);
            this.Controls.Add(this.chBoxBackup);
            this.Controls.Add(this.btnExtractImage);
            this.Controls.Add(this.radioSync);
            this.Controls.Add(this.radioAsync);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minimiseBtn);
            this.Controls.Add(this.exitBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formExtractImage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formExtractImage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExtractImage;
        private System.Windows.Forms.RadioButton radioSync;
        private System.Windows.Forms.RadioButton radioAsync;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button minimiseBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.CheckBox chBoxBackup;
    }
}