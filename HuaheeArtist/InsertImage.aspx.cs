using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.IO;
using System.Data;

namespace HuaheeArtist
{
    public partial class InsertImage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string csp = Global.CSP;
            SqlConnection con = new SqlConnection(csp);

                if (FileUpload1.HasFile)
                {
                    string strname = Server.MapPath(FileUpload1.FileName);
                    FileUpload1.PostedFile.SaveAs(strname);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Product values('" + TextBox1.Text + "','" + strname + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Label1.Visible = true;
                    Label1.Text = "Image Uploaded successfully";
                    TextBox1.Text = "";
                }
                else
                {
                    Label1.Visible = true;
                    Label1.Text = "Plz upload the image!!!!";
                }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}