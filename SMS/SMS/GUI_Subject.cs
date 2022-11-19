using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;
using System.Data;

namespace SMS
{
    public partial class GUI_Subject : Form
    {
        BUS_Student busStudent = new BUS_Student();
        BUS_Subject busSubject = new BUS_Subject();
        bool tf, tf1;
        DataTable dtbStudent;
        public GUI_Subject()
        {
            InitializeComponent();
            tf = tf1 = true;
            Lock_Unlock(tf);
            Lock_Unlock1(tf1);
            dtbStudent = busStudent.getStudent();
        }
        void Lock_Unlock(bool tf)
        {
            bxtNew.Enabled = tf;
            btnAdd.Enabled = txtSbjectName.Enabled = txtEmail.Enabled = !tf;
        }
        void Lock_Unlock1(bool tf1)
        {
            dgvSubject.Enabled = tf1;
            btnDelete.Enabled = btnUpdate.Enabled = txtEmail.Enabled = txtSbjectName.Enabled = !tf1;
        }

        private void bxtNew_Click(object sender, EventArgs e)
        {
            if (tf1)
            {
                tf = !tf;
                Lock_Unlock(tf);
               
                txtSbjectName.Focus();
            }
            else MessageBox.Show("updating or deleteting !\nClick Reset to onther thing.", "Information");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtSbjectName.Text != "" && txtEmail.Text != "")
            {
                String id = dtbStudent.Rows[int.Parse(cmbStudentName.SelectedIndex.ToString())]["id"].ToString();
                if (busSubject.insertSubject(id,txtSbjectName.Text, txtEmail.Text))
                {
                    MessageBox.Show("Insert successfull.", "information");
                    tf = !tf;
                    Lock_Unlock(tf);
                    dgvSubject.DataSource = busSubject.getSubject(id);
                }
                else
                {
                    MessageBox.Show("Inserting fail.", "information");
                }
            }
            else
            {
                MessageBox.Show("Student name or email is empty\nInput data agian.", "information");
                txtSbjectName.Focus();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void GUI_Subject_Load(object sender, EventArgs e)
        {
            for(int i=0;i< dtbStudent.Rows.Count; i++)
            {
                cmbStudentName.Items.Add(dtbStudent.Rows[i]["name"].ToString());
                cmbStudentName.Text = dtbStudent.Rows[0]["name"].ToString();
            }
            String id = dtbStudent.Rows[int.Parse(cmbStudentName.SelectedIndex.ToString())]["id"].ToString();
            dgvSubject.DataSource = busSubject.getSubject(id);
        }

        private void cmbStudentName_SelectedIndexChanged(object sender, EventArgs e)
        {
            String id = dtbStudent.Rows[int.Parse(cmbStudentName.SelectedIndex.ToString())]["id"].ToString();
            dgvSubject.DataSource = busSubject.getSubject(id);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }
    }
}
