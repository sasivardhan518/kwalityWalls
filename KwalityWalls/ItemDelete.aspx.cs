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
    public partial class ItemDelete : System.Web.UI.Page
    {
        StudentRepository objRepos1 = new StudentRepository();
        StudentEntity objStudents1 = new StudentEntity();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string getid = Request.QueryString["keyid"];
                txtClientID.Text = getid;
                txtClientID.ReadOnly = true;
                string getname = Request.QueryString["keyName"];
                txtClientName.Text = getname;
                txtClientName.ReadOnly = true;
                string getchoco = Request.QueryString["keyChoco"];
                txtChoclateSoldCount.Text = getchoco;
                txtChoclateSoldCount.ReadOnly = true;
                string getVani = Request.QueryString["keyVani"];
                txtVanilaSoldCount.Text = getVani;
                txtVanilaSoldCount.ReadOnly = true;
            }
        }


        protected void btnSubmit_ClickYes(object sender, EventArgs e)
        {
            SaveMyObject();
            Response.Redirect("Contact.aspx");
        }

        private void SaveMyObject()
        {
            
            objStudents1.ID = Convert.ToInt32(txtClientID.Text);
            objRepos1.Delete(objStudents1);

        }
        protected void btnSubmit_ClickNo(object sender, EventArgs e)
        {
           
            Response.Redirect("Contact.aspx");
        }
    }
}