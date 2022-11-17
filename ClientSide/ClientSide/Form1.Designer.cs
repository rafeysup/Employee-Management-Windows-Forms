namespace ClientSide
{
    partial class frm_employees
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_empname = new System.Windows.Forms.TextBox();
            this.txt_empcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_department = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btn_Get = new System.Windows.Forms.Button();
            this.dt_dob = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dt_doj = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_reportto = new System.Windows.Forms.TextBox();
            this.dt_resigneddate = new System.Windows.Forms.DateTimePicker();
            this.txt_contactnumber = new System.Windows.Forms.TextBox();
            this.chk_resigned = new System.Windows.Forms.CheckBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.txt_empid = new System.Windows.Forms.TextBox();
            this.btn_reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(55, 254);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(713, 224);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Emp Name:";
            // 
            // txt_empname
            // 
            this.txt_empname.Location = new System.Drawing.Point(171, 67);
            this.txt_empname.Name = "txt_empname";
            this.txt_empname.Size = new System.Drawing.Size(110, 22);
            this.txt_empname.TabIndex = 2;
            // 
            // txt_empcode
            // 
            this.txt_empcode.Location = new System.Drawing.Point(171, 33);
            this.txt_empcode.Name = "txt_empcode";
            this.txt_empcode.Size = new System.Drawing.Size(110, 22);
            this.txt_empcode.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Emp Code:";
            // 
            // txt_department
            // 
            this.txt_department.Location = new System.Drawing.Point(567, 36);
            this.txt_department.Name = "txt_department";
            this.txt_department.Size = new System.Drawing.Size(112, 22);
            this.txt_department.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date of Birth:";
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(54, 199);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(75, 23);
            this.btn_Insert.TabIndex = 7;
            this.btn_Insert.Text = "Insert";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_Get
            // 
            this.btn_Get.Location = new System.Drawing.Point(147, 199);
            this.btn_Get.Name = "btn_Get";
            this.btn_Get.Size = new System.Drawing.Size(75, 23);
            this.btn_Get.TabIndex = 8;
            this.btn_Get.Text = "Get";
            this.btn_Get.UseVisualStyleBackColor = true;
            this.btn_Get.Click += new System.EventHandler(this.btn_Get_Click);
            // 
            // dt_dob
            // 
            this.dt_dob.CustomFormat = "MM/dd/yyyy";
            this.dt_dob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_dob.Location = new System.Drawing.Point(171, 102);
            this.dt_dob.Name = "dt_dob";
            this.dt_dob.Size = new System.Drawing.Size(110, 22);
            this.dt_dob.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Date of Joining:";
            // 
            // dt_doj
            // 
            this.dt_doj.CustomFormat = "MM/dd/yyyy";
            this.dt_doj.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_doj.Location = new System.Drawing.Point(171, 141);
            this.dt_doj.Name = "dt_doj";
            this.dt_doj.Size = new System.Drawing.Size(110, 22);
            this.dt_doj.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(436, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Department:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(436, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Report To:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(436, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Resigned:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(436, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Contact Number:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(436, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Resigned Date:";
            // 
            // txt_reportto
            // 
            this.txt_reportto.Location = new System.Drawing.Point(567, 72);
            this.txt_reportto.Name = "txt_reportto";
            this.txt_reportto.Size = new System.Drawing.Size(112, 22);
            this.txt_reportto.TabIndex = 17;
            // 
            // dt_resigneddate
            // 
            this.dt_resigneddate.CustomFormat = "MM/dd/yyyy";
            this.dt_resigneddate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_resigneddate.Location = new System.Drawing.Point(567, 194);
            this.dt_resigneddate.Name = "dt_resigneddate";
            this.dt_resigneddate.Size = new System.Drawing.Size(112, 22);
            this.dt_resigneddate.TabIndex = 18;
            // 
            // txt_contactnumber
            // 
            this.txt_contactnumber.Location = new System.Drawing.Point(567, 116);
            this.txt_contactnumber.Name = "txt_contactnumber";
            this.txt_contactnumber.Size = new System.Drawing.Size(112, 22);
            this.txt_contactnumber.TabIndex = 19;
            // 
            // chk_resigned
            // 
            this.chk_resigned.AutoSize = true;
            this.chk_resigned.Location = new System.Drawing.Point(567, 160);
            this.chk_resigned.Name = "chk_resigned";
            this.chk_resigned.Size = new System.Drawing.Size(18, 17);
            this.chk_resigned.TabIndex = 20;
            this.chk_resigned.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(237, 199);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 21;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(332, 199);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 22;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // txt_empid
            // 
            this.txt_empid.Location = new System.Drawing.Point(621, 160);
            this.txt_empid.Name = "txt_empid";
            this.txt_empid.Size = new System.Drawing.Size(57, 22);
            this.txt_empid.TabIndex = 23;
            this.txt_empid.Visible = false;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(693, 217);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 24;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // frm_employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 490);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.txt_empid);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.chk_resigned);
            this.Controls.Add(this.txt_contactnumber);
            this.Controls.Add(this.dt_resigneddate);
            this.Controls.Add(this.txt_reportto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dt_doj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dt_dob);
            this.Controls.Add(this.btn_Get);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.txt_department);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_empcode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_empname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_employees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_empname;
        private System.Windows.Forms.TextBox txt_empcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_department;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_Get;
        private System.Windows.Forms.DateTimePicker dt_dob;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dt_doj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_reportto;
        private System.Windows.Forms.DateTimePicker dt_resigneddate;
        private System.Windows.Forms.TextBox txt_contactnumber;
        private System.Windows.Forms.CheckBox chk_resigned;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox txt_empid;
        private System.Windows.Forms.Button btn_reset;

    }
}

