using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class index : System.Web.UI.Page
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
            OdbcCommand cmd = new OdbcCommand("SELECT juegos.nombre FROM juegos", con);
            OdbcDataReader dr = cmd.ExecuteReader();
            DropDownList1.Items.Clear();
            
            while(dr.Read())
            {
                DropDownList1.Items.Add(dr.GetString(0));
            }

            dr.Close();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text != null && TextBox2.Text != null)
        {
            OdbcConnection con = conectarBD();

            if (con != null)
            {
                String query = "SELECT usuario.claveU FROM usuario WHERE  usuario.email ='" + TextBox1.Text + "' AND usuario.password ='" + TextBox2.Text + "'";
                OdbcCommand cmd = new OdbcCommand(query, con);
                OdbcDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    Response.Redirect("Menu.aspx");
                }
                else
                {
                    Label1.Text = "USUARIO O PASSWORD INCORRECTOS!!!!!";
                }
                dr.Close();
            }
        }
    }
}