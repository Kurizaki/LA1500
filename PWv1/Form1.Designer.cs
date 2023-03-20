namespace PWv1
{
    partial class MasterPasswort
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterPasswort));
            this.confirmbutton = new System.Windows.Forms.Button();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.Background1 = new System.Windows.Forms.Label();
            this.Background2 = new System.Windows.Forms.Label();
            this.masterpassword = new System.Windows.Forms.Label();
            this.repeatmasterpassword = new System.Windows.Forms.Label();
            this.securekeycheck = new System.Windows.Forms.CheckBox();
            this.securetykeylabel = new System.Windows.Forms.Label();
            this.masterpassworttextbox = new System.Windows.Forms.TextBox();
            this.repeatmasterpassworttextbox = new System.Windows.Forms.TextBox();
            this.securekeytextBox = new System.Windows.Forms.TextBox();
            this.errorlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // confirmbutton
            // 
            this.confirmbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.confirmbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.confirmbutton.Font = new System.Drawing.Font("Verdana Pro Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirmbutton.Location = new System.Drawing.Point(436, 420);
            this.confirmbutton.Name = "confirmbutton";
            this.confirmbutton.Size = new System.Drawing.Size(122, 40);
            this.confirmbutton.TabIndex = 17;
            this.confirmbutton.Text = "Bestätigen";
            this.confirmbutton.UseVisualStyleBackColor = false;
            this.confirmbutton.Click += new System.EventHandler(this.confirmbutton_Click);
            // 
            // cancelbutton
            // 
            this.cancelbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cancelbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelbutton.Font = new System.Drawing.Font("Verdana Pro Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelbutton.Location = new System.Drawing.Point(102, 420);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(122, 40);
            this.cancelbutton.TabIndex = 18;
            this.cancelbutton.Text = "Beenden";
            this.cancelbutton.UseVisualStyleBackColor = false;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // Background1
            // 
            this.Background1.AutoSize = true;
            this.Background1.BackColor = System.Drawing.Color.White;
            this.Background1.Font = new System.Drawing.Font("Segoe UI", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Background1.ForeColor = System.Drawing.Color.White;
            this.Background1.Location = new System.Drawing.Point(102, 127);
            this.Background1.Name = "Background1";
            this.Background1.Size = new System.Drawing.Size(456, 48);
            this.Background1.TabIndex = 19;
            this.Background1.Text = "label1label1label1la1label1 ";
            // 
            // Background2
            // 
            this.Background2.AutoSize = true;
            this.Background2.BackColor = System.Drawing.Color.White;
            this.Background2.Font = new System.Drawing.Font("Segoe UI", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Background2.ForeColor = System.Drawing.Color.White;
            this.Background2.Location = new System.Drawing.Point(102, 195);
            this.Background2.Name = "Background2";
            this.Background2.Size = new System.Drawing.Size(456, 48);
            this.Background2.TabIndex = 20;
            this.Background2.Text = "label1label1label1la1label1 ";
            // 
            // masterpassword
            // 
            this.masterpassword.AutoSize = true;
            this.masterpassword.BackColor = System.Drawing.Color.White;
            this.masterpassword.Font = new System.Drawing.Font("Verdana Pro Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.masterpassword.Location = new System.Drawing.Point(103, 137);
            this.masterpassword.Name = "masterpassword";
            this.masterpassword.Size = new System.Drawing.Size(232, 29);
            this.masterpassword.TabIndex = 21;
            this.masterpassword.Text = "Master Passwort:";
            // 
            // repeatmasterpassword
            // 
            this.repeatmasterpassword.AutoSize = true;
            this.repeatmasterpassword.BackColor = System.Drawing.Color.White;
            this.repeatmasterpassword.Font = new System.Drawing.Font("Verdana Pro Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.repeatmasterpassword.Location = new System.Drawing.Point(103, 205);
            this.repeatmasterpassword.Name = "repeatmasterpassword";
            this.repeatmasterpassword.Size = new System.Drawing.Size(183, 29);
            this.repeatmasterpassword.TabIndex = 22;
            this.repeatmasterpassword.Text = "Wiederholen:";
            // 
            // securekeycheck
            // 
            this.securekeycheck.AutoSize = true;
            this.securekeycheck.BackColor = System.Drawing.Color.Transparent;
            this.securekeycheck.Font = new System.Drawing.Font("Verdana Pro Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.securekeycheck.Location = new System.Drawing.Point(223, 264);
            this.securekeycheck.Name = "securekeycheck";
            this.securekeycheck.Size = new System.Drawing.Size(199, 18);
            this.securekeycheck.TabIndex = 23;
            this.securekeycheck.Text = "Sicherheitsschlüssel wurde notiert";
            this.securekeycheck.UseVisualStyleBackColor = false;
            this.securekeycheck.Visible = false;
            // 
            // securetykeylabel
            // 
            this.securetykeylabel.AutoSize = true;
            this.securetykeylabel.BackColor = System.Drawing.Color.White;
            this.securetykeylabel.Font = new System.Drawing.Font("Verdana Pro Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.securetykeylabel.Location = new System.Drawing.Point(103, 206);
            this.securetykeylabel.Name = "securetykeylabel";
            this.securetykeylabel.Size = new System.Drawing.Size(279, 29);
            this.securetykeylabel.TabIndex = 24;
            this.securetykeylabel.Text = "Sicherheitsschlüssel:";
            // 
            // masterpassworttextbox
            // 
            this.masterpassworttextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.masterpassworttextbox.Font = new System.Drawing.Font("Verdana Pro Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.masterpassworttextbox.Location = new System.Drawing.Point(328, 137);
            this.masterpassworttextbox.Name = "masterpassworttextbox";
            this.masterpassworttextbox.Size = new System.Drawing.Size(219, 30);
            this.masterpassworttextbox.TabIndex = 25;
            // 
            // repeatmasterpassworttextbox
            // 
            this.repeatmasterpassworttextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.repeatmasterpassworttextbox.Font = new System.Drawing.Font("Verdana Pro Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.repeatmasterpassworttextbox.Location = new System.Drawing.Point(328, 205);
            this.repeatmasterpassworttextbox.Name = "repeatmasterpassworttextbox";
            this.repeatmasterpassworttextbox.Size = new System.Drawing.Size(219, 30);
            this.repeatmasterpassworttextbox.TabIndex = 26;
            // 
            // securekeytextBox
            // 
            this.securekeytextBox.BackColor = System.Drawing.Color.White;
            this.securekeytextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.securekeytextBox.Font = new System.Drawing.Font("Verdana Pro Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.securekeytextBox.Location = new System.Drawing.Point(375, 206);
            this.securekeytextBox.Name = "securekeytextBox";
            this.securekeytextBox.Size = new System.Drawing.Size(172, 30);
            this.securekeytextBox.TabIndex = 27;
            // 
            // errorlabel
            // 
            this.errorlabel.AutoSize = true;
            this.errorlabel.BackColor = System.Drawing.Color.Transparent;
            this.errorlabel.Font = new System.Drawing.Font("Verdana Pro Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.errorlabel.Location = new System.Drawing.Point(270, 264);
            this.errorlabel.Name = "errorlabel";
            this.errorlabel.Size = new System.Drawing.Size(87, 14);
            this.errorlabel.TabIndex = 28;
            this.errorlabel.Text = "Falsche Eingabe";
            this.errorlabel.Visible = false;
            // 
            // MasterPasswort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(660, 472);
            this.Controls.Add(this.errorlabel);
            this.Controls.Add(this.securekeytextBox);
            this.Controls.Add(this.securetykeylabel);
            this.Controls.Add(this.repeatmasterpassworttextbox);
            this.Controls.Add(this.masterpassworttextbox);
            this.Controls.Add(this.securekeycheck);
            this.Controls.Add(this.repeatmasterpassword);
            this.Controls.Add(this.masterpassword);
            this.Controls.Add(this.Background2);
            this.Controls.Add(this.Background1);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.confirmbutton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(676, 511);
            this.MinimumSize = new System.Drawing.Size(676, 511);
            this.Name = "MasterPasswort";
            this.Text = "Passwordmanager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.MasterPasswort_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button confirmbutton;
        private Button cancelbutton;
        private Label Background1;
        private Label Background2;
        private Label masterpassword;
        private Label repeatmasterpassword;
        private CheckBox securekeycheck;
        private Label securetykeylabel;
        private TextBox masterpassworttextbox;
        private TextBox repeatmasterpassworttextbox;
        private TextBox securekeytextBox;
        private Label errorlabel;
    }
}