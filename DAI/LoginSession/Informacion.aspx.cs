using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Informacion : System.Web.UI.Page
{
    protected OdbcConnection connect()
    {
        OdbcConnection con = null;
        String conexion = "Driver={SQL Server Native Client 11.0}; Server=CC201-22;Uid=sa;Pwd=sqladmin;Database=Mensajeria";
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
        if (Session["respuesta"] == "NO!!!!!")
        {
            Response.Write("Usuario o Contraseña incorrectos!");
        }
        else 
        {
            String query = "SELECT * FROM usuario WHERE usuario.claveU = " + Session["respuesta"] + ";";
            OdbcConnection con = connect();
            OdbcCommand cmd = new OdbcCommand(query, con);
            OdbcDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                String datos = " Clave unica: ";
                datos = datos + dr.GetInt32(0);
                datos += "<br> Nombre: " + dr.GetString(1);
                datos += "<br> Correo: " + dr.GetString(2);
                datos += "<br> Password: " + dr.GetString(3);
                datos += "<br> edad: " + dr.GetInt32(4);
                Response.Write(datos);
            }
            dr.Close();
            con.Close();

        }
    }
}