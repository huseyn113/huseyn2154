using WindowsFormsApp1shop12.models;
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
    public partial class loginform : Form
    {
        k101shop1Entities db = new k101shop1Entities();
        public loginform()
        {
            InitializeComponent();
        }

        private void btnlo_Click(object sender, EventArgs e)
        {
            string email = txtemail.Text;
            string password = txtpass.Text;
            if (utilities.IsEmpty(new string[] { email, password }, string.Empty))
            {
                Worker activeWorker = db.Workers.FirstOrDefault(x => x.Email == email);
                if (activeWorker != null)
                {
                    if (activeWorker.Password == password.HashMe())
                    {

                        if(txtche.Checked)
                        {
                            Properties.Settings.Default.email = email;
                            Properties.Settings.Default.password = password;
                            Properties.Settings.Default.isChecked = true;
                            Properties.Settings.Default.Save();


                        }
                        else
                        {
                            Properties.Settings.Default.email = "";
                            Properties.Settings.Default.password = "";
                            Properties.Settings.Default.isChecked = false;

                            Properties.Settings.Default.Save();
                        }
                        dashboard dash = new dashboard(activeWorker);
                        dash.ShowDialog();
                    }
                    else
                    {
                        lblerror1.Text = "password doesn ngbj";
                        lblerror1.Visible = true;
                    }
                }
                else
                {
                    lblerror1.Text = "email doesn";
                    lblerror1.Visible = true;
                }
            }
            else
            {
                lblerror1.Text = "email & password fiel";
                lblerror1.Visible = true;
            }
        }

        private void loginform_Load(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.isChecked)
            {
                txtemail.Text = Properties.Settings.Default.email;
                txtpass.Text = Properties.Settings.Default.password;
            }
        }
    }
}
