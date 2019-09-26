using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ActividadWebForms1
{
    public partial class CodeBehind : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
    //Creamos un if para meter un postback que hace que si no le hemos metido pone "not postback" que es que no le hemos metido ningun dato y si si le hemos metido un dato pone is postback
           if (!Page.IsPostBack)
            {
                Response.Write("not postback ");
            }
            else
            {
                Response.Write("is postback ");
            }
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            //Aqui decimos al onclick que coja el valor
            Response.Write("OnClick");

            //aqui cojemos el label y la caja de texto y decimos que guarde el nombre que hemos introducido en la caja de texto que lo guarde en el label cuando apretemos el boton
            lblResultado.Text = txtNombre.Text.ToString();
            lblResultado2.Text = txtApellido.Text.ToString();
            lblResultado3.Text = txtEdad.Text.ToString();

        }
        protected void btnResult_Click(object sender, EventArgs e)
        {

            if (txtUser.Text=="User" && txtPass.Text=="Pass") { 
                Response.Redirect("~/WebForm1.aspx");
            }
            else
            {
                Response.Write("No es correcto");
            }

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label1.Text = DropDownList1.SelectedValue;
        }

        protected void btnhidde_Click(object sender, EventArgs e)
        {
            btnVisible.Visible = false;
            
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            btnVisible.Visible = true;
        }

       
    }
}