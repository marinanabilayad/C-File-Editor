namespace Easy_Mission_Task
{
    public partial class Form1 : Form
    {
         FileManager fm=new FileManager();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
           try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog1.FileName;
                    Form2 form2 = new Form2(fm,filePath);
                    form2.Show();
                    this.Hide();
                }
            }

            catch(Exception ex) 
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog1.FileName;
                    Form3 form3 = new Form3(fm, filePath);
                    form3.Show();
                    this.Hide();

                }
            }

            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
           
        }
    }
}
