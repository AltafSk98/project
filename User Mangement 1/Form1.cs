using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace User_Mangement_1
{
    public partial class Form1 : Form
    {
        SqlConnection conn=new SqlConnection("Data Source=DESKTOP-1M79L9Q;Initial Catalog=\"user mangement\";Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into tblUser values('"+txtName.Text+"','"+txtAddress.Text+"')",conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Save Successfully..!");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Delete From tblUser  where UserName = '"+txtName.Text+"'",conn);
                conn.Close() ;
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("update tblUser set UserAddrees ='" + txtAddress.Text + "' where UserName= '" + txtName.Text + "'",conn);
            cmd.ExecuteNonQuery();  
          conn.Close();
            MessageBox.Show("Update succefully");

        }
    }
}
