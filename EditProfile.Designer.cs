namespace PWv1
{
    partial class EditProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProfile));
            this.choseprofilebutton = new System.Windows.Forms.Button();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.profileslistbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // choseprofilebutton
            // 
            this.choseprofilebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.choseprofilebutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.choseprofilebutton.Font = new System.Drawing.Font("Verdana Pro Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.choseprofilebutton.Location = new System.Drawing.Point(409, 420);
            this.choseprofilebutton.Name = "choseprofilebutton";
            this.choseprofilebutton.Size = new System.Drawing.Size(122, 40);
            this.choseprofilebutton.TabIndex = 27;
            this.choseprofilebutton.Text = "Profil auswählen";
            this.choseprofilebutton.UseVisualStyleBackColor = false;
            this.choseprofilebutton.Click += new System.EventHandler(this.choseprofilebutton_Click);
            // 
            // cancelbutton
            // 
            this.cancelbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cancelbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelbutton.Font = new System.Drawing.Font("Verdana Pro Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelbutton.Location = new System.Drawing.Point(143, 420);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(122, 40);
            this.cancelbutton.TabIndex = 28;
            this.cancelbutton.Text = "Zurück";
            this.cancelbutton.UseVisualStyleBackColor = false;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // profileslistbox
            // 
            this.profileslistbox.BackColor = System.Drawing.Color.White;
            this.profileslistbox.Font = new System.Drawing.Font("Verdana Pro Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.profileslistbox.FormattingEnabled = true;
            this.profileslistbox.ItemHeight = 29;
            this.profileslistbox.Location = new System.Drawing.Point(203, 127);
            this.profileslistbox.Name = "profileslistbox";
            this.profileslistbox.Size = new System.Drawing.Size(268, 265);
            this.profileslistbox.TabIndex = 29;
            // 
            // EditProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(660, 472);
            this.Controls.Add(this.profileslistbox);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.choseprofilebutton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(676, 511);
            this.MinimumSize = new System.Drawing.Size(676, 511);
            this.Name = "EditProfile";
            this.Text = "Passwordmanager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private Button choseprofilebutton;
        private Button cancelbutton;
        private ListBox profileslistbox;
    }
}