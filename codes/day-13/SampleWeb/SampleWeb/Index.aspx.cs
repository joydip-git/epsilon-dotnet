﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWeb
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ServerButtonClicked(object sender, EventArgs e)
        {
            string value = txtValue.Text;
            this.Response.Write(value);
        }
    }
}