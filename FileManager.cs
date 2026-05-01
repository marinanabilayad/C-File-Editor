using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;


namespace Easy_Mission_Task
{
    public class FileManager
    {
        public string ReadFromFile(string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    return "";
                }

                StreamReader inputFile;
                inputFile = File.OpenText(filePath);
                string fileContent = "";
                while (!inputFile.EndOfStream)
                {
                    fileContent += inputFile.ReadLine() + "\n";
                }
                inputFile.Close();
                return fileContent;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return "";
            }

        }

        private StreamWriter? outputFile;

        public void OpenFile(string filePath)
        {
            try
            {
                outputFile = new StreamWriter(filePath, true);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void WriteToFile(string text)
        {
            try
            {
                outputFile?.WriteLine(text);
            }

            catch (Exception ex) 
            {
                    MessageBox.Show(ex.Message);

            }
           
        }

        public void CloseFile()
        {
            if (outputFile != null)
            {
                outputFile.Close();
                outputFile = null;
            }
        }
    }
}
