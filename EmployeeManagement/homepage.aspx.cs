
// required namespaces for project
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
 
        // work done by insert button when it hits
        protected void btnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dataemp;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Table] VALUES ('"+txtUserID.Text+"','"+txtPass.Text+"','"+txtRole.Text+"')",con);

            con.Open();
            cmd.ExecuteNonQuery();
            Response.Write("Data Inserted successfully");
            con.Close();
        }

        // work done by update button when it hits
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dataemp;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand(@"UPDATE [dbo].[Table] SET [password]='"+txtPass.Text+"',[role]='"+txtRole.Text+ "' WHERE [userid] = '" + txtUserID.Text + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            Response.Write("Data Updated");
            con.Close();
        }

        // work done by delete button when it hits
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dataemp;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand(@"DELETE FROM [dbo].[Table] WHERE [userid] = '"+txtUserID.Text+"'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            Response.Write("Data Deleted successfully");
            con.Close();
        }

    }
    }