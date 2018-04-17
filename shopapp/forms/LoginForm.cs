using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shopapp.forms
{
    public partial class LoginForm : Form
    {
        public int Mode;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            loginComboBox.Items.Add("User");
            loginComboBox.Items.Add("Administrator");
            loginComboBox.SelectedIndex = 0;
        }

        private void loginComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Mode = loginComboBox.SelectedIndex;
        }
    }
}
