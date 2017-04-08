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
            Object[] objeto = new Object[4];
            objeto[0] = txtNombre.Text;
            objeto[1] = txtApellido1.Text;
            objeto[2] = txtApellido2.Text;
            objeto[3] = txtGenero.Text;
            objeto[4] = txtCarnet.Text;
            objeto[4] = txtTelefono.Text;
            objeto[4] = txtCorreo.Text;
            objeto[4] = txtDireccion.Text;

            controladora.insertarDatos(objeto);
        }
        protected void cargarEstudiante()
        {


        }

        public void cancelar()
        {
            txtNombre.Text = "";
            txtApellido1.Text = "";
            txtApellido2.Text = "";
            txtGenero.Text = "";
            txtCarnet.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text = "";

        }
    }
}