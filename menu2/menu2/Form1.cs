using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lock_unlock(mySave.KT);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        void lock_unlock(bool kt)
        {
            mnclose.Enabled = mnLogin.Enabled = kt;
            mnlogout.Enabled = mnWork.Enabled = mnFind.Enabled = !kt;
        }

        private void mnLogin_Click(object sender, EventArgs e)
        {
            formLogin f = new formLogin();
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            lock_unlock(mySave.KT);
        }

        private void mnlogout_Click(object sender, EventArgs e)
        {
            mySave.KT = !mySave.KT;
            lock_unlock(mySave.KT);
        }
    }
}
