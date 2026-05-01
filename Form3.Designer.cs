namespace Easy_Mission_Task
{
    partial class Form3
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
            lblFileInfo = new Label();
            lblFileContent = new Label();
            btnHome = new Button();
            btnExitApp = new Button();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblFileInfo
            // 
            lblFileInfo.AutoSize = true;
            lblFileInfo.BackColor = Color.Gainsboro;
            lblFileInfo.BorderStyle = BorderStyle.Fixed3D;
            lblFileInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblFileInfo.Location = new Point(388, 64);
            lblFileInfo.Name = "lblFileInfo";
            lblFileInfo.Size = new Size(2, 30);
            lblFileInfo.TabIndex = 0;
            // 
            // lblFileContent
            // 
            lblFileContent.AutoSize = true;
            lblFileContent.BackColor = Color.White;
            lblFileContent.BorderStyle = BorderStyle.Fixed3D;
            lblFileContent.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblFileContent.Location = new Point(388, 169);
            lblFileContent.Name = "lblFileContent";
            lblFileContent.Size = new Size(2, 30);
            lblFileContent.TabIndex = 1;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Aqua;
            btnHome.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnHome.Location = new Point(58, 278);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(259, 106);
            btnHome.TabIndex = 2;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnExitApp
            // 
            btnExitApp.BackColor = Color.Red;
            btnExitApp.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnExitApp.Location = new Point(476, 278);
            btnExitApp.Name = "btnExitApp";
            btnExitApp.Size = new Size(259, 106);
            btnExitApp.TabIndex = 5;
            btnExitApp.Text = "Exit App";
            btnExitApp.UseVisualStyleBackColor = false;
            btnExitApp.Click += btnExitApp_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tempus Sans ITC", 16.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(222, 64);
            label2.Name = "label2";
            label2.Size = new Size(134, 38);
            label2.TabIndex = 6;
            label2.Text = "File Info:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tempus Sans ITC", 16.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(170, 169);
            label1.Name = "label1";
            label1.Size = new Size(186, 38);
            label1.TabIndex = 7;
            label1.Text = "File Content:";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(btnExitApp);
            Controls.Add(btnHome);
            Controls.Add(lblFileContent);
            Controls.Add(lblFileInfo);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFileInfo;
        private Label lblFileContent;
        private Button btnHome;
        private Button btnExitApp;
        private Label label2;
        private Label label1;
    }
}