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
        Controladora_matricula controladora = new Controladora_matricula();
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
    }
}