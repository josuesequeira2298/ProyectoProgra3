using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Direcciones
{
    public class Entidad_provincia
    {
        string provincia;



        public Entidad_provincia(object[] atri)
        {
            this.provincia = atri[0].ToString();
        }
        public string Provincia
        {
            get { return provincia; }

            set { provincia = value; }
        }
    }
}