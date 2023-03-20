namespace PWv1
{
    partial class CreateProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateProfile));
            this.profilenamelabel = new System.Windows.Forms.Label();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.emaillabel = new System.Windows.Forms.Label();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.confirmbutton = new System.Windows.Forms.Button();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.usernametextbox = new System.Windows.Forms.TextBox();
            this.profilenametextbox = new System.Windows.Forms.TextBox();
            this.emailtextbox = new System.Windows.Forms.TextBox();
            this.passwordtextbox = new System.Windows.Forms.TextBox();
            this.generatepasswordbutton = new System.Windows.Forms.Button();
            this.errorlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // profilenamelabel
            // 
            this.profilenamelabel.AutoSize = true;
            this.profilenamelabel.BackColor = System.Drawing.Color.White;
            this.profilenamelabel.Font = new System.Drawing.Font("Verdana Pro Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.profilenamelabel.Location = new System.Drawing.Point(105, 140);
            this.profilenamelabel.Name = "profilenamelabel";
            this.profilenamelabel.Size = new System.Drawing.Size(159, 29);
            this.profilenamelabel.TabIndex = 22;
            this.profilenamelabel.Text = "Profilname:";
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.BackColor = System.Drawing.Color.White;
            this.usernamelabel.Font = new System.Drawing.Font("Verdana Pro Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.usernamelabel.Location = new System.Drawing.Point(105, 205);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(178, 29);
            this.usernamelabel.TabIndex = 23;
            this.usernamelabel.Text = "Nutzername:";
            // 
            // emaillabel
            // 
            this.emaillabel.AutoSize = true;
            this.emaillabel.BackColor = System.Drawing.Color.White;
            this.emaillabel.Font = new System.Drawing.Font("Verdana Pro Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.emaillabel.Location = new System.Drawing.Point(105, 275);
            this.emaillabel.Name = "emaillabel";
            this.emaillabel.Size = new System.Drawing.Size(93, 29);
            this.emaillabel.TabIndex = 24;
            this.emaillabel.Text = "Email:";
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.BackColor = System.Drawing.Color.White;
            this.passwordlabel.Font = new System.Drawing.Font("Verdana Pro Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passwordlabel.Location = new System.Drawing.Point(105, 342);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(138, 29);
            this.passwordlabel.TabIndex = 25;
            this.passwordlabel.Text = "Passwort:";
            // 
            // confirmbutton
            // 
            this.confirmbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.confirmbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.confirmbutton.Font = new System.Drawing.Font("Verdana Pro Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirmbutton.Location = new System.Drawing.Point(425, 420);
            this.confirmbutton.Name = "confirmbutton";
            this.confirmbutton.Size = new System.Drawing.Size(122, 40);
            this.confirmbutton.TabIndex = 26;
            this.confirmbutton.Text = "Bestätigen";
            this.confirmbutton.UseVisualStyleBackColor = false;
            this.confirmbutton.Click += new System.EventHandler(this.confirmbutton_Click);
            // 
            // cancelbutton
            // 
            this.cancelbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cancelbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelbutton.Font = new System.Drawing.Font("Verdana Pro Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelbutton.Location = new System.Drawing.Point(105, 420);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(122, 40);
            this.cancelbutton.TabIndex = 27;
            this.cancelbutton.Text = "Zurück";
            this.cancelbutton.UseVisualStyleBackColor = false;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // usernametextbox
            // 
            this.usernametextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernametextbox.Font = new System.Drawing.Font("Verdana Pro Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernametextbox.Location = new System.Drawing.Point(289, 204);
            this.usernametextbox.Name = "usernametextbox";
            this.usernametextbox.Size = new System.Drawing.Size(258, 30);
            this.usernametextbox.TabIndex = 29;
            // 
            // profilenametextbox
            // 
            this.profilenametextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.profilenametextbox.Font = new System.Drawing.Font("Verdana Pro Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.profilenametextbox.Location = new System.Drawing.Point(289, 139);
            this.profilenametextbox.Name = "profilenametextbox";
            this.profilenametextbox.Size = new System.Drawing.Size(258, 30);
            this.profilenametextbox.TabIndex = 30;
            // 
            // emailtextbox
            // 
            this.emailtextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailtextbox.Font = new System.Drawing.Font("Verdana Pro Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailtextbox.Location = new System.Drawing.Point(289, 274);
            this.emailtextbox.Name = "emailtextbox";
            this.emailtextbox.Size = new System.Drawing.Size(258, 30);
            this.emailtextbox.TabIndex = 31;
            // 
            // passwordtextbox
            // 
            this.passwordtextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordtextbox.Font = new System.Drawing.Font("Verdana Pro Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordtextbox.Location = new System.Drawing.Point(289, 341);
            this.passwordtextbox.Name = "passwordtextbox";
            this.passwordtextbox.Size = new System.Drawing.Size(258, 30);
            this.passwordtextbox.TabIndex = 32;
            // 
            // generatepasswordbutton
            // 
            this.generatepasswordbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.generatepasswordbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.generatepasswordbutton.Font = new System.Drawing.Font("Verdana Pro Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.generatepasswordbutton.Location = new System.Drawing.Point(264, 420);
            this.generatepasswordbutton.Name = "generatepasswordbutton";
            this.generatepasswordbutton.Size = new System.Drawing.Size(122, 40);
            this.generatepasswordbutton.TabIndex = 33;
            this.generatepasswordbutton.Text = "Passwort Generieren";
            this.generatepasswordbutton.UseVisualStyleBackColor = false;
            this.generatepasswordbutton.Click += new System.EventHandler(this.generatepasswordbutton_Click);
            // 
            // errorlabel
            // 
            this.errorlabel.AutoSize = true;
            this.errorlabel.BackColor = System.Drawing.Color.Transparent;
            this.errorlabel.Font = new System.Drawing.Font("Verdana Pro Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.errorlabel.Location = new System.Drawing.Point(222, 387);
            this.errorlabel.Name = "errorlabel";
            this.errorlabel.Size = new System.Drawing.Size(208, 14);
            this.errorlabel.TabIndex = 34;
            this.errorlabel.Text = "Sie haben nicht alles Spalten ausgefüllt.";
            this.errorlabel.Visible = false;
            // 
            // CreateProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(660, 472);
            this.Controls.Add(this.errorlabel);
            this.Controls.Add(this.generatepasswordbutton);
            this.Controls.Add(this.passwordtextbox);
            this.Controls.Add(this.emailtextbox);
            this.Controls.Add(this.profilenametextbox);
            this.Controls.Add(this.usernametextbox);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.confirmbutton);
            this.Controls.Add(this.passwordlabel);
            this.Controls.Add(this.emaillabel);
            this.Controls.Add(this.usernamelabel);
            this.Controls.Add(this.profilenamelabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(676, 511);
            this.MinimumSize = new System.Drawing.Size(676, 511);
            this.Name = "CreateProfile";
            this.Text = "Passwordmanager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label profilenamelabel;
        private Label usernamelabel;
        private Label emaillabel;
        private Label passwordlabel;
        private Button confirmbutton;
        private Button cancelbutton;
        private TextBox usernametextbox;
        private TextBox profilenametextbox;
        private TextBox emailtextbox;
        private TextBox passwordtextbox;
        private Button generatepasswordbutton;
        private Label errorlabel;
    }
}