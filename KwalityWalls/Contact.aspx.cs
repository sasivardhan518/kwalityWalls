//using KWALITY_LIBRARY.Repository;
using Kwality.Library.Model;
using Kwality.Library.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KwalityWalls
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool IsView = false;

          UserEntity loggedinUser = Session["CurrentUser"] as UserEntity;
            if (!IsPostBack)
            {
                if (loggedinUser == null)
                {
                    Response.Redirect("~/Account/Login.aspx");
                }
                if (loggedinUser != null && loggedinUser.Designation == "M" && loggedinUser.VerificationCode=="1234")
                {
                    IsView = true;
                }
                StudentRepository obj = new StudentRepository();
                //if (gvice.Columns.Count > 0 && loggedinUser.Designation != "M")
                //{
                //    gvice.Columns.RemoveAt(4);
                //    gvice.Columns.RemoveAt(4);

                //}
                if (loggedinUser != null && loggedinUser.Designation == "M" && loggedinUser.VerificationCode != "1234")
                {
                    throw new System.ArgumentException("Verification you entered is incorrect");
                }
               
                if (!IsView)
                {
                    gviceView.DataSource = obj.GetAll();
                    gviceView.DataBind();

                }
                else
                {
                    gvice.DataSource = obj.GetAll();
                    gvice.DataBind();
                }

            }
        }
    }
}