using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Estudiante
{
    public partial class Estudiante : System.Web.UI.Page
    {
        Controladora_estudiante controladora = new Controladora_estudiante();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void datosEstudiante(object sender, EventArgs e)
        {
            int gen;
            if (cbogenero.SelectedItem.Text == "Masculino")
            {
                gen = 1;
            }
            else
            {
                gen = 0;
            }
            Object[] objeto = new Object[10];

            objeto[0] = txtCarnet.Text;
            objeto[1] = txtCedula.Text;
            objeto[2] = gen;
            objeto[3] = txtTelefono.Text;
            objeto[4] = txtCorreo.Text;
            objeto[5] = 1;
            objeto[6] = txtNombre.Text;
            objeto[7] = txtApellido1.Text;
            objeto[8] = txtApellido2.Text;
            objeto[9] = txtPassword.Text;


            controladora.insertarDatos(objeto);

            Response.Redirect("~/login/login.aspx");
        }
        protected void cargarEstudiante()
        {


        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido1.Text = "";
            txtApellido2.Text = "";
           
            txtCarnet.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            txtPassword.Text = "";
            txtCedula.Text = "";
            Response.Redirect("~/Index.aspx");

        }
    }
}