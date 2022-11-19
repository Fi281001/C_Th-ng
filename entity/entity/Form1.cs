using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace entity
{
    public partial class butDelete : Form
    {
        public butDelete()
        {
            InitializeComponent();
        }
        void loadDataToGridview()
        {
            dgvStudent.AutoGenerateColumns = false;
            using (SMDEntities db = new SMDEntities())
            {
                dgvStudent.DataSource = db.Students.ToList<Student>();
            }
        }

    
    }
}
