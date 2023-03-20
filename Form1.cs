namespace PWv1
{
    public partial class MasterPasswort : Form
    {
        private string masterPassword = string.Empty;
        private string securityKey = string.Empty;
        private bool isSecurityKeyGenerated;
        private int times;
        private bool verification = false;
        private bool registration;
        private readonly string username = Environment.UserName;
        private readonly string encryptionpassword = "Additionszeichen";
        public MasterPasswort()
        {
            InitializeComponent();
        }
        private void MasterPasswort_Load(object sender, EventArgs e)
        {
            string CredentialsFilePath = @$"C:\Users\{username}\AppData\Roaming\Passwordmanager\savings.txt";

            decryptioncheck();
            if (!File.Exists(CredentialsFilePath) || string.IsNullOrEmpty(File.ReadLines(CredentialsFilePath).FirstOrDefault()) || File.ReadLines(CredentialsFilePath).FirstOrDefault().Trim() == ",")
            {
                securekeycheck.Visible = securekeytextBox.Visible = securetykeylabel.Visible = errorlabel.Visible = false;
                registration = true;
                filecreation();
            }
            else
            {
                registration = false;
                Encription();
                repeatmasterpassword.Visible = repeatmasterpassworttextbox.Visible = Background2.Visible = securekeytextBox.Visible = securekeycheck.Visible = securetykeylabel.Visible = Background2.Visible = errorlabel.Visible = false;
                readmasterpassword();
            }
        }
        private void confirmbutton_Click(object sender, EventArgs e)
        {
            actonifmasterpasswordisbeingregestration();
            actonifmasterpasswordisnotbeingregestration();
        }
        private void cancelbutton_Click(object sender, EventArgs e)
        {
            Encriptioncheck();
            Application.Exit();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Encriptioncheck();
        }
        private void actonifmasterpasswordisnotbeingregestration()
        {
            if (registration == false)
            {
                if (masterpassworttextbox.Text == masterPassword && !string.IsNullOrEmpty(masterpassworttextbox.Text))
                {

                    save();
                    OpenForm(new PasswordmanagerMain());
                }
                else if (masterpassworttextbox.Text != masterPassword || string.IsNullOrEmpty(masterpassworttextbox.Text))
                {

                    errorlabel.Visible = verification = true;
                    times++;

                    if (verification == true && times >= 5)
                    {
                        repeatmasterpassword.Visible = repeatmasterpassworttextbox.Visible = masterpassword.Visible = masterpassworttextbox.Visible = Background1.Visible = errorlabel.Visible = false;
                        securekeytextBox.Visible = securetykeylabel.Visible = true;

                        if (securekeytextBox.Text == securityKey && !string.IsNullOrEmpty(securekeytextBox.Text))
                        {
                            resetmasterpassword();
                            Application.Restart();
                        }
                        if (times > 5)
                        {
                            if (securekeytextBox.Text != securityKey || !string.IsNullOrEmpty(securekeytextBox.Text))
                            {

                                errorlabel.Visible = true;
                                times++;
                                if (times >= 10)
                                {
                                    Application.Exit();
                                }
                            }
                        }
                    }
                }
            }
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
        private void actonifmasterpasswordisbeingregestration()
        {
            if (registration == true)
            {
                if (masterpassworttextbox.Text == repeatmasterpassworttextbox.Text && !string.IsNullOrEmpty(masterpassworttextbox.Text))
                {
                    repeatmasterpassworttextbox.Visible = repeatmasterpassword.Visible = masterpassworttextbox.Visible = masterpassword.Visible = Background1.Visible = errorlabel.Visible = false;
                    securekeytextBox.Visible = securekeycheck.Visible = securetykeylabel.Visible = true;
                    masterPassword = masterpassworttextbox.Text;

                    generatesecurekey();
                }
                if (string.IsNullOrEmpty(masterpassworttextbox.Text) || masterpassworttextbox.Text != repeatmasterpassworttextbox.Text)
                {
                    errorlabel.Visible = true;
                    times = 0;
                }
            }
        }
        private void generatesecurekey()
        {
            if (!isSecurityKeyGenerated)
            {
                Random rand = new();
                securityKey = rand.Next(100000, 999999).ToString();
                securekeytextBox.Text = securityKey;
                securekeytextBox.ReadOnly = true;
                isSecurityKeyGenerated = true;
            }
            else if (securekeycheck.Checked)
            {
                save();
                OpenForm(new PasswordmanagerMain());
            }
        }
        private void decryptioncheck()
        {
            if (File.Exists(@$"C:\Users\{username}\AppData\Roaming\Passwordmanager\savings.txt.aes"))
            {
                Decription();
            }
        }
        private void filecreation()
        {
            if (!File.Exists(@$"C:\Users\{username}\AppData\Roaming\Passwordmanager\savings.txt"))
            {
                registration = true;
                string appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string passwordManagerFolder = Path.Combine(appDataFolder, "Passwordmanager");
                _ = Directory.CreateDirectory(passwordManagerFolder);
                string passwordManagerFile = Path.Combine(passwordManagerFolder, "savings.txt");

                using StreamWriter writer = File.CreateText(passwordManagerFile);
                writer.WriteLine(",");
            }
            Encription();
        }
        private void readmasterpassword()
        {
            Decription();
            using (StreamReader reader = new(@$"C:\Users\{username}\AppData\Roaming\Passwordmanager\savings.txt"))
            {
                string line = reader.ReadLine();
                string[] parts = line.Split(',');
                masterPassword = parts[0];
                securityKey = parts[1];
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
        public void save()
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
                writer.WriteLine($"{masterPassword},{securityKey}");
                foreach (string line in tempLines)
                {
                    writer.WriteLine(line);
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