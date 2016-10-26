using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class uno : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int op1 = int.Parse(Request.Form["op1"]);
        int op2 = int.Parse(Request.Form["op2"]);

        Response.Write("<br /> <label>La suma de " + op1 + " y " + op2 + " es = <code style=\"color:red;font-size:20px;\">" + (op1 + op2) + "</code ></label>");
    }
}