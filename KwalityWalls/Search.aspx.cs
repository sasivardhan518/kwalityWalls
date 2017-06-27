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
    public partial class Search : Page
    {
        StudentRepository objRepo = new StudentRepository();
        StudentEntity objStudent = new StudentEntity();
        public void buttonSearch(object sender, EventArgs e)
        {


            objStudent.ID = Convert.ToInt32(txtID.Text);
            IDSEARCH.DataSource = objRepo.Searchinp(objStudent);
            IDSEARCH.DataBind();
        }

    }
}