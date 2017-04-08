using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Direcciones
{
    public class Entidad_distrito
    {
        string distrito;

        public Entidad_distrito(object[] atri)
        {
            this.distrito = atri[0].ToString();
        }
        public string Distrito
        {
            get { return distrito; }

            set { distrito = value; }
        }
    }


}