namespace Reminder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string filename = "data.txt";
            try
            {
                string fileContent = File.ReadAllText(filename);

                label1.Text = fileContent;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to find the file " + filename +
                    ". Please create the " + filename +
                    " file in the same directory as this executable.");
                Application.Exit();
            }
        }
    }
}