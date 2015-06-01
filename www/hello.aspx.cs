using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class www_hello : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
		lorem.InnerText = ClientQueryString; // "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
	}
}