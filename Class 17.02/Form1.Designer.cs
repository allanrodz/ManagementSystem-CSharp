
namespace Class_17._02
{
    partial class ManagementSystem
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
            this.grpPersonalDetails = new System.Windows.Forms.GroupBox();
            this.btnDisplayStu = new System.Windows.Forms.Button();
            this.btnAddStu = new System.Windows.Forms.Button();
            this.RdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.cmbCy = new System.Windows.Forms.ComboBox();
            this.txtSN = new System.Windows.Forms.TextBox();
            this.txtFN = new System.Windows.Forms.TextBox();
            this.txtStudentNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grpRemove = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtRemove = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.grpPersonalDetails.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.grpRemove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPersonalDetails
            // 
            this.grpPersonalDetails.Controls.Add(this.btnDisplayStu);
            this.grpPersonalDetails.Controls.Add(this.btnAddStu);
            this.grpPersonalDetails.Controls.Add(this.RdoFemale);
            this.grpPersonalDetails.Controls.Add(this.rdoMale);
            this.grpPersonalDetails.Controls.Add(this.dtpDOB);
            this.grpPersonalDetails.Controls.Add(this.cmbCy);
            this.grpPersonalDetails.Controls.Add(this.txtSN);
            this.grpPersonalDetails.Controls.Add(this.txtFN);
            this.grpPersonalDetails.Controls.Add(this.txtStudentNo);
            this.grpPersonalDetails.Controls.Add(this.label6);
            this.grpPersonalDetails.Controls.Add(this.label5);
            this.grpPersonalDetails.Controls.Add(this.label4);
            this.grpPersonalDetails.Controls.Add(this.label3);
            this.grpPersonalDetails.Controls.Add(this.label2);
            this.grpPersonalDetails.Controls.Add(this.label1);
            this.grpPersonalDetails.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPersonalDetails.ForeColor = System.Drawing.Color.Red;
            this.grpPersonalDetails.Location = new System.Drawing.Point(9, 10);
            this.grpPersonalDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpPersonalDetails.Name = "grpPersonalDetails";
            this.grpPersonalDetails.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpPersonalDetails.Size = new System.Drawing.Size(340, 309);
            this.grpPersonalDetails.TabIndex = 0;
            this.grpPersonalDetails.TabStop = false;
            this.grpPersonalDetails.Text = "PersonalDetails";
            // 
            // btnDisplayStu
            // 
            this.btnDisplayStu.Location = new System.Drawing.Point(184, 267);
            this.btnDisplayStu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDisplayStu.Name = "btnDisplayStu";
            this.btnDisplayStu.Size = new System.Drawing.Size(86, 28);
            this.btnDisplayStu.TabIndex = 14;
            this.btnDisplayStu.Text = "Display Students";
            this.btnDisplayStu.UseVisualStyleBackColor = true;
            this.btnDisplayStu.Click += new System.EventHandler(this.btnDisplayStu_Click);
            // 
            // btnAddStu
            // 
            this.btnAddStu.Location = new System.Drawing.Point(74, 267);
            this.btnAddStu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddStu.Name = "btnAddStu";
            this.btnAddStu.Size = new System.Drawing.Size(95, 28);
            this.btnAddStu.TabIndex = 13;
            this.btnAddStu.Text = "Add Student";
            this.btnAddStu.UseVisualStyleBackColor = true;
            this.btnAddStu.Click += new System.EventHandler(this.btnAddStu_Click);
            // 
            // RdoFemale
            // 
            this.RdoFemale.AutoSize = true;
            this.RdoFemale.Location = new System.Drawing.Point(233, 226);
            this.RdoFemale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RdoFemale.Name = "RdoFemale";
            this.RdoFemale.Size = new System.Drawing.Size(67, 19);
            this.RdoFemale.TabIndex = 12;
            this.RdoFemale.Text = "Female";
            this.RdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Checked = true;
            this.rdoMale.Location = new System.Drawing.Point(163, 226);
            this.rdoMale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(55, 19);
            this.rdoMale.TabIndex = 11;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(74, 188);
            this.dtpDOB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(262, 26);
            this.dtpDOB.TabIndex = 10;
            // 
            // cmbCy
            // 
            this.cmbCy.FormattingEnabled = true;
            this.cmbCy.Location = new System.Drawing.Point(163, 153);
            this.cmbCy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCy.Name = "cmbCy";
            this.cmbCy.Size = new System.Drawing.Size(92, 23);
            this.cmbCy.TabIndex = 9;
            // 
            // txtSN
            // 
            this.txtSN.Location = new System.Drawing.Point(163, 117);
            this.txtSN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSN.Name = "txtSN";
            this.txtSN.Size = new System.Drawing.Size(130, 26);
            this.txtSN.TabIndex = 8;
            // 
            // txtFN
            // 
            this.txtFN.Location = new System.Drawing.Point(163, 84);
            this.txtFN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFN.Name = "txtFN";
            this.txtFN.Size = new System.Drawing.Size(130, 26);
            this.txtFN.TabIndex = 7;
            // 
            // txtStudentNo
            // 
            this.txtStudentNo.Location = new System.Drawing.Point(163, 50);
            this.txtStudentNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStudentNo.Name = "txtStudentNo";
            this.txtStudentNo.Size = new System.Drawing.Size(130, 26);
            this.txtStudentNo.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 226);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 193);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "DOB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "County";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Student Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "First  Name";
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.txtSearch);
            this.grpSearch.Controls.Add(this.label7);
            this.grpSearch.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSearch.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.grpSearch.Location = new System.Drawing.Point(353, 24);
            this.grpSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpSearch.Size = new System.Drawing.Size(150, 129);
            this.grpSearch.TabIndex = 1;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(38, 81);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(73, 37);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(4, 51);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(142, 26);
            this.txtSearch.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 34);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Enter ID";
            // 
            // grpRemove
            // 
            this.grpRemove.Controls.Add(this.btnRemove);
            this.grpRemove.Controls.Add(this.txtRemove);
            this.grpRemove.Controls.Add(this.label8);
            this.grpRemove.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grpRemove.Location = new System.Drawing.Point(353, 167);
            this.grpRemove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpRemove.Name = "grpRemove";
            this.grpRemove.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpRemove.Size = new System.Drawing.Size(150, 151);
            this.grpRemove.TabIndex = 2;
            this.grpRemove.TabStop = false;
            this.grpRemove.Text = "Remove";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(38, 87);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(73, 39);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtRemove
            // 
            this.txtRemove.Location = new System.Drawing.Point(4, 57);
            this.txtRemove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRemove.Name = "txtRemove";
            this.txtRemove.Size = new System.Drawing.Size(142, 26);
            this.txtRemove.TabIndex = 3;
            this.txtRemove.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 36);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Enter ID";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(9, 432);
            this.dgv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(494, 78);
            this.dgv.TabIndex = 3;
            // 
            // lstDisplay
            // 
            this.lstDisplay.FormattingEnabled = true;
            this.lstDisplay.Location = new System.Drawing.Point(9, 359);
            this.lstDisplay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(495, 69);
            this.lstDisplay.TabIndex = 15;
            // 
            // lblDisplay
            // 
            this.lblDisplay.BackColor = System.Drawing.Color.Yellow;
            this.lblDisplay.Location = new System.Drawing.Point(111, 337);
            this.lblDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(322, 20);
            this.lblDisplay.TabIndex = 16;
            // 
            // ManagementSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 526);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.lstDisplay);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.grpRemove);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.grpPersonalDetails);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ManagementSystem";
            this.Text = "ManagementSystem";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpPersonalDetails.ResumeLayout(false);
            this.grpPersonalDetails.PerformLayout();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.grpRemove.ResumeLayout(false);
            this.grpRemove.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPersonalDetails;
        private System.Windows.Forms.Button btnAddStu;
        private System.Windows.Forms.RadioButton RdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.ComboBox cmbCy;
        private System.Windows.Forms.TextBox txtSN;
        private System.Windows.Forms.TextBox txtFN;
        private System.Windows.Forms.TextBox txtStudentNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.TextBox txtRemove;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grpRemove;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnDisplayStu;
        private System.Windows.Forms.ListBox lstDisplay;
        private System.Windows.Forms.Label lblDisplay;
    }
}

