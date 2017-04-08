using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Direcciones
{
    public class Entidad_canton
    {
        string canton;
        string provincia;
        public Entidad_canton(object[] atri)
        {
            this.canton = atri[0].ToString();
            this.provincia = atri[1].ToString();
        }
        public string Canton
        {
            get { return canton; }

            set { canton = value; }
        }
        
        public string Provincia
        {
            get { return provincia; }

            set { canton = value; }
        }
    }
}