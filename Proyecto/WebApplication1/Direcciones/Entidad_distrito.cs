using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Direcciones
{
    public class Entidad_distrito
    {
        string distrito;
        string canton;
        string provincia;

        public Entidad_distrito(object[] atri)
        {
            this.distrito = atri[0].ToString();
            this.canton = atri[1].ToString();
            this.provincia = atri[2].ToString();
        }
        public string Distrito
        {
            get { return distrito; }

            set { distrito = value; }
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







