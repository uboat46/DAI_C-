using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Modificar : System.Web.UI.Page
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
            Label1.Text = "(╯°□°）╯︵ ┻━┻ |||||||||||||| (╯°□°）╯︵ ┻━┻  |||||||||||||| (╯°□°）╯︵ ┻━┻ |||||||||||||| (╯°□°）╯︵ ┻━┻ |||||||||||||| (╯°□°）╯︵ ┻━┻ |||||||||||||| (╯°□°）╯︵ ┻━┻ |||||||||||||| (╯°□°）╯︵ ┻━┻ |||||||||||||| (╯°□°）╯︵ ┻━┻ |||||||||||||| (╯°□°）╯︵ ┻━┻ |||||||||||||| (╯°□°）╯︵ ┻━┻ |||||||||||||| (╯°□°）╯︵ ┻━┻ |||||||||||||| (╯°□°）╯︵ ┻━┻ |||||||||||||| (╯°□°）╯︵ ┻━┻ |||||||||||||| (╯°□°）╯︵ ┻━┻ |||||||||||||| (╯°□°）╯︵ ┻━┻";
            return null;
            //throw;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        OdbcConnection con = conectarBD();

        if (con != null)
        {
            OdbcCommand cmd = new OdbcCommand("SELECT usuario.claveU FROM usuario", con);
            OdbcDataReader dr = cmd.ExecuteReader();
            DropDownList1.Items.Clear();

            while (dr.Read())
            {
                DropDownList1.Items.Add(dr.GetString(0));
            }

            dr.Close();
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Menu.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        OdbcConnection con = conectarBD();

        if (con != null)
        {

            String user = DropDownList1.SelectedValue.ToString();
            if (user != "" && TextBox1.Text != "" && TextBox2.Text != "")
            {
                String query = "UPDATE usuario SET usuario.email = '"+TextBox1.Text+"',usuario.password = '"+TextBox2.Text+"' WHERE usuario.claveU =" + user;
                OdbcCommand cmd = new OdbcCommand(query, con);
                int res = cmd.ExecuteNonQuery();
                Label2.Text = res > 0 ?"SE dio exitosamente la mod" : "No se dio de la mod";
                DropDownList1.Items.Clear();
            }
            con.Close();
        }
        else
        {
            Label2.Text = "NO SE ESTABLECIO LLENADO DEL GRID \n (╯°□°）╯︵ ┻━┻ |||||||||||||| (╯°□°）╯︵ ┻━┻  |||||||||||||| (╯°□°）╯︵ ┻━┻ |||||||||||||| ";
        }
    }
}