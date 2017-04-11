﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ArrayList Lista = new ArrayList();
            string[] Archivos = System.IO.Directory.GetFiles(Server.MapPath("~/ImagenesCarreras"), "*.*");

            foreach (string archivo in Archivos)
            {
                Lista.Add("/ImagenesCarreras/" + System.IO.Path.GetFileName(archivo));
            }
            Repeater1.DataSource = Lista;
            Repeater1.DataBind();
        }

 

    }
}