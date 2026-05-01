namespace Easy_Mission_Task
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            btnOpenFile = new Button();
            btnSaveFile = new Button();
            btnExitApp = new Button();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnOpenFile
            // 
            btnOpenFile.BackColor = SystemColors.HotTrack;
            btnOpenFile.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnOpenFile.Location = new Point(71, 53);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(259, 106);
            btnOpenFile.TabIndex = 0;
            btnOpenFile.Text = "Open File";
            btnOpenFile.UseVisualStyleBackColor = false;
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // btnSaveFile
            // 
            btnSaveFile.BackColor = Color.Green;
            btnSaveFile.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSaveFile.Location = new Point(460, 53);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(259, 106);
            btnSaveFile.TabIndex = 1;
            btnSaveFile.Text = "Save File";
            btnSaveFile.UseVisualStyleBackColor = false;
            btnSaveFile.Click += btnSaveFile_Click;
            // 
            // btnExitApp
            // 
            btnExitApp.BackColor = Color.Red;
            btnExitApp.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnExitApp.ForeColor = Color.Black;
            btnExitApp.Location = new Point(260, 226);
            btnExitApp.Name = "btnExitApp";
            btnExitApp.Size = new Size(259, 106);
            btnExitApp.TabIndex = 2;
            btnExitApp.Text = "Exit App";
            btnExitApp.UseVisualStyleBackColor = false;
            btnExitApp.Click += btnExitApp_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExitApp);
            Controls.Add(btnSaveFile);
            Controls.Add(btnOpenFile);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Button btnOpenFile;
        private Button btnSaveFile;
        private Button btnExitApp;
    }
}
