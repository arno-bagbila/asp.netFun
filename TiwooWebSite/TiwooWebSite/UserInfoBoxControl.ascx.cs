﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TiwooWebSite
{
    public partial class UserInfoBoxControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        private string userName;
        private int userAge;
        private string userCounrty;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public int UserAge
        {
            get { return userAge; }
            set { userAge = value; }
        }

        public string UserCountry
        {
            get { return userCounrty; }
            set { userCounrty = value; }
        }
    }
}