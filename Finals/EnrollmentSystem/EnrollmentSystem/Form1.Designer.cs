namespace EnrollmentSystem
{
    partial class Form1
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
            this.Information = new System.Windows.Forms.GroupBox();
            this.CategoryCbox = new System.Windows.Forms.ComboBox();
            this.CurriculumYearTbox = new System.Windows.Forms.TextBox();
            this.CourseCbox = new System.Windows.Forms.ComboBox();
            this.OfferingCbox = new System.Windows.Forms.ComboBox();
            this.UnitsTbox = new System.Windows.Forms.TextBox();
            this.DescriptionTbox = new System.Windows.Forms.TextBox();
            this.SubjectcodeTbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SubjectDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScodeTbox = new System.Windows.Forms.TextBox();
            this.CoRb = new System.Windows.Forms.RadioButton();
            this.PreRb = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.Information.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Information
            // 
            this.Information.BackColor = System.Drawing.Color.Pink;
            this.Information.Controls.Add(this.CategoryCbox);
            this.Information.Controls.Add(this.CurriculumYearTbox);
            this.Information.Controls.Add(this.CourseCbox);
            this.Information.Controls.Add(this.OfferingCbox);
            this.Information.Controls.Add(this.UnitsTbox);
            this.Information.Controls.Add(this.DescriptionTbox);
            this.Information.Controls.Add(this.SubjectcodeTbox);
            this.Information.Controls.Add(this.label8);
            this.Information.Controls.Add(this.label7);
            this.Information.Controls.Add(this.label6);
            this.Information.Controls.Add(this.label5);
            this.Information.Controls.Add(this.label4);
            this.Information.Controls.Add(this.label3);
            this.Information.Controls.Add(this.label2);
            this.Information.Location = new System.Drawing.Point(60, 88);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(293, 333);
            this.Information.TabIndex = 1;
            this.Information.TabStop = false;
            this.Information.Text = "Information";
            // 
            // CategoryCbox
            // 
            this.CategoryCbox.BackColor = System.Drawing.Color.Bisque;
            this.CategoryCbox.FormattingEnabled = true;
            this.CategoryCbox.Items.AddRange(new object[] {
            "Lab",
            "Lec"});
            this.CategoryCbox.Location = new System.Drawing.Point(141, 194);
            this.CategoryCbox.Name = "CategoryCbox";
            this.CategoryCbox.Size = new System.Drawing.Size(121, 21);
            this.CategoryCbox.TabIndex = 14;
            // 
            // CurriculumYearTbox
            // 
            this.CurriculumYearTbox.BackColor = System.Drawing.Color.Bisque;
            this.CurriculumYearTbox.Location = new System.Drawing.Point(141, 268);
            this.CurriculumYearTbox.Name = "CurriculumYearTbox";
            this.CurriculumYearTbox.Size = new System.Drawing.Size(100, 20);
            this.CurriculumYearTbox.TabIndex = 13;
            // 
            // CourseCbox
            // 
            this.CourseCbox.AutoCompleteCustomSource.AddRange(new string[] {
            "BSIT",
            "BSIS",
            "ACT",
            "BSHM",
            "BSN",
            "BSMT"});
            this.CourseCbox.BackColor = System.Drawing.Color.Bisque;
            this.CourseCbox.FormattingEnabled = true;
            this.CourseCbox.Items.AddRange(new object[] {
            "BSIT",
            "BSIS",
            "ACT"});
            this.CourseCbox.Location = new System.Drawing.Point(141, 235);
            this.CourseCbox.Name = "CourseCbox";
            this.CourseCbox.Size = new System.Drawing.Size(121, 21);
            this.CourseCbox.TabIndex = 12;
            // 
            // OfferingCbox
            // 
            this.OfferingCbox.BackColor = System.Drawing.Color.Bisque;
            this.OfferingCbox.FormattingEnabled = true;
            this.OfferingCbox.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.OfferingCbox.Location = new System.Drawing.Point(141, 154);
            this.OfferingCbox.Name = "OfferingCbox";
            this.OfferingCbox.Size = new System.Drawing.Size(121, 21);
            this.OfferingCbox.TabIndex = 10;
            // 
            // UnitsTbox
            // 
            this.UnitsTbox.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.UnitsTbox.Location = new System.Drawing.Point(141, 113);
            this.UnitsTbox.Name = "UnitsTbox";
            this.UnitsTbox.Size = new System.Drawing.Size(100, 20);
            this.UnitsTbox.TabIndex = 9;
            // 
            // DescriptionTbox
            // 
            this.DescriptionTbox.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.DescriptionTbox.Location = new System.Drawing.Point(141, 78);
            this.DescriptionTbox.Name = "DescriptionTbox";
            this.DescriptionTbox.Size = new System.Drawing.Size(100, 20);
            this.DescriptionTbox.TabIndex = 8;
            // 
            // SubjectcodeTbox
            // 
            this.SubjectcodeTbox.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.SubjectcodeTbox.Location = new System.Drawing.Point(141, 37);
            this.SubjectcodeTbox.Name = "SubjectcodeTbox";
            this.SubjectcodeTbox.Size = new System.Drawing.Size(100, 20);
            this.SubjectcodeTbox.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Bright", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Curriculum Year";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Bright", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Course Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Bright", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Offering";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Units";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Subject Code";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Pink;
            this.groupBox2.Controls.Add(this.SubjectDataGridView);
            this.groupBox2.Controls.Add(this.ScodeTbox);
            this.groupBox2.Controls.Add(this.CoRb);
            this.groupBox2.Controls.Add(this.PreRb);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(359, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(483, 235);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Requisite Information";
            // 
            // SubjectDataGridView
            // 
            this.SubjectDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.SubjectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubjectDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.SubjectDataGridView.Location = new System.Drawing.Point(24, 93);
            this.SubjectDataGridView.Name = "SubjectDataGridView";
            this.SubjectDataGridView.Size = new System.Drawing.Size(440, 97);
            this.SubjectDataGridView.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Subject Code";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Description";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Units";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Co/Pre";
            this.Column4.Name = "Column4";
            // 
            // ScodeTbox
            // 
            this.ScodeTbox.BackColor = System.Drawing.Color.Bisque;
            this.ScodeTbox.Location = new System.Drawing.Point(148, 49);
            this.ScodeTbox.Name = "ScodeTbox";
            this.ScodeTbox.Size = new System.Drawing.Size(100, 20);
            this.ScodeTbox.TabIndex = 3;
            this.ScodeTbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ScodeTbox_KeyPress);
            // 
            // CoRb
            // 
            this.CoRb.AutoSize = true;
            this.CoRb.Location = new System.Drawing.Point(320, 61);
            this.CoRb.Name = "CoRb";
            this.CoRb.Size = new System.Drawing.Size(80, 17);
            this.CoRb.TabIndex = 2;
            this.CoRb.TabStop = true;
            this.CoRb.Text = "Co-requisite";
            this.CoRb.UseVisualStyleBackColor = true;
            // 
            // PreRb
            // 
            this.PreRb.AutoSize = true;
            this.PreRb.Location = new System.Drawing.Point(317, 38);
            this.PreRb.Name = "PreRb";
            this.PreRb.Size = new System.Drawing.Size(83, 17);
            this.PreRb.TabIndex = 1;
            this.PreRb.TabStop = true;
            this.PreRb.Text = "Pre-requisite";
            this.PreRb.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject Code";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(365, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 23);
            this.label9.TabIndex = 3;
            this.label9.Text = "Subject Entry";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(825, 472);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(744, 472);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(912, 524);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Information);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Information.ResumeLayout(false);
            this.Information.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox Information;
        private System.Windows.Forms.ComboBox CategoryCbox;
        private System.Windows.Forms.TextBox CurriculumYearTbox;
        private System.Windows.Forms.ComboBox CourseCbox;
        private System.Windows.Forms.ComboBox OfferingCbox;
        private System.Windows.Forms.TextBox UnitsTbox;
        private System.Windows.Forms.TextBox DescriptionTbox;
        private System.Windows.Forms.TextBox SubjectcodeTbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton CoRb;
        private System.Windows.Forms.RadioButton PreRb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ScodeTbox;
        private System.Windows.Forms.DataGridView SubjectDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
    }
}

