using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Matricula
{
    public partial class matricula : System.Web.UI.Page
    {
        DataTable dt = new DataTable();
        controladoraBD_matricula controladora = new controladoraBD_matricula();

        protected void Page_Load(object sender, EventArgs e)
        {

            string user = "43529";
            dt=controladora.buscarMatricula("Ing Informatica", user);


            dgvMatri.DataSource = dt;
            dgvMatri.DataBind();

        }

        protected void btnmatricular_Click(object sender, EventArgs e)
        {
            Object[] objeto = new Object[8];

            objeto[0] = cmbcarrera.Text;
            objeto[1] = cmbcurso.Text;
            objeto[2] = cmbgrupo.Text;

           // controladora.insertarDatos(objeto);
        }

        protected void cmbcarrera_SelectedIndexChanged(object sender, EventArgs e)
        {

          /*  cmbcarrera.DataSource = controladora.buscarcarrera();
            cmbcarrera.DataValueField = "Nombre";
            cmbcarrera.DataTextField = "Nombre";
            cmbcarrera.DataBind();
            */



        }

        protected void cmbcurso_SelectedIndexChanged(object sender, EventArgs e)
        {
          

        }

        protected void cmbgrupo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

