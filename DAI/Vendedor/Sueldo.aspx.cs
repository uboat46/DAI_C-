using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Sueldo : System.Web.UI.Page
{
    protected OdbcConnection conectarBD()
    {
        String con = "Driver={SQL Server Native Client 11.0};Server=CC201-22;Uid=sa;Pwd=sqladmin;Database=Ventas;";
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
    protected void Button1_Click(object sender, EventArgs e)
    {
        OdbcConnection con = conectarBD();

        if (con != null)
        {
            OdbcCommand cmd = new OdbcCommand("SELECT MAX(VENTA.idPedido) FROM venta", con);
            Object o = cmd.ExecuteScalar();
            if (DBNull.Value.Equals(o))
            {
                //NO HAY USUARIOS JAJAJA LOLZS
                //GET REKT +1
                String query = string.Format("INSERT INTO venta VALUES({0},'{1}','{2}')", 1, ,double.Parse(TextBox1.Text));
                cmd = new OdbcCommand(query, con);
                Label4.Text = query;
                int res = cmd.ExecuteNonQuery();

                if (res > 0)
                {
                    Label4.Text = res.ToString();
                }
                Label4.Text = "Seleciona un usuario valido";
            }
            else
            {
                DateTime date = DateTime.Today;
                String query = string.Format("INSERT INTO mensaje VALUES({0},'{1}','{2}','{3}','{4}',{5},{6})", int.Parse(o.ToString()) + 1, TextBox1.Text, TextBox2.Text, date.ToString("d"), date.ToString("d"), TextBox3.Text, DropDownList1.SelectedValue.ToString());
                cmd = new OdbcCommand(query, con);
                Label4.Text = query;
                int res = cmd.ExecuteNonQuery();

                if (res > 0)
                {
                    Label4.Text = res.ToString();
                }
                else
                    Label4.Text = "no pifo";


            }
            con.Close();
        }
        else
        {
            Label3.Text = "NO SE ESTABLECIO LLENADO DEL GRID \n (╯°□°）╯︵ ┻━┻ |||||||||||||| (╯°□°）╯︵ ┻━┻  |||||||||||||| (╯°□°）╯︵ ┻━┻ |||||||||||||| ";
        }
    }
}