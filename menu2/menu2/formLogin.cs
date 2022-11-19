using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu2
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
           
            if(textBox1.Text =="abc" && textBox2.Text == "123")
            {
                mySave.KT = !mySave.KT;
                MessageBox.Show("dang nhap thanth cong");
                Close();
            }
            else
            {
                MessageBox.Show("dang nhap that bai");
            }
        }
    }
}
