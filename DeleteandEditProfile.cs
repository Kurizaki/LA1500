namespace PWv1
{
    public partial class DeleteandEditProfile : Form
    {
        private readonly List<string> Password = new();
        private readonly List<string> Profile = new();
        private readonly List<string> Email = new();
        private readonly List<string> UserName = new();
        private bool isButton1Hidden = false;
        private readonly string username = Environment.UserName;
        private readonly string encryptionpassword = "Additionszeichen";
        private int index { get; set; }
        public DeleteandEditProfile(int selectedIndex)
        {
            InitializeComponent();
            index = selectedIndex;
            profilenametextbox.ReadOnly = usernametextbox.ReadOnly = emailtextbox.ReadOnly = passwordtextbox.ReadOnly = true;
            confirmbutton.Visible = false;
            readallprofiles();
            profilenametextbox.Text = Profile[index];
            usernametextbox.Text = UserName[index];
            emailtextbox.Text = Email[index];
            passwordtextbox.Text = Password[index];
        }
        private void editbutton_Click(object sender, EventArgs e)
        {
            profilenametextbox.ReadOnly = usernametextbox.ReadOnly = emailtextbox.ReadOnly = passwordtextbox.ReadOnly = editbutton.Visible = false;
            isButton1Hidden = false;
            confirmbutton.Visible = true;
        }
        private void deletebutton_Click(object sender, EventArgs e)
        {
            Profile.RemoveAt(index);
            UserName.RemoveAt(index);
            Email.RemoveAt(index);
            Password.RemoveAt(index);
            saving();
            OpenForm(new EditProfile());
        }
        private void cancelbutton_Click(object sender, EventArgs e)
        {
            if (isButton1Hidden == true)
            {
                Encriptioncheck();
                OpenForm(new EditProfile());
            }
            else
            {
                profilenametextbox.Text = Profile[index];
                usernametextbox.Text = UserName[index];
                emailtextbox.Text = Email[index];
                passwordtextbox.Text = Password[index];
                profilenametextbox.ReadOnly = usernametextbox.ReadOnly = emailtextbox.ReadOnly = passwordtextbox.ReadOnly = isButton1Hidden = editbutton.Visible = true;
                confirmbutton.Visible = false;
            }
        }
        private void confirmbutton_Click(object sender, EventArgs e)
        {
            Profile[index] = profilenametextbox.Text;
            UserName[index] = usernametextbox.Text;
            Email[index] = emailtextbox.Text;
            Password[index] = passwordtextbox.Text;
            saving();
            OpenForm(new EditProfile());
        }
        private void DeleteandEditProfile_FormClosing(object sender, FormClosingEventArgs e)
        {
            Encriptioncheck();
        }
        private void readallprofiles()
        {
            Decription();
            string CredentialsFilePath = @$"C:\Users\{username}\AppData\Roaming\Passwordmanager\savings.txt";
            string[] lines = File.ReadAllLines(CredentialsFilePath);
            for (int i = 1; i < lines.Length; i++)
            {
                string[] fields = lines[i].Split(',');

                if (fields.Length >= 4)
                {
                    Profile.Add(fields[0]);
                    UserName.Add(fields[1]);
                    Email.Add(fields[2]);
                    Password.Add(fields[3]);
                }
            }
            Encription();
        }
        private void Encriptioncheck()
        {
            if (File.Exists(@$"C:\Users\{username}\AppData\Roaming\Passwordmanager\savings.txt.aes"))
            {
            }
            else
            {
                Encription();
            }
        }
        private void saving()
        {
            Decription();
            string CredentialsFilePath = @$"C:\Users\{username}\AppData\Roaming\Passwordmanager\savings.txt";
            string[] lines2 = File.ReadAllLines(CredentialsFilePath);
            string header = lines2[0];
            using (StreamWriter writer = new(CredentialsFilePath))
            {
                writer.WriteLine(header);
                for (int i = 0; i < Profile.Count; i++)
                {
                    writer.WriteLine($"{Profile[i]},{UserName[i]},{Email[i]},{Password[i]}");
                }
            }
            Encription();
        }
        private void OpenForm(Form form)
        {
            Thread thread;
            thread = new Thread(() => Application.Run(form));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            Close();
        }
        public void Encription()
        {
            ExpressEncription.AESEncription.AES_Encrypt(@$"C:\Users\{username}\AppData\Roaming\Passwordmanager\savings.txt", encryptionpassword);
            File.Delete(@$"C:\Users\{username}\AppData\Roaming\Passwordmanager\savings.txt");
        }
        public void Decription()
        {
            ExpressEncription.AESEncription.AES_Decrypt(@$"C:\Users\{username}\AppData\Roaming\Passwordmanager\savings.txt.aes", encryptionpassword);
            File.Delete(@$"C:\Users\{username}\AppData\Roaming\Passwordmanager\savings.txt.aes");
            File.Move(@$"C:\Users\{username}\AppData\Roaming\Passwordmanager\savings.txt.aes.decrypted", @$"C:\Users\{username}\AppData\Roaming\Passwordmanager\savings.txt");
        }
    }
}
