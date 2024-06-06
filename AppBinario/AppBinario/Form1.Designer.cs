namespace AppBinario
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
            btnSelectFile = new Button();
            txtFilePath = new TextBox();
            txtFileContent = new TextBox();
            btnReadFile = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnSelectFile
            // 
            btnSelectFile.BackColor = Color.Bisque;
            btnSelectFile.Location = new Point(87, 341);
            btnSelectFile.Name = "btnSelectFile";
            btnSelectFile.Size = new Size(101, 47);
            btnSelectFile.TabIndex = 0;
            btnSelectFile.Text = "Select File";
            btnSelectFile.UseVisualStyleBackColor = false;
            btnSelectFile.Click += btnSelectFile_Click;
            // 
            // txtFilePath
            // 
            txtFilePath.Location = new Point(73, 115);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(100, 23);
            txtFilePath.TabIndex = 1;
            // 
            // txtFileContent
            // 
            txtFileContent.Location = new Point(351, 106);
            txtFileContent.Multiline = true;
            txtFileContent.Name = "txtFileContent";
            txtFileContent.Size = new Size(249, 149);
            txtFileContent.TabIndex = 2;
            // 
            // btnReadFile
            // 
            btnReadFile.BackColor = Color.Bisque;
            btnReadFile.Location = new Point(394, 341);
            btnReadFile.Name = "btnReadFile";
            btnReadFile.Size = new Size(102, 47);
            btnReadFile.TabIndex = 3;
            btnReadFile.Text = "ReadFile";
            btnReadFile.UseVisualStyleBackColor = false;
            btnReadFile.Click += btnReadFile_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(238, 9);
            label1.Name = "label1";
            label1.Size = new Size(219, 30);
            label1.TabIndex = 4;
            label1.Text = "App Binarie Console";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnReadFile);
            Controls.Add(txtFileContent);
            Controls.Add(txtFilePath);
            Controls.Add(btnSelectFile);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSelectFile;
        private TextBox txtFilePath;
        private TextBox txtFileContent;
        private Button btnReadFile;
        private Label label1;
    }
}
