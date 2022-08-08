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
    public partial class DepositForm : Form
    {
        int userid;
        MultipleOptionsDataStore multipleOptionsDataStore = null;
        public DepositForm(int userid)
        {
            InitializeComponent();
            this.userid = userid;
            multipleOptionsDataStore = new MultipleOptionsDataStore(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);
        }

        private void txtDeposit_TextChanged(object sender, EventArgs e)
        {
            int res = multipleOptionsDataStore.CashDeposit(userid, int.Parse(txtDeposit.Text));
            if (res == 2)
            {
                lblDepositMsg.Visible = true;
                lblDepositMsg.Text = "Amount Deposited successfully.";
            }
            else
            {
                lblDepositMsg.Visible = true;
                lblDepositMsg.Text = "Error occurred.";
            }
        }
    }
}
