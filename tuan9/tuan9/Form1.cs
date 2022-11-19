using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace tuan9
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=DESKTOP-KVD6FF6\\MYSQL;uid=sa;pwd=123; database=QlySach");
            try
            {
                con.Open();
                MessageBox.Show("okkk mấy thằng gà kết nối dc");
            }
            catch
            {
                MessageBox.Show("thằng ngòi cạnh lỗi");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Close();
            MessageBox.Show("dăng xuất sql");
        }
    } 
}
