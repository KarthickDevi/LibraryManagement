using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public  class clsIssueBook
    {
        static string _stuName = string.Empty;
        static string _stdDept = string.Empty;
        static string _stdSem = string.Empty;
        static string _stuContact = string.Empty;
        static string _stuEmail = string.Empty;
        static string _bookName = string.Empty;
        static DateTime _book_Issdate;
        public string stuName
        {
            get { return _stuName; }
            set { _stuName = value; }
        }
        public string stuDept
        {
            get { return _stdDept; }
            set { _stdDept = value; }
        }
        public string stuSem
        {
            get { return _stdSem; }
            set { _stdSem = value; }
        }
        public string stuContact
        {
            get { return _stuContact; }
            set { _stuContact = value; }
        }
        public string stuEmail
        {
            get { return _stuEmail; }
            set { _stuEmail = value; }
        }
        public string book_Name
        {
            get { return _bookName; }
            set { _bookName = value; }
        }
        public DateTime BookIssdate
        {
            get { return _book_Issdate; }
            set { _book_Issdate = value; }
        }
    }
}
