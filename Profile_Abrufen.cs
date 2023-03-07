namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string path = @"C:\\Test\\Test.txt";
        List<string> Profile = new();
        List<string> Email = new();
        List<string> UserName = new();
        List<string> Password = new();
        public Form1()
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;
            if (selectedIndex != -1)
            {
                //Profil bearbeitung wird geöffnet
            }
            else
            {
                //Fehelereingabe label anzeigen
            }
        }
    }
}
