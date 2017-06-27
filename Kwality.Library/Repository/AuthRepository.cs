using Kwality.DBConnect;
using Kwality.Library.Model;
using System.Data;

namespace Kwality.Library.Repository
{
    public class AuthRepository
    {
        /// <summary>
        /// This will Authenticate any User who is logging
        /// </summary>
        /// <param name="LoggedInUser"> Put Logging User Object Here</param>
        /// <returns></returns>
        public UserEntity Authenticate(UserEntity LoggedInUser)
        {
            UserEntity CurrentUser = null;

            //Check use user and Evalualate it
            //
            return LoggedInUser;
        }
        public UserEntity AuthenticateUser(UserEntity objCurrentUser1)
        {

            DataTable dtReturn = SqlHelper.Search(string.Format("SELECT * FROM AdminTable WHERE email='{0}' AND password='{1}'", objCurrentUser1.Email, objCurrentUser1.Password));
            objCurrentUser1.Password = "";
            if (dtReturn.Rows.Count > 0)
            {
                objCurrentUser1.ID = int.Parse(dtReturn.Rows[0]["ID"].ToString());
                objCurrentUser1.Name = dtReturn.Rows[0]["Name"].ToString();
                objCurrentUser1.FullName = dtReturn.Rows[0]["FullName"].ToString();
                objCurrentUser1.UserType = dtReturn.Rows[0]["UserType"].ToString();
                objCurrentUser1.Email = dtReturn.Rows[0]["Email"].ToString();
                objCurrentUser1.Designation = dtReturn.Rows[0]["Designation"].ToString();
                objCurrentUser1.VerificationCode= dtReturn.Rows[0]["VerificationCode"].ToString();
            }
            else
                objCurrentUser1 = null;
            //else return null
            return objCurrentUser1;


        }
        //public  
        //public void update(StudentEntity objStudent)
        //{
        //    SqlHelper.Update(string.Format("UPDATE SalesTable SET ClientName = '{0}', Chocolate ={1}, Vanilla ={2} WHERE ClientID ={3}", objStudent.Name, objStudent.Choco, objStudent.Vanilla, objStudent.ID));
        //}
    }
}

