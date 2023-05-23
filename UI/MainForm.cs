
namespace UI
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            //WindowState = FormWindowState.Maximized;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }



        private void saveUserInformationsButton_Click(object sender, EventArgs e)
        {
        }

        private void userInformaitonsMenuStripForOptions_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void saveButtonForInfoEdit_Click(object sender, EventArgs e)
        {

        }

        private void loginPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxForHouse_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.ShowDialog();
            label1.Text = dialog.FileName;
        }
    }
}
