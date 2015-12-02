using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TiwooWebSite
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DropTheBeatLabel.Text = "Drop the Beat dude!";
        }

        protected void GreetButton_Click(object sender, EventArgs e)
        {
            DropTheBeatLabel.Text = "Drop the Beat " + TextInput.Text + "!";
        }

        protected void GreetList_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropTheBeatLabel.Text = "Drop the beat " + GreetList.SelectedValue;
        }
    }
}