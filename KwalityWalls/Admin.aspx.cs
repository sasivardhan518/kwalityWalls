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
    public partial class Admin : Page

    {
        AdminRespository NewAdmin = new AdminRespository();
        AdminEntity AdmUser = new AdminEntity();
        protected void btnSubmit_ADD(object sender, EventArgs e)
        {

            AdmUser.AdminName = txtAdminName.Text;
            AdmUser.EmailID = txtAdminEmailID.Text;
            AdmUser.Password = txtAdminPass.Text;
            AdmUser.Usertype = txtAdminType.Text;
            AdmUser.FullName = txtAdminFullName.Text;
            AdmUser.Designation= Designation.Text;
            AdmUser.VerificationCode=Verify.Text;
            NewAdmin.InsertAdmin(AdmUser);
            AdmUser = null;

             txtAdminName.Text= null ;
             txtAdminEmailID.Text=null;
          txtAdminPass.Text = null;
            txtAdminType.Text = null;
             txtAdminFullName.Text= null;
            Designation.Text= null;
             Verify.Text= null;
            Console.Write("The Admin was successfully created!Godd Day!");
        }

       
    }
}