using ExpressEncription;
using System.Text;

namespace PWv1
{
    public partial class CreateProfile : Form
    {
        private readonly List<string> Password = new();
        private readonly List<string> Profile = new();
        private readonly List<string> Email = new();
        private readonly List<string> UserName = new();
        string username = Environment.UserName;
        string encryptionpassword = "Additionszeichen";
        public CreateProfile()
        {
            InitializeComponent();
        }
        private void confirmbutton_Click(object sender, EventArgs e)
        {
            saveProfile();
        }
        private void generatepasswordbutton_Click(object sender, EventArgs e)
        {
            int passwordLength = new Random().Next(13, 18);
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890?!";
            StringBuilder password = new();
            Random random = new();
            while (0 < passwordLength--)
            {
                _ = password.Append(validChars[random.Next(validChars.Length)]);
            }
            passwordtextbox.Text = password.ToString();
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
        private void saveProfile()
        {
            if (string.IsNullOrEmpty(profilenametextbox.Text) || string.IsNullOrEmpty(usernametextbox.Text) || string.IsNullOrEmpty(emailtextbox.Text) || string.IsNullOrEmpty(passwordtextbox.Text))
            {
                errorlabel.Visible = true; ;
            }
            else
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
                Profile.Add(profilenametextbox.Text);
                UserName.Add(usernametextbox.Text);
                Email.Add(emailtextbox.Text);
                Password.Add(passwordtextbox.Text);
                string[] lines2 = File.ReadAllLines(CredentialsFilePath);
                string header = lines2[0];
                using (StreamWriter writer = new(CredentialsFilePath))
                {
                    writer.WriteLine(header);
                    for (int z = 0; z < Profile.Count; z++)
                    {
                        writer.WriteLine($"{Profile[z]},{UserName[z]},{Email[z]},{Password[z]}");
                    }
                }
                Encription();
                OpenForm(new PasswordmanagerMain());
            }
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
