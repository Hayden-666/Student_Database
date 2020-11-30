namespace StudentDatabaseCS
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.firstname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lastname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.avm = new System.Windows.Forms.TextBox();
            this.gender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.paid = new System.Windows.Forms.CheckBox();
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.find = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.student_info = new StudentDatabaseCS.student_info();
            this.studentinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Button();
            this.notice = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentinfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // firstname
            // 
            this.firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstname.Location = new System.Drawing.Point(232, 50);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(215, 38);
            this.firstname.TabIndex = 1;
            this.firstname.KeyUp += new System.Windows.Forms.KeyEventHandler(this.firstname_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(496, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // lastname
            // 
            this.lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastname.Location = new System.Drawing.Point(688, 50);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(215, 38);
            this.lastname.TabIndex = 3;
            this.lastname.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lastname_Keyup);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(112, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "DOB";

            // 
            // avm
            // 
            this.avm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avm.Location = new System.Drawing.Point(232, 217);
            this.avm.Name = "avm";
            this.avm.Size = new System.Drawing.Size(215, 38);
            this.avm.TabIndex = 8;
            this.avm.KeyUp += new System.Windows.Forms.KeyEventHandler(this.avm_KeyUp);
            // 
            // gender
            // 
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "other"});
            this.gender.Location = new System.Drawing.Point(690, 220);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(194, 33);
            this.gender.TabIndex = 9;
            this.gender.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(112, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 31);
            this.label5.TabIndex = 11;
            this.label5.Text = "AVM";

            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(550, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 31);
            this.label6.TabIndex = 12;
            this.label6.Text = "Gender";

            // 
            // paid
            // 
            this.paid.AutoSize = true;
            this.paid.BackColor = System.Drawing.Color.Transparent;
            this.paid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paid.Location = new System.Drawing.Point(803, 135);
            this.paid.Name = "paid";
            this.paid.Size = new System.Drawing.Size(100, 35);
            this.paid.TabIndex = 13;
            this.paid.Text = "Paid";
            this.paid.UseVisualStyleBackColor = false;
            this.paid.CheckedChanged += new System.EventHandler(this.paid_CheckedChanged);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.SystemColors.Control;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(237, 272);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(158, 58);
            this.add.TabIndex = 17;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(793, 272);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(158, 58);
            this.delete.TabIndex = 18;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // find
            // 
            this.find.BackColor = System.Drawing.SystemColors.Control;
            this.find.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.find.Location = new System.Drawing.Point(422, 272);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(158, 58);
            this.find.TabIndex = 19;
            this.find.Text = "Update";
            this.find.UseVisualStyleBackColor = false;
            this.find.Click += new System.EventHandler(this.update_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 343);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1071, 292);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // student_info
            // 
            this.student_info.DataSetName = "student_info";
            this.student_info.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentinfoBindingSource
            // 
            this.studentinfoBindingSource.DataSource = this.student_info;
            this.studentinfoBindingSource.Position = 0;
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(43, 289);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(182, 31);
            this.user.TabIndex = 22;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(232, 135);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(437, 35);
            this.dateTimePicker1.TabIndex = 23;

            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(38, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "Your account:";
            // 
            // Reset
            // 
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.Location = new System.Drawing.Point(972, 272);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(158, 58);
            this.Reset.TabIndex = 26;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // notice
            // 
            this.notice.AutoSize = true;
            this.notice.BackColor = System.Drawing.Color.Transparent;
            this.notice.Location = new System.Drawing.Point(232, 16);
            this.notice.Name = "notice";
            this.notice.Size = new System.Drawing.Size(0, 25);
            this.notice.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(607, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 58);
            this.button1.TabIndex = 28;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StudentDatabaseCS.Properties.Resources.download;
            this.ClientSize = new System.Drawing.Size(1142, 647);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.notice);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.user);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.find);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.paid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.avm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentinfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox avm;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox paid;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource studentinfoBindingSource;
        private student_info student_info;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label notice;
        private System.Windows.Forms.Button button1;
    }
}