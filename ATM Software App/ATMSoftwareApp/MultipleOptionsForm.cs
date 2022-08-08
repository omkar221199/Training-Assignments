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
    public partial class MultipleOptionsForm : Form
    {
        int userid;
        MultipleOptionsDataStore multipleOptionsDataStore = null;

        ATMLoginForm aTMLoginForm = new ATMLoginForm();

        public MultipleOptionsForm(int userid)
        {
            InitializeComponent();
            this.userid = userid;
            multipleOptionsDataStore = new MultipleOptionsDataStore(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);
        }

        private void btnAccBalance_Click( object sender, EventArgs e)
        {
            double res = multipleOptionsDataStore.ViewAccountBalance(userid);
            lblAccBalance.Visible = true;
            lblBalance.Visible = true;
            lblBalance.Text = Convert.ToString(res);
            
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            DepositForm depositForm = new DepositForm(userid);
            depositForm.Show();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            WithdrawForm withdrawForm = new WithdrawForm(userid);
            withdrawForm.Show();
        }

        private void btnPrevTrans_Click(object sender, EventArgs e)
        {
            List<Transactions> tran = multipleOptionsDataStore.PrevTransactionDetails(userid);
            lblTran1.Visible = true;
            lblTran2.Visible = true;
            lblTran3.Visible = true;
            try
            {
                lblTran1.Text = tran[0].TranDate.ToString() + " " + tran[0].Amount.ToString() + " " + tran[0].Type.ToString();
                lblTran2.Text = tran[1].TranDate.ToString() + " " + tran[1].Amount.ToString() + " " + tran[1].Type.ToString();
                lblTran3.Text = tran[2].TranDate.ToString() + " " + tran[2].Amount.ToString() + " " + tran[2].Type.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Invalid Userid or something went wrong");
            }
        }
    }
}
