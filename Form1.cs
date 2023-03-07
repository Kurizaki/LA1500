using System.Security.Cryptography.X509Certificates;

namespace profile_einlesen
{
    public partial class Form1 : Form
    {
        bool again;

        string path = @"C:\Users\robin\Downloads\PasswordManager_Profil_Erstellen.txt";
        List<string> Profile = new();
        List<string> Email = new();
        List<string> UserName = new();
        List<string> Password = new();
        public Form1()
        {

            
            
                again = false;

                try
                {
                    InitializeComponent();
                    string[] lines = File.ReadAllLines(path);

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
                        listBox1.Items.Add(Profile[i]);
                    }

                }
                catch
                {
                    label1.Visible = true;
                    button1.Visible = true;
                }


                void button2_Click(object sender, EventArgs e)
                {
                    Hide();
                }

                void button1_Click(object sender, EventArgs e)
                {
                    try
                    {
                        int selectedIndex = listBox1.SelectedIndex;

                        listBox1.Items.Clear();

                        listBox1.Items.Add(Profile[selectedIndex]);
                        listBox1.Items.Add(UserName[selectedIndex]);
                        listBox1.Items.Add(Email[selectedIndex]);
                        listBox1.Items.Add(Password[selectedIndex]);
                    }
                    catch
                    {
                        label1.Visible = true;
                        button1.Visible = true;
                    }

                }

                void button4_Click(object sender, EventArgs e)
                {
                    
                }

        }

    }

}