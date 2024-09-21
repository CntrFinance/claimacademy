namespace GradeManagerWin
{
    partial class GradeManagerWin
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
            this.LoadStudentFile1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AddStudentButton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoadStudentFile1
            // 
            this.LoadStudentFile1.BackColor = System.Drawing.Color.GreenYellow;
            this.LoadStudentFile1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadStudentFile1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LoadStudentFile1.Location = new System.Drawing.Point(191, 43);
            this.LoadStudentFile1.Name = "LoadStudentFile1";
            this.LoadStudentFile1.Size = new System.Drawing.Size(131, 66);
            this.LoadStudentFile1.TabIndex = 0;
            this.LoadStudentFile1.Text = "Load Student File ";
            this.LoadStudentFile1.UseVisualStyleBackColor = false;
            this.LoadStudentFile1.Click += new System.EventHandler(this.LoadStudentFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 9);
            this.label1.Name = "GradeManager1";
            this.label1.Size = new System.Drawing.Size(215, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Grade Manager";
            // 
            // AddStudentButton1
            // 
            this.AddStudentButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AddStudentButton1.Location = new System.Drawing.Point(191, 115);
            this.AddStudentButton1.Name = "AddStudentButton1";
            this.AddStudentButton1.Size = new System.Drawing.Size(131, 23);
            this.AddStudentButton1.TabIndex = 2;
            this.AddStudentButton1.Text = "Add Students";
            this.AddStudentButton1.UseVisualStyleBackColor = false;
            this.AddStudentButton1.Click += new System.EventHandler(this.AddStudentButton_Click);
            // 
            // GradeManagerWin
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(563, 261);
            this.Controls.Add(this.AddStudentButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoadStudentFile1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "GradeManagerWin";
            this.Text = "Grade Manager UI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GradeManagerLabel;
        private System.Windows.Forms.Button LoadStudentFile;
        private System.Windows.Forms.Button LoadStudentFile1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddStudentButton1;
    }
}

