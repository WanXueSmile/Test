using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnOpenUserRegistFrm_Click(object sender, EventArgs e)
        {
            UserRegistFrm userRegistFrm = new UserRegistFrm();
            userRegistFrm.Show();
        }

        private void btnOpenLoginFrm_Click(object sender, EventArgs e)
        {
            UserLoginFrm userLoginFrm = new UserLoginFrm();
            userLoginFrm.Show();
        }
    }
}
