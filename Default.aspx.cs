using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using my= Ecomm.Web.Models;

namespace Ecomm.Web
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            my.User user= new my.User();
            if (IsPostBack)
            {
                if (TryUpdateModel<my.User>(user, new FormValueProvider(ModelBindingExecutionContext)))
                {
                    if (ModelState.IsValid)
                    {
                        user.IsActive = true;
                        user.Role = my.Role.User;
                    }
                }

            }

        }
    }
}