using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{

    protected OdbcConnection connect()
    {
        OdbcConnection con = null;
        String conexion = "Driver={SQL Server Native Client 11.0};Server=CC201-22;Uid=sa;Pwd=sqladmin;Database=Mensajeria";
        try 
	{
         con = new OdbcConnection(conexion);
         con.Open();
	}
	catch (Exception e)
	{
         Console.Write(e.ToString());
	}
        return con;
    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String claveU = TextBox1.Text;
        String pwd = TextBox2.Text;
        String query = "SELECT usuario.claveU FROM usuario WHERE usuario.claveU =" + claveU.ToString() + " AND usuario.passwd ='" + pwd.ToString() + "';";
        OdbcConnection con = connect();
        OdbcCommand cmd = new OdbcCommand(query, con);
        OdbcDataReader dr = cmd.ExecuteReader();

        if (dr.HasRows)
        {
            dr.Read();
            Session["respuesta"] = dr.GetInt32(0);
        }
        else 
        {
            Session["respuesta"] = "NO!!!!!";
        }
        dr.Close();
        con.Close();
        Response.Redirect("Informacion.aspx");

    }
}