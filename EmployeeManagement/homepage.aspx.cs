using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace EmployeeManagement
{
    public partial class homepage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dataemp;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Table] VALUES ('"+txtUserID.Text+"','"+txtPass.Text+"','"+txtRole.Text+"')",con);

            con.Open();
            cmd.ExecuteNonQuery();
            Response.Write("Data Inserted successfully");
            con.Close();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=emplmanage;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand(@"UPDATE [dbo].[Table] SET[userid] = '" + txtUserID.Text + "',[password]='"+txtPass.Text+"',[role]='"+txtRole.Text+"'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            Response.Write("Data Updated");
            con.Close();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand(@"DELETE FROM [dbo].[Table] WHERE [userid] = '"+txtUserID.Text+"'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            Response.Write("Data Deleted successfully");
            con.Close();
        }

    }
    }