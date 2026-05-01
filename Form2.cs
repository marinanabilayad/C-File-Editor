using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Easy_Mission_Task
{
    public partial class Form2 : Form
    {
        string? filePath;
        FileManager? fm;

        public Form2(FileManager fm,string filePath)
        {
            InitializeComponent();


            if (!string.IsNullOrEmpty(filePath))
            {
                this.fm = fm;
                this.filePath = filePath;
                fm.OpenFile(filePath);

            }

            else
            {
                MessageBox.Show("Error: No file is selected!");
                this.Close();
                return;
            }


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           try
            {
                if (fm != null)
                {
                    fm.WriteToFile(txtWriteInFile.Text);
                }
               
            }

           catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void btnHome_Click(object sender, EventArgs e)
        {
            if(fm != null)
            {
                fm.CloseFile();
            }

            Form1 form1 = new Form1();
            form1.Show();
            this.Close();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblFileInfo.Text = "File Name: " + Path.GetFileName(filePath) + "\nFile Path: " + filePath;
        }

        private void btnExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
