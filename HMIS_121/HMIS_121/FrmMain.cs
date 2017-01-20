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
    public partial class FrmMain : Form
    {
        #region Variable
        DAL.FPub Fee_Media = new DAL.FPub();
        #endregion
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnClose_Media_Click(object sender, EventArgs e)
        {
            try
            {
                txtMedia.Text.Trim();
                txtMedia.Text.ToString();
                long Media = long.Parse(txtMedia.Text);
                string text = Fee_Media.Close_Media_Fee(Media);
                //MessageBox.Show(text);
                if (text =="OK")
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn đã đóng Bệnh án thành công", "Thông Báo", MessageBoxButtons.YesNo);
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show(text, "Lỗi", MessageBoxButtons.YesNo);
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void btnOpen_Media_Click(object sender, EventArgs e)
        {
            try
            {
                txtMedia.Text.Trim();
                txtMedia.Text.ToString();
                long Media = long.Parse(txtMedia.Text);
                string text = Fee_Media.Open_Media_Fee(Media);               
                if (text == "OK")
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn đã mở Bệnh án thành công", "Thông Báo", MessageBoxButtons.YesNo);
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show(text, "Thông Báo", MessageBoxButtons.YesNo);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
