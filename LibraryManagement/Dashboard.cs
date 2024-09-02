using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure You want to Exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isOpen("AddBooks") == false)
            {
                AddBooks addBooks = new AddBooks();
                addBooks.Show();
            }

        }
        private bool isOpen(string name)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (name == f.Name)
                {
                    f.Focus();
                    return true;
                }
            }
            return false;
        }

        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isOpen("ViewBook") == false)
            {
                ViewBook book = new ViewBook();
                book.Show();
            }
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isOpen("AddStudentcs") == false)
            {
                AddStudentcs Addstudent = new AddStudentcs();
                Addstudent.Show();
            }
        }

        private void viewStudentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isOpen("ViewStudent") == false)
            {
                ViewStudent student = new ViewStudent();
                student.Show();
            }
        }

        private void issueBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isOpen("IssueBooks") == false)
            {
                IssueBooks issuebooks = new IssueBooks();
                issuebooks.Show();
            }
        }

        private void returnBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isOpen("ReturnBooks") == false)
            {
                ReturnBooks returnbooks = new ReturnBooks();
                returnbooks.Show();
            }
        }

        private void completeBookDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isOpen ("CompleteBookDetail") == false)
            {
                CompleteBookDetail BD = new CompleteBookDetail();
                BD.Show();
            }
        }
    }
}
