using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Direcciones
{
    public class Entidad_canton
    {
        string canton;
        public Entidad_canton(object[] atri)
        {
            this.canton = atri[0].ToString();
        }
        public string Canton
        {
            get { return canton; }

            set { canton = value; }
        }
    }
}