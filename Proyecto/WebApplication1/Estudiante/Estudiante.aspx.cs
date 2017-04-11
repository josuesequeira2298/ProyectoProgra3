using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Estudiante
{
    public partial class Estudiante : System.Web.UI.Page
    {
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();
        Controladora_estudiante controladora = new Controladora_estudiante();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
              {
                  Response.Redirect("~/Index.aspx");
              }
 
            string user = Session["user"].ToString();

            if (!IsPostBack)
            {
                dt = controladora.buscarEstudiante(user);
                
                lbcarnet.Text = dt.Rows[0][0].ToString();
                lbnombre.Text = dt.Rows[0][6].ToString() + " " + dt.Rows[0][7].ToString() + " " + dt.Rows[0][8].ToString();
                dt1 = controladora.buscarProvincia();
                cboProvincia.DataSource= dt1;
                cboProvincia.DataValueField = "Provincia";
                cboProvincia.DataTextField= "Provincia";
                cboProvincia.DataBind();
                dt2 = controladora.buscarCanton();
                cboCanton.DataSource = dt2;
                cboCanton.DataValueField = "Canton";
                cboCanton.DataTextField = "Canton";
                cboCanton.DataBind();
                dt3 = controladora.buscarDistrito();
                cboDistrito.DataSource = dt3;
                cboDistrito.DataValueField ="Distrito";
                cboDistrito.DataTextField ="Distrito" ;
                cboDistrito.DataBind();
            }



        }
        

        
       

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
          
            Response.Redirect("~/Index.aspx");

        }

        protected void datosEstudiante(object sender, EventArgs e)
        {

            string pass;
            string correo;
            string tel;
             

            if (txtContraseña.Text=="")
             
            {
                pass= dt.Rows[0][9].ToString();
                
            }
            else
            {
                pass = txtContraseña.Text;
            }

            if (TxtCorreo.Text == "")
            {
                correo = dt.Rows[0][4].ToString();
            }
            else
            {
                correo = TxtCorreo.Text;
            }

            if (txtTel.Text == "")
            {
                tel = dt.Rows[0][3].ToString();
            }
            else
            {
                tel = txtTel.Text;
            }

            string user = Session["user"].ToString();
            object[] objeto = new object[10];
            Entidad_estudiante estudiante = new Entidad_estudiante(objeto);

            objeto[0]= dt.Rows[0][0].ToString(); 
            objeto[1]= dt.Rows[0][1].ToString(); 
            objeto[2]= dt.Rows[0][2].ToString();
            objeto[3] = tel;
            objeto[4] = correo;
            objeto[5]="1";
            objeto[6]= dt.Rows[0][6].ToString();
            objeto[7]= dt.Rows[0][7].ToString();
            objeto[8]= dt.Rows[0][8].ToString();
            objeto[9] = pass;

            controladora.insertarDatos(objeto);
            Response.Redirect("~/Perfil.aspx");
        }

        protected void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
     
        }
        
    }
}