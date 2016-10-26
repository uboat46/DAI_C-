using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{

    protected OdbcConnection conectarBD()
    {
        String con = "Driver={SQL Server Native Client 11.0};Server=CC201-22;Uid=sa;Pwd=sqladmin;Database=gamespot;";
        try
        {
            OdbcConnection conexion = new OdbcConnection(con);
            conexion.Open();
            return conexion;
        }
        catch (Exception e)
        {
            Label8.Text = "(╯°□°）╯︵ ┻━┻ |||||||||||||| (╯°□°）╯︵ ┻━┻  |||||||||||||| (╯°□°）╯︵ ┻━┻ |||||||||||||| (╯°□°）╯︵ ┻━┻ |||||||||||||| (╯°□°）╯︵ ┻━┻ |||||||||||||| (╯°□°）╯︵ ┻━┻ |||||||||||||| (╯°□°）╯︵ ┻━┻ |||||||||||||| (╯°□°）╯︵ ┻━┻ |||||||||||||| (╯°□°）╯︵ ┻━┻ |||||||||||||| (╯°□°）╯︵ ┻━┻ |||||||||||||| (╯°□°）╯︵ ┻━┻ |||||||||||||| (╯°□°）╯︵ ┻━┻ |||||||||||||| (╯°□°）╯︵ ┻━┻ |||||||||||||| (╯°□°）╯︵ ┻━┻ |||||||||||||| (╯°□°）╯︵ ┻━┻";
            return null;
            //throw;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        OdbcConnection con = conectarBD();

        if (con != null)
        {
            OdbcCommand cmd = new OdbcCommand("SELECT MAX(usuario.claveU) FROM usuario", con);
            Object o = cmd.ExecuteScalar();
            if (DBNull.Value.Equals(o))
            {
                //NO HAY USUARIOS JAJAJA LOLZS
                //GET REKT +1
                String query = string.Format("INSERT INTO usuario VALUES(1,'{0}','{1}','{2}','{3}',{4})", TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text);
                cmd = new OdbcCommand(query, con);
                int res = cmd.ExecuteNonQuery();

                Label8.Text = res.ToString();
            }
            else
            {
                String query = string.Format("INSERT INTO usuario VALUES({0},'{1}','{2}','{3}','{4}',{5})",int.Parse(o.ToString())+1, TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text);
                cmd = new OdbcCommand(query, con);
                Label8.Text = query;
                int res = cmd.ExecuteNonQuery();

                if (res > 0)
                {
                    Label8.Text = res.ToString();
                }
                else
                    Label8.Text = "no pifo";


            }
            con.Close();
        }
        else
        {
            Label3.Text = "NO SE ESTABLECIO LLENADO DEL GRID \n (╯°□°）╯︵ ┻━┻ |||||||||||||| (╯°□°）╯︵ ┻━┻  |||||||||||||| (╯°□°）╯︵ ┻━┻ |||||||||||||| ";
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Menu.aspx");
    }
}