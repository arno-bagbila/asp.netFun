using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TiwooWebSite
{
    public partial class UserPage : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            //phUserInfoBox.Controls.Add(LoadControl("~/UserInfoBoxControl.ascx"));
            MyUserInfoBoxControl.UserName = "Ron Weasley";
            MyUserInfoBoxControl.UserAge = 18;
            MyUserInfoBoxControl.UserCountry = "Australia";
            UserInfoBoxControl userInfoBoxControl = (UserInfoBoxControl)LoadControl("~/UserInfoBoxControl.ascx");
            userInfoBoxControl.UserName = "Hermionie Granger";
            userInfoBoxControl.UserAge = 18;
            userInfoBoxControl.UserCountry = "France";
            phUserInfoBox.Controls.Add(userInfoBoxControl);
        }

        protected void MyEventUserControl_PageTitleUpdated(object sender, EventArgs e)
        {
            this.Title = MyEventUserControl.PageTitle;
        }
    }
}