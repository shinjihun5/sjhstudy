using System;
using mdiprotect.todo;
using mdiprotect.user;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace mdiprotect
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }
        private void 사용자관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserForm userForm = UserForm.getInstance();
            userForm.MdiParent = this;
            userForm.Show();

        }
        private void 할일관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Todoform todoForm = new Todoform();
            todoForm.MdiParent = this;
            todoForm.Show();
        }
        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        Dispose();
        }

     
    }
}
