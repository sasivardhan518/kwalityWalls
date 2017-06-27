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
    public partial class ItemEdit : System.Web.UI.Page
    {
        StudentRepository objRepos = new StudentRepository();
        StudentEntity objStudents = new StudentEntity();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string getid = Request.QueryString["keyid"];
                txtClientID.Text = getid;
                txtClientID.ReadOnly = true;
                string getname = Request.QueryString["keyName"];
                txtClientName.Text = getname;
                string getchoco = Request.QueryString["keyChoco"];
                txtChoclateSoldCount.Text = getchoco;
                string getVani = Request.QueryString["keyVani"];
                txtVanilaSoldCount.Text = getVani;
            }
        }


        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            SaveMyObject();
            Response.Redirect("Contact.aspx");
        }

        private void SaveMyObject()
        {
            objStudents.Name = txtClientName.Text;
            objStudents.Choco = Convert.ToInt32(txtChoclateSoldCount.Text);
            objStudents.Vanilla = Convert.ToInt32(txtVanilaSoldCount.Text);
            objStudents.ID = Convert.ToInt32(txtClientID.Text);
            objRepos.update(objStudents);

        }
    }
}