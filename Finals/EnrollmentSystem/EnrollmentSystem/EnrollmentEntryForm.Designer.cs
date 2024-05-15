namespace EnrollmentSystem
{
    partial class EnrollmentEntryForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.IdTbox = new System.Windows.Forms.TextBox();
            this.CourseTbox = new System.Windows.Forms.TextBox();
            this.YearTbox = new System.Windows.Forms.TextBox();
            this.NameTbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.EdpTbox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enrollment Entry Form";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Pink;
            this.groupBox1.Controls.Add(this.IdTbox);
            this.groupBox1.Controls.Add(this.CourseTbox);
            this.groupBox1.Controls.Add(this.YearTbox);
            this.groupBox1.Controls.Add(this.NameTbox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(226, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 192);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Information";
            // 
            // IdTbox
            // 
            this.IdTbox.BackColor = System.Drawing.Color.Bisque;
            this.IdTbox.Location = new System.Drawing.Point(128, 45);
            this.IdTbox.Name = "IdTbox";
            this.IdTbox.Size = new System.Drawing.Size(122, 20);
            this.IdTbox.TabIndex = 7;
            // 
            // CourseTbox
            // 
            this.CourseTbox.BackColor = System.Drawing.Color.Bisque;
            this.CourseTbox.Location = new System.Drawing.Point(128, 112);
            this.CourseTbox.Name = "CourseTbox";
            this.CourseTbox.Size = new System.Drawing.Size(100, 20);
            this.CourseTbox.TabIndex = 6;
            // 
            // YearTbox
            // 
            this.YearTbox.BackColor = System.Drawing.Color.Bisque;
            this.YearTbox.Location = new System.Drawing.Point(128, 152);
            this.YearTbox.Name = "YearTbox";
            this.YearTbox.Size = new System.Drawing.Size(100, 20);
            this.YearTbox.TabIndex = 5;
            // 
            // NameTbox
            // 
            this.NameTbox.BackColor = System.Drawing.Color.Bisque;
            this.NameTbox.Location = new System.Drawing.Point(128, 77);
            this.NameTbox.Name = "NameTbox";
            this.NameTbox.Size = new System.Drawing.Size(137, 20);
            this.NameTbox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Course";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID Number";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Bisque;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(12, 320);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(733, 111);
            this.dataGridView1.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "EDP Code";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Subject Code";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Start Time";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "End Time";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Days";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Rooms";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Units";
            this.Column7.Name = "Column7";
            // 
            // SButton
            // 
            this.SButton.Location = new System.Drawing.Point(655, 456);
            this.SButton.Name = "SButton";
            this.SButton.Size = new System.Drawing.Size(75, 23);
            this.SButton.TabIndex = 3;
            this.SButton.Text = "Save";
            this.SButton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "EDP Code";
            // 
            // EdpTbox
            // 
            this.EdpTbox.BackColor = System.Drawing.Color.Bisque;
            this.EdpTbox.Location = new System.Drawing.Point(125, 284);
            this.EdpTbox.Name = "EdpTbox";
            this.EdpTbox.Size = new System.Drawing.Size(100, 20);
            this.EdpTbox.TabIndex = 5;
            // 
            // EnrollmentEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(757, 491);
            this.Controls.Add(this.EdpTbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "EnrollmentEntryForm";
            this.Text = "EnrollmentEntryForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox IdTbox;
        private System.Windows.Forms.TextBox CourseTbox;
        private System.Windows.Forms.TextBox YearTbox;
        private System.Windows.Forms.TextBox NameTbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button SButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EdpTbox;
    }
}