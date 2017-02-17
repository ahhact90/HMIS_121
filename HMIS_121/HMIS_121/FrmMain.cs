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
                string bhyt = Fee_Media.tonghop_chiphi_bhyt(Media);                
                //MessageBox.Show(bhyt);
                if (text =="OK" && bhyt == "OK")
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn đã đóng Bệnh án thành công", "Thông Báo", MessageBoxButtons.YesNo);
                }                
                else if (text == "OK" && bhyt != "OK")
                    {
                        Fee_Media.Open_Media_Fee(Media); 
                    DialogResult dialogResult = MessageBox.Show("Bạn chưa đóng hồ sơ nợ viện phí", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                          
                    }
               //else if(text != "OK" && bhyt == "OK")
               //     {
               //         DialogResult dialogResult = MessageBox.Show(text, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
               //     }
                else
                {
                    DialogResult dialogResult = MessageBox.Show(text, "Lỗi",MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    DialogResult dialogResult = MessageBox.Show(text, "Thông Báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //txtKq.Text = Fee_Media.Encrypt(txtMh.Text, "29fa797a-d341-4755-af56-8bf5aa6c9e5d", true);
            //MessageBox.Show( Fee_Media.Encrypt(txtMh.Text, "29fa797a-d341-4755-af56-8bf5aa6c9e5d", true));  
            ////MessageBox.Show
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //txtKq.Text = Fee_Media.Encrypt(txtMh.Text, "29fa797a-d341-4755-af56-8bf5aa6c9e5d", true);
            //MessageBox.Show( Fee_Media.Encrypt(txtMh.Text, "29fa797a-d341-4755-af56-8bf5aa6c9e5d", true));  
            //MessageBox.Show
        }
    }
}
