using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace NganHang
{
    public partial class FromDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public FromDangNhap()
        {
            InitializeComponent();
        }

        private void FromDangNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetMaster.V_DSPM' table. You can move, or remove it, as needed.
            this.v_DSPMTableAdapter.Fill(this.dataSetMaster.V_DSPM);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string server = ComboBoxCN.SelectedValue.ToString();
            string database = "NGANHANG";
            string userid = "";
            string password = "";
            userid = loginname.Text;
            Program.loginName = userid;
            password = Password.Text;
            string connectionString = "Server=" + server
                + ";" + "Database=" + database + ";" + "User id=" + userid + ";" + "Password=" + password;
            Program.sqlConnection = new SqlConnection(connectionString);
            try
            {
                Program.sqlConnection.Open();
                FormMain formmain = new FormMain();
                formmain.Activate();
                formmain.Show();
                this.Visible = false;
            }
            catch(Exception a)
            {
                MessageBox.Show("Ket noi that bai, sai id hoac password " + a.Message);
            }
            
        }

        private void ComboBoxCN_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}