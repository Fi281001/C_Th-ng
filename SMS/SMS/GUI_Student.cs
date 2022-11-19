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

namespace SMS
{
    public partial class GUI_Student : Form
    {
        BUS_Student busStudent = new BUS_Student();
        bool tf, tf1;
        int id;
        public GUI_Student()
        {
           InitializeComponent();
            tf = tf1 = true;
            Lock_Unlock(tf);
            Lock_Unlock1(tf1);
        }

        private void GUI_Student_Load(object sender, EventArgs e)
        {
            gvStudent.DataSource = busStudent.getStudent();
        }

        private void bxtNew_Click(object sender, EventArgs e)
        {
            if (tf1)
            {
                tf = !tf;
                Lock_Unlock(tf);
                txtEmail.Text = txtStudentName.Text = "";
                txtStudentName.Focus();
            }
            else MessageBox.Show("updating or deleteting !\nClick Reset to onther thing.", "Information");
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtStudentName.Text!="" && txtEmail.Text != "")
            {
                if(busStudent.insertStudent(txtStudentName.Text, txtEmail.Text))
                {
                    MessageBox.Show("Insert successfull.", "information");
                    tf = !tf;
                    Lock_Unlock(tf);
                    gvStudent.DataSource = busStudent.getStudent();
                }
                else
                {
                    MessageBox.Show("Inserting fail.", "information");
                }
            }
            else
            {
                MessageBox.Show("Student name or email is empty\nInput data agian.", "information");
                txtStudentName.Focus();
            }

           
            
        }
        void Lock_Unlock(bool tf)
        {
            bxtNew.Enabled = tf;
            btnAdd.Enabled = txtEmail.Enabled = txtStudentName.Enabled = !tf;
        }
        void Lock_Unlock1(bool tf1)
        {
            gvStudent.Enabled = tf1;
             btnDelete.Enabled = btnUpdate.Enabled = txtEmail.Enabled = txtStudentName.Enabled = !tf1;
        }

        private void gvStudent_Click(object sender, EventArgs e)
        {
            if (tf)
            {
                    int i = gvStudent.CurrentRow.Index;
                    id = int.Parse(gvStudent[0, i].Value.ToString());
                    txtStudentName.Text = gvStudent[1, i].Value.ToString();
                    txtEmail.Text = gvStudent[2, i].Value.ToString();
                    tf1 = !tf1;
                    Lock_Unlock1(tf1);
            }
            else MessageBox.Show("Inserting !\nClick Reset to onther thing.", "Information");
          
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtStudentName.Text != "" && txtEmail.Text != "")
            {
               
                if (busStudent.updateStudent(id,txtStudentName.Text,txtEmail.Text))
                {
                    MessageBox.Show("update successfull.", "information");
                    tf1 = !tf1;
                    Lock_Unlock1(tf1);
                    gvStudent.DataSource = busStudent.getStudent();
                }
                else
                {
                    MessageBox.Show("Update fail.", "information");
                }
            }
            else
            {
                MessageBox.Show("Student name or email is empty\nInput data agian.", "information");
                txtStudentName.Focus();
            }
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (busStudent.deleteStudent(id))
            {
                MessageBox.Show("delete successfull.", "information");
                tf1 = !tf1;
                Lock_Unlock1(tf1);
                gvStudent.DataSource = busStudent.getStudent();
            }
            else
            {
                MessageBox.Show("delete fail.", "information");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GUI_Subject x = new GUI_Subject();
            x.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
