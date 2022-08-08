using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using ATMLib;


namespace ATMSoftwareApp
{
    public partial class WithdrawForm : Form
    {
        int userid;
        MultipleOptionsDataStore multipleOptionsDataStore = null;
        public WithdrawForm(int userid)
        {
            InitializeComponent();
            this.userid = userid;
            multipleOptionsDataStore = new MultipleOptionsDataStore(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);
        }

        private void txtWithdraw_TextChanged(object sender, EventArgs e)
        {
            int res = multipleOptionsDataStore.CashWithdraw(userid, int.Parse(txtWithdraw.Text));
            if (res == 2)
            {
                lblWithdrawMsg.Visible = true;
                lblWithdrawMsg.Text = "Amount Withdrew successfully.";
            }
            else
            {
                lblWithdrawMsg.Visible = true;
                lblWithdrawMsg.Text = "Error occurred.";
            }
        }
    }
}
