using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ATMLib;
using System.Configuration;

namespace ATMSoftwareApp
{
    public partial class ATMLoginForm : Form
    {
        UserDetails userDetails = null;
        public ATMLoginForm()
        {
            InitializeComponent();
            userDetails = new UserDetails(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);
        }

        private void txtDebitNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.CardNo = txtDebitNo.Text;
            user.Pin = txtPin.Text;

            try
            {
                int userid = userDetails.VaildateUser(user.CardNo, user.Pin);
                if (userid!=-1)
                {
                    MessageBox.Show("Login Successful");
                    MultipleOptionsForm frm = new MultipleOptionsForm(userid);
                    frm.Show();

                }
                else
                {
                    throw new Exception();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Wrong credentials");
            }
        }
    }
}
