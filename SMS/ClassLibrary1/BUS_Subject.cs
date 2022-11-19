using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL_SMS;

namespace ClassLibrary1
{
    public class BUS_Subject
    {
        DAL_Subject dalSubject = new DAL_Subject();
        public DataTable getSubject(String id)
        {
            return dalSubject.getSubject(id);
        }
        public bool insertSubject(string  id, string SubjectName, string SubjectMark)
        {
            return dalSubject.insertSubject(id, SubjectName, SubjectMark);
        }
    }
}
