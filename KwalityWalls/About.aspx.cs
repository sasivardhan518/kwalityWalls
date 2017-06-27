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
    public partial class About : Page
    {
        StudentRepository objRepo = new StudentRepository();
        StudentEntity objStudent = new StudentEntity();
        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            objStudent.Name = txtClientName.Text;
            objStudent.Choco = Convert.ToInt32(txtChoclateSoldCount.Text);
            objStudent.Vanilla = Convert.ToInt32(txtVanilaSoldCount.Text);
            objStudent.ID = Convert.ToInt32(txtClientId.Text);
            objRepo.Insert(objStudent);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            UserEntity loggedinUser = Session["CurrentUser"] as UserEntity;
        }
        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session["CurrentUser"] = null;
            Server.Transfer("~/About.aspx");
        }
    }
}
