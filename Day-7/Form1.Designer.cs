namespace Day_7
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
            panel1 = new Panel();
            label1 = new Label();
            readingRichTextBox = new RichTextBox();
            readFile = new Panel();
            label2 = new Label();
            addFile = new Panel();
            label3 = new Label();
            removeFile = new Panel();
            label4 = new Label();
            docFile = new Panel();
            label5 = new Label();
            panel1.SuspendLayout();
            readFile.SuspendLayout();
            addFile.SuspendLayout();
            removeFile.SuspendLayout();
            docFile.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.BackColor = Color.Red;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(800, 100);
            label1.TabIndex = 0;
            label1.Text = "PAPERMAN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // readingRichTextBox
            // 
            readingRichTextBox.Location = new Point(399, 106);
            readingRichTextBox.Name = "readingRichTextBox";
            readingRichTextBox.Size = new Size(389, 318);
            readingRichTextBox.TabIndex = 1;
            readingRichTextBox.Text = "";
            // 
            // readFile
            // 
            readFile.BackColor = Color.Silver;
            readFile.Controls.Add(label2);
            readFile.Location = new Point(12, 106);
            readFile.Name = "readFile";
            readFile.Size = new Size(381, 75);
            readFile.TabIndex = 2;
            readFile.Click += readFile_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(132, 23);
            label2.Name = "label2";
            label2.Size = new Size(116, 32);
            label2.TabIndex = 0;
            label2.Text = "Read File";
            // 
            // addFile
            // 
            addFile.BackColor = Color.Silver;
            addFile.Controls.Add(label3);
            addFile.Location = new Point(12, 187);
            addFile.Name = "addFile";
            addFile.Size = new Size(381, 75);
            addFile.TabIndex = 3;
            addFile.Click += addFile_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(132, 21);
            label3.Name = "label3";
            label3.Size = new Size(107, 32);
            label3.TabIndex = 1;
            label3.Text = "Add File";
            // 
            // removeFile
            // 
            removeFile.BackColor = Color.Silver;
            removeFile.Controls.Add(label4);
            removeFile.Location = new Point(12, 268);
            removeFile.Name = "removeFile";
            removeFile.Size = new Size(381, 75);
            removeFile.TabIndex = 4;
            removeFile.Click += removeFile_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(132, 21);
            label4.Name = "label4";
            label4.Size = new Size(151, 32);
            label4.TabIndex = 1;
            label4.Text = "Remove File";
            // 
            // docFile
            // 
            docFile.BackColor = Color.Silver;
            docFile.Controls.Add(label5);
            docFile.Location = new Point(12, 349);
            docFile.Name = "docFile";
            docFile.Size = new Size(381, 75);
            docFile.TabIndex = 3;
            docFile.Click += docFile_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(132, 21);
            label5.Name = "label5";
            label5.Size = new Size(111, 32);
            label5.TabIndex = 1;
            label5.Text = "DOC File";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OrangeRed;
            ClientSize = new Size(800, 450);
            Controls.Add(docFile);
            Controls.Add(removeFile);
            Controls.Add(addFile);
            Controls.Add(readFile);
            Controls.Add(readingRichTextBox);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            readFile.ResumeLayout(false);
            readFile.PerformLayout();
            addFile.ResumeLayout(false);
            addFile.PerformLayout();
            removeFile.ResumeLayout(false);
            removeFile.PerformLayout();
            docFile.ResumeLayout(false);
            docFile.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private RichTextBox readingRichTextBox;
        private Panel readFile;
        private Panel addFile;
        private Panel removeFile;
        private Panel docFile;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
