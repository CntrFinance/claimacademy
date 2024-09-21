namespace GradeManagerWin
{
    partial class AddStudent
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
            this.AddStudent1 = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.LastName1 = new System.Windows.Forms.Label();
            this.FirstName1 = new System.Windows.Forms.Label();
            this.SaveStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddStudent1
            // 
            this.AddStudent1.AutoSize = true;
            this.AddStudent1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStudent1.Location = new System.Drawing.Point(325, 25);
            this.AddStudent1.Name = "AddStudent1";
            this.AddStudent1.Size = new System.Drawing.Size(125, 24);
            this.AddStudent1.TabIndex = 0;
            this.AddStudent1.Text = "Add Student";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(221, 84);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(309, 20);
            this.FirstNameTextBox.TabIndex = 1;
            this.FirstNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(221, 127);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(309, 20);
            this.LastNameTextBox.TabIndex = 2;
            // 
            // LastName1
            // 
            this.LastName1.AutoSize = true;
            this.LastName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName1.Location = new System.Drawing.Point(62, 126);
            this.LastName1.Name = "LastName1";
            this.LastName1.Size = new System.Drawing.Size(89, 18);
            this.LastName1.TabIndex = 3;
            this.LastName1.Text = "Last Name";
            this.LastName1.Click += new System.EventHandler(this.LastName1_Click);
            // 
            // FirstName1
            // 
            this.FirstName1.AutoSize = true;
            this.FirstName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName1.Location = new System.Drawing.Point(62, 72);
            this.FirstName1.Name = "FirstName1";
            this.FirstName1.Size = new System.Drawing.Size(96, 18);
            this.FirstName1.TabIndex = 4;
            this.FirstName1.Text = "First Name:";
            this.FirstName1.Click += new System.EventHandler(this.label3_Click);
            // 
            // SaveStudent
            // 
            this.SaveStudent.Location = new System.Drawing.Point(277, 227);
            this.SaveStudent.Name = "SaveStudent";
            this.SaveStudent.Size = new System.Drawing.Size(173, 23);
            this.SaveStudent.TabIndex = 5;
            this.SaveStudent.Text = "Save Student";
            this.SaveStudent.UseVisualStyleBackColor = true;
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaveStudent);
            this.Controls.Add(this.FirstName1);
            this.Controls.Add(this.LastName1);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.AddStudent1);
            this.Name = "AddStudent";
            this.Text = "AddStudent";
            this.Load += new System.EventHandler(this.AddStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddStudent1;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label LastName1;
        private System.Windows.Forms.Label FirstName1;
        private System.Windows.Forms.Button SaveStudent;
    }
}