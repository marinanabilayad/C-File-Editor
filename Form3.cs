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
    public partial class Form3 : Form
    {
        string? filePath;
        FileManager? fm;

        public Form3(FileManager fm, string filePath)
        {
            InitializeComponent();

            if (!string.IsNullOrEmpty(filePath))
            {
                this.fm = fm;
                this.filePath = filePath;
            }

            else
            {
                MessageBox.Show("Error: No file is selected!");
                this.Close();
                return;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                lblFileInfo.Text = "File Name: " + Path.GetFileName(filePath) + "\nFile Path: " + filePath;

                if(fm != null && !string.IsNullOrEmpty(filePath))
                {
                    string fileContent = fm.ReadFromFile(filePath);

                    if(string.IsNullOrWhiteSpace(fileContent))
                    {
                        lblFileContent.Text = "WARNING: FILE IS EMPTY!";
                    }
                    else
                    {
                        lblFileContent.Text = fileContent;
                    }
                   
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void btnExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
