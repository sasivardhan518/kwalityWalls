using Kwality.DBConnect;
using Kwality.Library.Model;
using System;
using System.Collections.Generic;
using System.Data;

namespace Kwality.Library.Repository
{
    public class StudentRepository : BaseRepository
    {
        static List<StudentEntity> _students = new List<StudentEntity>();
        
        static DataTable GetAllUsers()
        {
            DataTable dtUser = SqlHelper.Execute("Select * from SalesTable order by ClientID");
            
            
            return dtUser;
        }

        public object GetById(int v, object _id)
        {
            throw new NotImplementedException();
        }

        

        public DataTable GetAll()
        {
            //return StudentRepository.GetDummyStudents();
            return StudentRepository.GetAllUsers();
        }
        public void Insert(StudentEntity objStudent)
        {
            SqlHelper.Update("INSERT INTO SalesTable(ClientID,ClientName,Chocolate,Vanilla) VALUES (" + objStudent.ID +",'" + objStudent.Name+"',"+ objStudent.Choco+","+objStudent.Vanilla+")");

        }
         public DataTable Searchinp(StudentEntity objStudent)
        {
            var searchfun=SqlHelper.Search(string.Format("SELECT * FROM SalesTable WHERE ClientID={0}",objStudent.ID));
            return searchfun;
        }
        
        public void update(StudentEntity objStudents)
        {
            SqlHelper.Update(string.Format("UPDATE SalesTable SET ClientName = '{0}', Chocolate ={1}, Vanilla ={2} WHERE ClientID ={3}", objStudents.Name, objStudents.Choco, objStudents.Vanilla, objStudents.ID));
        }
        public void Delete(StudentEntity objStudents1)
        {
            SqlHelper.Update(string.Format("DELETE FROM SalesTable WHERE ClientID={0}",objStudents1.ID));
        }
    }
}
