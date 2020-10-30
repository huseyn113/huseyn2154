using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1shop12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnregi_Click(object sender, EventArgs e)
        {
            Register rgform = new Register();
            rgform.ShowDialog();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            loginform logform = new loginform();
            logform.ShowDialog();
        }
    }
}
