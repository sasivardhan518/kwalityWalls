using Kwality.DBConnect;
using Kwality.Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kwality.Library.Repository
{
   public class AdminRespository : BaseRepository
    {

        public void InsertAdmin(AdminEntity NewAdmin)
        {
             string str = $"INSERT INTO dbo.AdminTable(Name,email,password,UserType,FullName,Designation) values ('{NewAdmin.AdminName}','{NewAdmin.EmailID}','{NewAdmin.Password}','{NewAdmin.Usertype}','{NewAdmin.FullName}','{NewAdmin.Designation}')";

            // string str = $"INSERT INTO AdminTable(Name = '{NewAdmin.AdminName}',email='{NewAdmin.EmailID}',password='{NewAdmin.Password}',User Type='{NewAdmin.Usertype}',FullName='{NewAdmin.FullName}',Designation='{NewAdmin.Designation}')";
            SqlHelper.Update(str);

        }
    }
}
