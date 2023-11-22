namespace DataBasesLab10
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Academic_Group_Box = new System.Windows.Forms.TextBox();
            this.Hours_Box = new System.Windows.Forms.TextBox();
            this.Semester_Box = new System.Windows.Forms.TextBox();
            this.Teacher_Box = new System.Windows.Forms.TextBox();
            this.Subject_Type_Box = new System.Windows.Forms.TextBox();
            this.Specialization_Box = new System.Windows.Forms.TextBox();
            this.Subject_Box = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Add_Btn = new System.Windows.Forms.Button();
            this.Update_Btn = new System.Windows.Forms.Button();
            this.Delete_Btn = new System.Windows.Forms.Button();
            this.Load_Btn = new System.Windows.Forms.Button();
            this.Search_Box = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.Update_Id_Box = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(277, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(751, 348);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Update_Id_Box);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.Academic_Group_Box);
            this.groupBox1.Controls.Add(this.Hours_Box);
            this.groupBox1.Controls.Add(this.Semester_Box);
            this.groupBox1.Controls.Add(this.Teacher_Box);
            this.groupBox1.Controls.Add(this.Subject_Type_Box);
            this.groupBox1.Controls.Add(this.Specialization_Box);
            this.groupBox1.Controls.Add(this.Subject_Box);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 262);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Update subject";
            // 
            // Academic_Group_Box
            // 
            this.Academic_Group_Box.Location = new System.Drawing.Point(124, 210);
            this.Academic_Group_Box.Name = "Academic_Group_Box";
            this.Academic_Group_Box.Size = new System.Drawing.Size(128, 20);
            this.Academic_Group_Box.TabIndex = 13;
            // 
            // Hours_Box
            // 
            this.Hours_Box.Location = new System.Drawing.Point(124, 180);
            this.Hours_Box.Name = "Hours_Box";
            this.Hours_Box.Size = new System.Drawing.Size(128, 20);
            this.Hours_Box.TabIndex = 12;
            // 
            // Semester_Box
            // 
            this.Semester_Box.Location = new System.Drawing.Point(124, 149);
            this.Semester_Box.Name = "Semester_Box";
            this.Semester_Box.Size = new System.Drawing.Size(128, 20);
            this.Semester_Box.TabIndex = 11;
            // 
            // Teacher_Box
            // 
            this.Teacher_Box.Location = new System.Drawing.Point(124, 120);
            this.Teacher_Box.Name = "Teacher_Box";
            this.Teacher_Box.Size = new System.Drawing.Size(128, 20);
            this.Teacher_Box.TabIndex = 10;
            // 
            // Subject_Type_Box
            // 
            this.Subject_Type_Box.Location = new System.Drawing.Point(124, 90);
            this.Subject_Type_Box.Name = "Subject_Type_Box";
            this.Subject_Type_Box.Size = new System.Drawing.Size(128, 20);
            this.Subject_Type_Box.TabIndex = 9;
            // 
            // Specialization_Box
            // 
            this.Specialization_Box.Location = new System.Drawing.Point(124, 61);
            this.Specialization_Box.Name = "Specialization_Box";
            this.Specialization_Box.Size = new System.Drawing.Size(128, 20);
            this.Specialization_Box.TabIndex = 8;
            // 
            // Subject_Box
            // 
            this.Subject_Box.Location = new System.Drawing.Point(124, 32);
            this.Subject_Box.Name = "Subject_Box";
            this.Subject_Box.Size = new System.Drawing.Size(128, 20);
            this.Subject_Box.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Academic Group";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Hours";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Semester";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Teacher";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subject Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Specialization";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject";
            // 
            // Add_Btn
            // 
            this.Add_Btn.Location = new System.Drawing.Point(12, 280);
            this.Add_Btn.Name = "Add_Btn";
            this.Add_Btn.Size = new System.Drawing.Size(129, 28);
            this.Add_Btn.TabIndex = 2;
            this.Add_Btn.Text = "Add subject";
            this.Add_Btn.UseVisualStyleBackColor = true;
            this.Add_Btn.Click += new System.EventHandler(this.Add_Btn_Click);
            // 
            // Update_Btn
            // 
            this.Update_Btn.Location = new System.Drawing.Point(147, 280);
            this.Update_Btn.Name = "Update_Btn";
            this.Update_Btn.Size = new System.Drawing.Size(124, 28);
            this.Update_Btn.TabIndex = 3;
            this.Update_Btn.Text = "Update";
            this.Update_Btn.UseVisualStyleBackColor = true;
            this.Update_Btn.Click += new System.EventHandler(this.Update_Btn_Click);
            // 
            // Delete_Btn
            // 
            this.Delete_Btn.Location = new System.Drawing.Point(901, 9);
            this.Delete_Btn.Name = "Delete_Btn";
            this.Delete_Btn.Size = new System.Drawing.Size(116, 28);
            this.Delete_Btn.TabIndex = 4;
            this.Delete_Btn.Text = "Delete";
            this.Delete_Btn.UseVisualStyleBackColor = true;
            this.Delete_Btn.Click += new System.EventHandler(this.Delete_Btn_Click);
            // 
            // Load_Btn
            // 
            this.Load_Btn.Location = new System.Drawing.Point(647, 9);
            this.Load_Btn.Name = "Load_Btn";
            this.Load_Btn.Size = new System.Drawing.Size(120, 28);
            this.Load_Btn.TabIndex = 5;
            this.Load_Btn.Text = "Load Subjects";
            this.Load_Btn.UseVisualStyleBackColor = true;
            this.Load_Btn.Click += new System.EventHandler(this.Load_Btn_Click);
            // 
            // Search_Box
            // 
            this.Search_Box.Location = new System.Drawing.Point(367, 14);
            this.Search_Box.Name = "Search_Box";
            this.Search_Box.Size = new System.Drawing.Size(150, 20);
            this.Search_Box.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(279, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Search by Id";
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(523, 9);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(88, 28);
            this.SearchBtn.TabIndex = 15;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(121, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "ID";
            // 
            // Update_Id_Box
            // 
            this.Update_Id_Box.Location = new System.Drawing.Point(145, 239);
            this.Update_Id_Box.Name = "Update_Id_Box";
            this.Update_Id_Box.Size = new System.Drawing.Size(107, 20);
            this.Update_Id_Box.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 28);
            this.button1.TabIndex = 16;
            this.button1.Text = "Clear Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 400);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Search_Box);
            this.Controls.Add(this.Load_Btn);
            this.Controls.Add(this.Delete_Btn);
            this.Controls.Add(this.Update_Btn);
            this.Controls.Add(this.Add_Btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Subject_Box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Academic_Group_Box;
        private System.Windows.Forms.TextBox Hours_Box;
        private System.Windows.Forms.TextBox Semester_Box;
        private System.Windows.Forms.TextBox Teacher_Box;
        private System.Windows.Forms.TextBox Subject_Type_Box;
        private System.Windows.Forms.TextBox Specialization_Box;
        private System.Windows.Forms.Button Add_Btn;
        private System.Windows.Forms.Button Update_Btn;
        private System.Windows.Forms.Button Delete_Btn;
        private System.Windows.Forms.Button Load_Btn;
        private System.Windows.Forms.TextBox Search_Box;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Update_Id_Box;
        private System.Windows.Forms.Button button1;
    }
}

