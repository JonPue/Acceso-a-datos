using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DropDownListt
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string[] frutas = { "Manzanas", "Platanos", "Kiwis" };

        protected void Page_Load(object sender, EventArgs e)
        {
            DropDownList2.DataSource = frutas;
            DropDownList2.DataBind();

            //Dictionary
            Dictionary<int, string> dictFrutas = new Dictionary<int, string>();

            dictFrutas.Add(1, "Manzana");
            dictFrutas.Add(2, "Platanos");
            dictFrutas.Add(3, "Kiwis");

            DropDownList3.DataValueField = "Key";
            DropDownList3.DataTextField = "Value";

            DropDownList3.DataSource = dictFrutas;
            DropDownList3.DataBind();

        }


        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Response.Write(DropDownList1.SelectedValue.ToString());
        }
    }
}