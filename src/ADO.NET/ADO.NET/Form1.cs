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

namespace ADO.NET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //SqlConnection conn = new SqlConnection();
            SqlConnectionStringBuilder conn = new SqlConnectionStringBuilder();
            propertyGrid1.SelectedObject = conn;
        }

        private void btnGetString_Click(object sender, EventArgs e)
        {
            string str = propertyGrid1.SelectedObject.ToString();
            Clipboard.Clear();
            Clipboard.SetText(str);
            MessageBox.Show(str);
        }
    }
}
