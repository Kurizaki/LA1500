using ExpressEncription;

namespace PWv1
{
    public partial class PasswordmanagerMain : Form
    {
        string username = Environment.UserName;
        string encryptionpassword = "Additionszeichen";
        public PasswordmanagerMain()
        {
            InitializeComponent();
        }
        private void createprofilebutton_Click(object sender, EventArgs e)
        {
            OpenForm(new CreateProfile());
        }
        private void editandseeprofile_Click(object sender, EventArgs e)
        {
            OpenForm(new EditProfile());
        }
        private void changemasterpassword_Click(object sender, EventArgs e)
        {
            resetmasterpassword();
            OpenForm(new MasterPasswort());
        }
        private void exitbutton_Click(object sender, EventArgs e)
        {
            Encriptioncheck();
            Application.Exit();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Encriptioncheck();
        }
        private void resetmasterpassword()
        {
            Decription();
            string CredentialsFilePath = @$"C:\Users\{username}\AppData\Roaming\Passwordmanager\savings.txt";
            List<string> tempLines = new();
            using (StreamReader reader = new(CredentialsFilePath))
            {
                string line;
                int count = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    if (count != 0)
                    {
                        tempLines.Add(line);
                    }
                    count++;
                }
            }
            using (StreamWriter writer = new(CredentialsFilePath))
            {
                writer.WriteLine($"{string.Empty},{string.Empty}");
                foreach (string line in tempLines)
                {
                    writer.WriteLine(line);
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
            AESEncription.AES_Encrypt(@$"C:\Users\{username}\AppData\Roaming\Passwordmanager\savings.txt", encryptionpassword);
            File.Delete(@$"C:\Users\{username}\AppData\Roaming\Passwordmanager\savings.txt");
        }
        public void Decription()
        {
            AESEncription.AES_Decrypt(@$"C:\Users\{username}\AppData\Roaming\Passwordmanager\savings.txt.aes", encryptionpassword);
            File.Delete(@$"C:\Users\{username}\AppData\Roaming\Passwordmanager\savings.txt.aes");
            File.Move(@$"C:\Users\{username}\AppData\Roaming\Passwordmanager\savings.txt.aes.decrypted", @$"C:\Users\{username}\AppData\Roaming\Passwordmanager\savings.txt");
        }
    }
}