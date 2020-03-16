using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserDemo
{
    public partial class UserLoginFrm : Form
    {
        public UserLoginFrm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string conStr = "server=.;uid=sa;pwd=123456;database=MyFirstDb";
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = $"select count(1) from UserInfo where UserName = '{txtUserName.Text}' and UserPwd = '{txtPwd.Text}'";
                    //cmd.CommandText = $"select * from UserInfo";
                    object result = cmd.ExecuteScalar();
                    int rows = (int)result;
                    if(rows > 0)
                    {
                        MessageBox.Show("OK");
                    }
                    else
                    {
                        MessageBox.Show("Over");
                    }
                }
            }
            MessageBox.Show("OK");
        }
    }
}
