using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.ComponentModel.Design;

namespace menudangnhap
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void PassWord_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void butLogin_Click(object sender, EventArgs e)
        {
            string str = "server=DESKTOP-KVD6FF6\\MYSQL;uid=sa;pwd=123; database=dangnhap";
            save.Con = new SqlConnection(str);
            save.Con.Open();
            String s1 = "select username from _User where convert(varchar(100),DECRYPTBYPASSPHRASE('aaa',password))='" + txtPassWord.Text + " ' and username = '" + txtUserName.Text + "' ";
            SqlCommand com = new SqlCommand(s1, save.Con);
            SqlDataReader drd = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(drd);
            if(dt.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành Công", " thông báo");
                save.KT = !save.KT;
                Close();
            }
            else
            {
                MessageBox.Show("dang nhap ko thanh cong", "thong bao");
            }
           

                }
    }
}
