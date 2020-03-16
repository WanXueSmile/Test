using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserDemo
{
    public partial class UserRegistFrm : Form
    {
        public UserRegistFrm()
        {
            InitializeComponent();
        }

        private void btnRegist_Click(object sender, EventArgs e)
        {
            // 将注册信息插入数据库
            //string conStr = "server=.;uid=sa;pwd=123456;database=MyFirstDb";
            string conStr = ConfigurationManager.ConnectionStrings["SqlConn"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    //cmd.CommandText = $"insert into UserInfo(UserName,UserAge,UserPwd,DelFlag,CreateDate) values('{txtUserName.Text}','{Convert.ToInt32(txtAge.Text)}','{txtPwd.Text}','0','{DateTime.Now.ToString()}')";
                    cmd.CommandText = $"insert into UserInfo(UserName,UserAge,UserPwd,DelFlag,CreateDate) values('{txtUserName.Text}','{Convert.ToInt32(txtAge.Text)}','{txtPwd.Text}', 0,getdate())";
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("OK");
        }
    }
}
