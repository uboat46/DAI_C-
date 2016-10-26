using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected OdbcConnection conectarBD()
    {
        String con = "Driver={SQL Server Native Client 11.0};Server=CC201-22;Uid=sa;Pwd=sqladmin;Database=Mensajes;";
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
       
    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        if (TextBox3.Text != null && TextBox2.Text != null)
        {
            OdbcConnection con = conectarBD();

            if (con != null)
            {
                String query = "SELECT usuario.claveU,usuario.passwd FROM usuario WHERE  usuario.claveU ='" + TextBox3.Text + "' AND usuario.passwd ='" + TextBox2.Text + "'";
                OdbcCommand cmd = new OdbcCommand(query, con);
                OdbcDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    Response.Redirect("Informacion.aspx");
                }
                else
                {
                    Label4.Text = "Lo sentimos, tu claveU y/o contraseñas son incorrectos.";
                }
                dr.Close();
            }
        }
    }
}