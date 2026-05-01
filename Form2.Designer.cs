namespace Easy_Mission_Task
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtWriteInFile = new TextBox();
            btnSave = new Button();
            lblFileInfo = new Label();
            btnHome = new Button();
            btnExitApp = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtWriteInFile
            // 
            txtWriteInFile.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtWriteInFile.Location = new Point(384, 115);
            txtWriteInFile.Name = "txtWriteInFile";
            txtWriteInFile.Size = new Size(240, 34);
            txtWriteInFile.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Orange;
            btnSave.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(262, 181);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(259, 106);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblFileInfo
            // 
            lblFileInfo.AutoSize = true;
            lblFileInfo.BackColor = Color.Gainsboro;
            lblFileInfo.BorderStyle = BorderStyle.Fixed3D;
            lblFileInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFileInfo.Location = new Point(384, 24);
            lblFileInfo.Name = "lblFileInfo";
            lblFileInfo.Size = new Size(2, 30);
            lblFileInfo.TabIndex = 2;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Aqua;
            btnHome.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnHome.Location = new Point(12, 310);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(259, 106);
            btnHome.TabIndex = 3;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnExitApp
            // 
            btnExitApp.BackColor = Color.Red;
            btnExitApp.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnExitApp.Location = new Point(529, 310);
            btnExitApp.Name = "btnExitApp";
            btnExitApp.Size = new Size(259, 106);
            btnExitApp.TabIndex = 4;
            btnExitApp.Text = "Exit App";
            btnExitApp.UseVisualStyleBackColor = false;
            btnExitApp.Click += btnExitApp_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tempus Sans ITC", 16.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(227, 24);
            label2.Name = "label2";
            label2.Size = new Size(134, 38);
            label2.TabIndex = 5;
            label2.Text = "File Info:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tempus Sans ITC", 16.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(90, 115);
            label3.Name = "label3";
            label3.Size = new Size(271, 38);
            label3.TabIndex = 6;
            label3.Text = "Text Added To File:";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnExitApp);
            Controls.Add(btnHome);
            Controls.Add(lblFileInfo);
            Controls.Add(btnSave);
            Controls.Add(txtWriteInFile);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private TextBox txtWriteInFile;
        private Button btnSave;
        private Label lblFileInfo;
        private Button btnHome;
        private Button btnExitApp;
        private Label label2;
        private Label label3;
    }
}