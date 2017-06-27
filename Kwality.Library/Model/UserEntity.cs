using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kwality.Library.Model
{
    public class UserEntity : BaseEntity
    {
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public string UserType { get; set; }
        public string Designation { get; set; }
        public string VerificationCode { get; set; }
    }
}
