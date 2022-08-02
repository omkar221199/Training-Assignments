using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataDBLib;
using System.Configuration;

namespace WinFormAppDB
{
    public partial class LoginForm : Form
    {
        UserDataStore userDataStore = null;
        public LoginForm()
        {
            InitializeComponent();
            userDataStore = new UserDataStore(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Username = tbUsername.Text;
            user.Password = tbPassword.Text;
            try
            {
                bool result = userDataStore.ValidateUser(user.Username, user.Password);
                if (result == true)
                {
                    MessageBox.Show("Login Successful");
                    DataDmlForm frm = new DataDmlForm();
                    frm.Show();

                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wrong credentials");
            }
            
        }


    }
}
