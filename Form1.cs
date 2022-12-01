namespace collegevideo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menuStrip1.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username = textBox1.Text;
            String password = textBox2.Text;

           /* if(username == "student" && password == "student")
            {*/
                menuStrip1.Visible = true;
                panel1.Visible = false;
           /* }
            else
            {
                MessageBox.Show("Invalid UserID or Password", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }*/
        }

        private void newAdmissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_Admission na = new New_Admission();
            na.Show();
        }
    }
}