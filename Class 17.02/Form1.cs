using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_17._02
{
    public partial class ManagementSystem : Form
    {
        public ManagementSystem()
        {
            InitializeComponent();
        }

        ListClass lc = new ListClass();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCy.DataSource = Enum.GetValues(typeof(counties));
        }

        private void btnAddStu_Click(object sender, EventArgs e)
        {
            int stuNo = int.Parse(txtStudentNo.Text);
            string fn = txtFN.Text;
            string sn = txtSN.Text;
            string cy = cmbCy.SelectedItem.ToString();
            string DOB = dtpDOB.Text;
            string ge = "Male";
            if(RdoFemale.Checked)
            {
                ge = "Female";
            }

            string stu = lc.AddStudent(stuNo, fn, sn, cy, DOB, ge);
            MessageBox.Show(stu, "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtFN.Clear();
            txtSN.Clear();
            txtStudentNo.Clear();

            

        }

        private void btnDisplayStu_Click(object sender, EventArgs e)
        {
            dgv.DataSource = false;
            dgv.DataSource = lc.myList;

            lstDisplay.Items.Clear();
            foreach (Student stu in lc.myList)
            {
                lstDisplay.Items.Add(stu.MyString());

            }




        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int searchid = int.Parse(txtSearch.Text);
                lblDisplay.Text = lc.DisplayMatch(searchid);
            }
            catch
            {
                MessageBox.Show("You musy enter an ID");
            }


        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {

                int removeID = int.Parse(txtRemove.Text);
                lblDisplay.Text = lc.DeleteMatch(removeID);

            }
            catch
            {

                MessageBox.Show("You must enter an ID");
            }
        }
    }
}
