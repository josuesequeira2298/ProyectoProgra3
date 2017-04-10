using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Matricula
{
    public partial class matricula : System.Web.UI.Page
    {

        controladoraBD_matricula controladora = new controladoraBD_matricula();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnmatricular_Click(object sender, EventArgs e)
        {
            Object[] objeto = new Object[8];

            objeto[0] = cmbcarrera.Text;
            objeto[1] = cmbcurso.Text;
            objeto[2] = cmbgrupo.Text;

            controladora.insertarDatos(objeto);
        }

        protected void cmbcarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            cmbcarrera.DataSource=
        }

        protected void cmbcurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbcurso.DataSource=

            /* ddlCustomers.DataSource = cmd.ExecuteReader();
            ddlCustomers.DataTextField = "Name";
            ddlCustomers.DataValueField = "CustomerId";
            ddlCustomers.DataBind();
            */
        }

        protected void cmbgrupo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

