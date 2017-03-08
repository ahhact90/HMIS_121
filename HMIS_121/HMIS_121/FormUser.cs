using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMIS_121
{
    public partial class FormUser : Form
    {
        #region Variable
        DAL.FPub Fee_Media = new DAL.FPub();
        #endregion
        public FormUser()
        {
            InitializeComponent();
        }

        private void btKq_Click(object sender, EventArgs e)
        {
            //txtUser.Text = Fee_Media.Encrypt(txtMh.Text, "29fa797a-d341-4755-af56-8bf5aa6c9e5d", true);
            //MessageBox.Show(Fee_Media.Encrypt(txtUser.Text, "29fa797a-d341-4755-af56-8bf5aa6c9e5d", true));
            //MessageBox.Show();
        }

    }
}
