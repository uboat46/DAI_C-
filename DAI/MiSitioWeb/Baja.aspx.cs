using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Baja : System.Web.UI.Page
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
    protected void Button1_Click(object sender, EventArgs e)
    {
        OdbcConnection con = conectarBD();

        if (con != null)
        {   
            
            String user = DropDownList1.SelectedValue.ToString();
            if (user != "")
            {
                String query = "DELETE FROM escriben WHERE escriben.claveU =" + user;
                String query2 = "DELETE FROM usuario  WHERE  usuario.claveU =" + user;
                OdbcCommand cmd = new OdbcCommand(query, con);
                OdbcCommand cmd2 = new OdbcCommand(query2, con);
                int res = cmd.ExecuteNonQuery();
                int res2 = cmd2.ExecuteNonQuery();
                Label3.Text = res > 0 ? res2 > 0 ? "SE dio exitosamente de baja" : "No se dio de baja" : "no se dio de baja";
                DropDownList1.Items.Clear();
            }
            con.Close();
        }
        else
        {
            Label3.Text = "NO SE ESTABLECIO LLENADO DEL GRID \n (╯°□°）╯︵ ┻━┻ |||||||||||||| (╯°□°）╯︵ ┻━┻  |||||||||||||| (╯°□°）╯︵ ┻━┻ |||||||||||||| ";
        }

        
        //con = conectarBD();

        //if (con != null)
        //{
        //    OdbcCommand cmd = new OdbcCommand("SELECT usuario.nombre FROM usuario", con);
        //    OdbcDataReader dr = cmd.ExecuteReader();
        //    DropDownList1.Items.Clear();

        //    while (dr.Read())
        //    {
        //        DropDownList1.Items.Add(dr.GetString(0));
        //    }

        //    dr.Close();
        //}

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Menu.aspx");
    }
}