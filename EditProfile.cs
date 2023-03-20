namespace PWv1
{
    public partial class EditProfile : Form
    {
        private readonly List<string> Profile = new();
        private readonly List<string> Email = new();
        private readonly List<string> UserName = new();
        private readonly List<string> Password = new();
        string username = Environment.UserName;
        string encryptionpassword = "Additionszeichen";

        public EditProfile()
        {
            InitializeComponent();
            profilesoutput();
        }
        private void choseprofilebutton_Click(object sender, EventArgs e)
        {
            int selectedIndex = profileslistbox.SelectedIndex;
            if (selectedIndex != -1)
            {
                OpenForm(new DeleteandEditProfile(selectedIndex));
            }
        }
        private void cancelbutton_Click(object sender, EventArgs e)
        {
            Encriptioncheck();
            OpenForm(new PasswordmanagerMain());
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Encriptioncheck();
        }
        private void profilesoutput()
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
            for (int i = 0; i < Profile.Count; i++)
            {
                profileslistbox.Items.Add(Profile[i]);
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