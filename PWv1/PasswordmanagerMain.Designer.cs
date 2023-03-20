namespace PWv1
{
    partial class PasswordmanagerMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordmanagerMain));
            this.createprofilebutton = new System.Windows.Forms.Button();
            this.editandseeprofile = new System.Windows.Forms.Button();
            this.changemasterpassword = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createprofilebutton
            // 
            this.createprofilebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.createprofilebutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createprofilebutton.Font = new System.Drawing.Font("Verdana Pro Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createprofilebutton.Location = new System.Drawing.Point(264, 132);
            this.createprofilebutton.Name = "createprofilebutton";
            this.createprofilebutton.Size = new System.Drawing.Size(143, 54);
            this.createprofilebutton.TabIndex = 17;
            this.createprofilebutton.Text = "Profil Erstellen";
            this.createprofilebutton.UseVisualStyleBackColor = false;
            this.createprofilebutton.Click += new System.EventHandler(this.createprofilebutton_Click);
            // 
            // editandseeprofile
            // 
            this.editandseeprofile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.editandseeprofile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editandseeprofile.Font = new System.Drawing.Font("Verdana Pro Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editandseeprofile.Location = new System.Drawing.Point(264, 209);
            this.editandseeprofile.Name = "editandseeprofile";
            this.editandseeprofile.Size = new System.Drawing.Size(143, 54);
            this.editandseeprofile.TabIndex = 18;
            this.editandseeprofile.Text = "Profil Abrufen  Bearbeiten  Löschen";
            this.editandseeprofile.UseVisualStyleBackColor = false;
            this.editandseeprofile.Click += new System.EventHandler(this.editandseeprofile_Click);
            // 
            // changemasterpassword
            // 
            this.changemasterpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.changemasterpassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changemasterpassword.Font = new System.Drawing.Font("Verdana Pro Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.changemasterpassword.Location = new System.Drawing.Point(264, 286);
            this.changemasterpassword.Name = "changemasterpassword";
            this.changemasterpassword.Size = new System.Drawing.Size(143, 54);
            this.changemasterpassword.TabIndex = 19;
            this.changemasterpassword.Text = "Master Passwort ändern";
            this.changemasterpassword.UseVisualStyleBackColor = false;
            this.changemasterpassword.Click += new System.EventHandler(this.changemasterpassword_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitbutton.Font = new System.Drawing.Font("Verdana Pro Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitbutton.Location = new System.Drawing.Point(264, 362);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(143, 54);
            this.exitbutton.TabIndex = 20;
            this.exitbutton.Text = "Beenden";
            this.exitbutton.UseVisualStyleBackColor = false;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // PasswordmanagerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(660, 472);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.changemasterpassword);
            this.Controls.Add(this.editandseeprofile);
            this.Controls.Add(this.createprofilebutton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(676, 511);
            this.MinimumSize = new System.Drawing.Size(676, 511);
            this.Name = "PasswordmanagerMain";
            this.Text = "Passwordmanager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private Button createprofilebutton;
        private Button editandseeprofile;
        private Button changemasterpassword;
        private Button exitbutton;
    }
}